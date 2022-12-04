using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Runtime.InteropServices;
using iText.Kernel.Geom;
using System.Globalization;
using System.Data.OracleClient;

namespace Turismo.Models
{
    public partial class Reserva : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public Reserva()
        {
            InitializeComponent();
            cargaDepartamento();
            cargaCliente();
        }

        public async void Reserva_Load(object sender, EventArgs e)
        {
            try
            {
                string respuesta = await GetHttp();
                List<PostViewReserva> lst = JsonConvert.DeserializeObject<List<PostViewReserva>>(respuesta);
                dgvReserva.DataSource = lst;
            }

            catch
            { 
                MessageBox.Show("NO se encontraron reservas", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
            
        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/reservabruto/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();           

        }
        

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime ingreso = FechaIngreso.SelectionStart;
            DateTime salida = FechaSalida.SelectionStart;
            DateTime modificacion = FechaEstado.SelectionStart;
            string url = "http://127.0.0.1:8000/reserva/crear";
            var reserva = new HttpClient();
            var Ingreso = ingreso.ToString("yyyy/MM/dd");
            var Salida = salida.ToString("yyyy/MM/dd");
            var Modificacion = modificacion.ToString("yyyy/MM/dd");
            var IngresoD = ingreso.ToString("dd");
            var SalidaD = salida.ToString("dd");
            var total = IngresoD + SalidaD;
            int idCliente = int.Parse(cbxCliente.SelectedValue.ToString());
            int idDepartamento = int.Parse(cbxDepartamento.SelectedValue.ToString());
            PostViewReserva post = new PostViewReserva()
            {
                FECHA_INGRESO = Ingreso,
                FECHA_SALIDA = Salida,
                CANT_DIA_RESERVA = int.Parse(txtCantidadDias.Text),
                ESTADO_RESERVA = cbxEstadoReserva.Text,
                FECHA_ESTADO_RESERVA = Modificacion,
                DEPARTAMENTO_ID_DEPARTAMENTO = idDepartamento,
                USUARIO_ID_USUARIO = idCliente,


            };
            var data = JsonSerializer.Serialize<PostViewReserva>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await reserva.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewDepartamento>(result);

                MessageBox.Show("Creado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear la reserva intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargaCliente()
        {

            ora.Open();
            OracleCommand comando = new OracleCommand("SELECT nom_cliente,usuario_id_usuario FROM cliente ORDER BY nom_cliente ASC", ora);
            OracleDataAdapter data = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            ora.Close();

            DataRow fila = dt.NewRow();
            fila["nom_cliente"] = "Nombre";
            dt.Rows.InsertAt(fila, 0);

            cbxCliente.ValueMember = "usuario_id_usuario";
            cbxCliente.DisplayMember = "nom_cliente";
            cbxCliente.DataSource = dt;
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
            fila["nom_depto"] = "Nombre";
            dt.Rows.InsertAt(fila, 0);

            cbxDepartamento.ValueMember = "id_departamento";
            cbxDepartamento.DisplayMember = "nom_depto";
            cbxDepartamento.DataSource = dt;
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            DateTime ingreso = FechaIngreso.SelectionStart;
            DateTime salida = FechaSalida.SelectionStart;
            DateTime modificacion = FechaEstado.SelectionStart;
            string url = "http://127.0.0.1:8000/reserva/modificar/"+buscar;
            var reserva = new HttpClient();
            var Ingreso = ingreso.ToString("yyyy/MM/dd");
            var Salida = salida.ToString("yyyy/MM/dd");
            var Modificacion = modificacion.ToString("yyyy/MM/dd");
            int idCliente = int.Parse(cbxCliente.SelectedValue.ToString());
            int idDepartamento = int.Parse(cbxDepartamento.SelectedValue.ToString());
            PostViewReserva post = new PostViewReserva()
            {
                FECHA_INGRESO = Ingreso,
                FECHA_SALIDA = Salida,
                CANT_DIA_RESERVA = int.Parse(txtCantidadDias.Text),
                ESTADO_RESERVA = cbxEstadoReserva.Text,
                FECHA_ESTADO_RESERVA = Modificacion,
                DEPARTAMENTO_ID_DEPARTAMENTO = idDepartamento,
                USUARIO_ID_USUARIO = idCliente,
            };
            var data = JsonSerializer.Serialize<PostViewReserva>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await reserva.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewDepartamento>(result);

                MessageBox.Show("Modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Modificar la reserva intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = dgvReserva.CurrentRow.Cells[0].Value.ToString();
            FechaIngreso.Text = dgvReserva.CurrentRow.Cells[1].Value.ToString();
            FechaSalida.Text = dgvReserva.CurrentRow.Cells[2].Value.ToString();
            txtCantidadDias.Text = dgvReserva.CurrentRow.Cells[3].Value.ToString();
            cbxEstadoReserva.Text = dgvReserva.CurrentRow.Cells[4].Value.ToString();
            //FechaEstado.Text = dgvReserva.CurrentRow.Cells[5].Value.ToString();
            cbxDepartamento.Text = dgvReserva.CurrentRow.Cells[6].Value.ToString();
            cbxCliente.Text = dgvReserva.CurrentRow.Cells[7].Value.ToString();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/reserva/eliminar/" + buscar;
            var depto = new HttpClient();

            PostViewDepartamento post = new PostViewDepartamento()
            {

            };

            var httpResponse = await depto.DeleteAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();


                MessageBox.Show("Eliminado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Eliminar la reserva intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var buscar = txtBuscar.Text;
                string respuesta = await GetHttp();
                List<PostViewReserva> lst = JsonConvert.DeserializeObject<List<PostViewReserva>>(respuesta);
                dgvReserva.DataSource = lst;

                async Task<string> GetHttp()
                {

                    string url = "http://127.0.0.1:8000/reserva/" + buscar;
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();

                }
            }
            catch 
            {
                MessageBox.Show("Error al Buscar la Reserva", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewReserva> lst = JsonConvert.DeserializeObject<List<PostViewReserva>>(respuesta);
            dgvReserva.DataSource = lst;
        }
    }
}
