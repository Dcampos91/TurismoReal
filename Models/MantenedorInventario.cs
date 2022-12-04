using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Turismo.Models
{
    public partial class MantenedorInventario : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");

        public MantenedorInventario()
        {
            InitializeComponent();
            cargaDepartamento();
            cargaProducto();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)//agregar inventario
        {
            DateTime ingreso = FechaInventario.SelectionStart;
            var Ingreso = ingreso.ToString("yyyy/MM/dd");
            int idDepartamento = int.Parse(cbxIDdepartamento.SelectedValue.ToString());
            int idProducto = int.Parse(cbxIDProducto.SelectedValue.ToString());
            string url = "http://127.0.0.1:8000/inventario/crear/";
            var checkin = new HttpClient();            

            PostViewInventario post = new PostViewInventario()
            {

                FECHA_INVENTARIO = Ingreso,
                CANT_PRODUCTO_INVENTARIO = int.Parse(txtCantidad.Text),
                VALOR_ESTIMADO = int.Parse(txtValor.Text),
                DESCRIPCION_INVENTARIO = txtDescripcion.Text,
                DEPARTAMENTO_ID_DEPARTAMENTO = idDepartamento,
                PRODUCTO_ID_PRODUCTO = idProducto,

            };
            var data = JsonSerializer.Serialize<PostViewInventario>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await checkin.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewCheckIn>(result);

                MessageBox.Show("Inventario ingresado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al ingresar el inventario,intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void MantenedorInventario_Load(object sender, EventArgs e)//listar inventario
        {
            try 
            {
                string respuesta = await GetHttp();
                List<PostViewInventario> lst = JsonConvert.DeserializeObject<List<PostViewInventario>>(respuesta);
                dgvInventario.DataSource = lst;
            }
            catch
            {
                MessageBox.Show("NO se encontraron inventarios", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/listarInventario/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private void cargaDepartamento()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SELECT nom_depto,id_departamento FROM departamento ORDER BY nom_depto ASC", ora);
            OracleDataAdapter data = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            ora.Close();

            DataRow fila = dt.NewRow();
            fila["nom_depto"] = "Nombre departamento";
            dt.Rows.InsertAt(fila, 0);

            cbxIDdepartamento.ValueMember = "id_departamento";
            cbxIDdepartamento.DisplayMember = "nom_depto";
            cbxIDdepartamento.DataSource = dt;
            ora.Close();
        }

        private void cargaProducto()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SELECT id_producto,nom_producto FROM producto", ora);
            OracleDataAdapter data = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            ora.Close();

            DataRow fila = dt.NewRow();
            fila["nom_producto"] = "Nombre producto";
            dt.Rows.InsertAt(fila, 0);

            cbxIDProducto.ValueMember = "id_producto";
            cbxIDProducto.DisplayMember = "nom_producto";
            cbxIDProducto.DataSource = dt;
            ora.Close();
        }

        private async void btnModificar_Click(object sender, EventArgs e)//modifica inventario
        {
            var buscar = txtBuscar.Text;
            DateTime ingreso = FechaInventario.SelectionStart;
            var Ingreso = ingreso.ToString("yyyy/MM/dd");
            int idDepartamento = int.Parse(cbxIDdepartamento.SelectedValue.ToString());
            int idProducto = int.Parse(cbxIDProducto.SelectedValue.ToString());
            string url = "http://127.0.0.1:8000/inventario/modificar/" + buscar;
            var checkin = new HttpClient();

            PostViewInventario post = new PostViewInventario()
            {

                FECHA_INVENTARIO = Ingreso,
                CANT_PRODUCTO_INVENTARIO = int.Parse(txtCantidad.Text),
                VALOR_ESTIMADO = int.Parse(txtCantidad.Text),
                DESCRIPCION_INVENTARIO = txtDescripcion.Text,
                DEPARTAMENTO_ID_DEPARTAMENTO = idDepartamento,
                PRODUCTO_ID_PRODUCTO = idProducto,

            };
            var data = JsonSerializer.Serialize<PostViewInventario>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await checkin.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewCheckIn>(result);

                MessageBox.Show("Inventario modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al modificar el inventario,intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)//eliminar inventario
        {
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/inventario/eliminar/" + buscar;
            var checkin = new HttpClient();

            PostViewInventario post = new PostViewInventario()
            {

            };

            var httpResponse = await checkin.DeleteAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();


                MessageBox.Show("Eliminado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Eliminar el producto seleccionado, intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)//auto completa 
        {
            txtBuscar.Text = dgvInventario.CurrentRow.Cells[0].Value.ToString();
            FechaInventario.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
            txtDescripcion.Text = dgvInventario.CurrentRow.Cells[4].Value.ToString();
            cbxIDdepartamento.Text = dgvInventario.CurrentRow.Cells[5].Value.ToString();
            cbxIDProducto.Text = dgvInventario.CurrentRow.Cells[6].Value.ToString();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)//busca inventario
        {
            try
            {

                var buscar = txtBuscar.Text;
                string respuesta = await GetHttp();
                List<PostViewInventario> lst = JsonConvert.DeserializeObject<List<PostViewInventario>>(respuesta);
                dgvInventario.DataSource = lst;

                async Task<string> GetHttp()
                {
                    string url = "http://127.0.0.1:8000/inventario/" + buscar;
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();

                }

            }
            catch
            {
                MessageBox.Show("NO se encontraron id de inventario", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewInventario> lst = JsonConvert.DeserializeObject<List<PostViewInventario>>(respuesta);
            dgvInventario.DataSource = lst;
        }
        ErrorProvider errorP = new ErrorProvider();
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtCantidad, "Solo números");
            else
                errorP.Clear();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtValor, "Solo números");
            else
                errorP.Clear();
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtDescripcion))
                errorP.SetError(txtDescripcion, "No puede dejar vacio");
            else
                errorP.Clear();
        }
    }
}
