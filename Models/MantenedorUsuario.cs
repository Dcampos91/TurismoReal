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
//using Turismo.Models.Request;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Runtime.InteropServices;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.Kernel.Pdf.Canvas.Wmf;

namespace Turismo.Models
{
    

    public partial class MantenedorUsuario : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public MantenedorUsuario()
        {
            InitializeComponent();
            cargaUsuario();
        }

        private async void MantenedorUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                string respuesta = await GetHttp();
                List<PostViewUsuario> lst = JsonConvert.DeserializeObject<List<PostViewUsuario>>(respuesta);
                dgvUsuario.DataSource = lst;
            }
            catch
            {
                MessageBox.Show("NO se encontraron usuarios registrados", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cbxEstado.Items.Add("Seleccionar");
            cbxEstado.Items.Add("Habilitado");
            cbxEstado.Items.Add("Deshabilitado");

          

        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/usuario/";
            //string url = "http://127.0.0.1:8000/usuarioAdmin/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async void btnBuscar_Click(object sender, EventArgs e)//Buscar Usuario
        {
            try
            {
                var buscar = txtBuscar.Text;
                string respuesta = await GetHttp();
                List<PostViewUsuario> lst = JsonConvert.DeserializeObject<List<PostViewUsuario>>(respuesta);
                dgvUsuario.DataSource = lst;

                async Task<string> GetHttp()
                {
                    string url = "http://127.0.0.1:8000/usuario/" + buscar;
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();

                }
            }
            catch
            {
                MessageBox.Show("NO se encontraron id de usuario", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private async void btnAgregarUsuario_Click(object sender, EventArgs e)//Crear Usuario
        {
            int selectedIndex = cbxEstado.SelectedIndex;
            Object selectedItem = cbxEstado.SelectedItem;

            string url = "http://127.0.0.1:8000/usuario/crear/";
            var usuario = new HttpClient();
            string idTipoUsuario = cbxTipoUsuario.SelectedValue.ToString();
            string Estado = "" + selectedIndex;

            PostViewUsuario post = new PostViewUsuario()
            {
                NOM_USUARIO = txtNomUsuario.Text,
                CORREO_USUARIO = txtCorreoUsuario.Text,
                CONTRASENIA = txtContraseniaUsuario.Text,
                ESTADO_USUARIO = Estado,
                TIPO_USUARIO_ID_TIPO_USUARIO = idTipoUsuario

            };
            var data = JsonSerializer.Serialize<PostViewUsuario>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await usuario.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewDepartamento>(result);

                MessageBox.Show("Creado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear el usuario intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminarUsuario_Click(object sender, EventArgs e)//Eliminar Usuario
        {
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/usuario/eliminar/"+buscar;
            var usuario = new HttpClient();

            PostViewUsuario post = new PostViewUsuario()
            {

            };

            var httpResponse = await usuario.DeleteAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();


                MessageBox.Show("Eliminado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Eliminar el usuario intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)//Actualiza datagrid Usuario
        {
            string respuesta = await GetHttp();
            List<PostViewUsuario> lst = JsonConvert.DeserializeObject<List<PostViewUsuario>>(respuesta);
            dgvUsuario.DataSource = lst;
        }

        private async void btnModificarUsuario_Click(object sender, EventArgs e)//modifcar Usuario
        {
            int selectedIndex = cbxEstado.SelectedIndex;
            Object selectedItem = cbxEstado.SelectedItem;
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/usuario/modificar/"+buscar;
            var usuario = new HttpClient();
            string idTipoUsuario = cbxTipoUsuario.SelectedValue.ToString();
            string Estado = "" + selectedIndex;

            PostViewUsuario post = new PostViewUsuario()
            {
                NOM_USUARIO = txtNomUsuario.Text,
                CORREO_USUARIO = txtCorreoUsuario.Text,
                CONTRASENIA = txtContraseniaUsuario.Text,
                ESTADO_USUARIO = Estado,
                TIPO_USUARIO_ID_TIPO_USUARIO = idTipoUsuario

            };
            var data = JsonSerializer.Serialize<PostViewUsuario>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await usuario.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewDepartamento>(result);

                MessageBox.Show("Modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Modificar el usuario intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)//Auto Rellenar
        {
            txtBuscar.Text = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNomUsuario.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
            txtCorreoUsuario.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtContraseniaUsuario.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
            cbxEstado.Text = dgvUsuario.CurrentRow.Cells[4].Value.ToString();
            cbxTipoUsuario.Text = dgvUsuario.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void cargaUsuario()
        {

            ora.Open();
            OracleCommand comando = new OracleCommand("SELECT id_tipo_usuario,tipo_usuario FROM tipo_usuario ORDER BY tipo_usuario ASC", ora);
            OracleDataAdapter data = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            ora.Close();

            DataRow fila = dt.NewRow();
            fila["tipo_usuario"] = "Tipo";
            dt.Rows.InsertAt(fila, 0);

            cbxTipoUsuario.ValueMember = "id_tipo_usuario";
            cbxTipoUsuario.DisplayMember = "tipo_usuario";
            cbxTipoUsuario.DataSource = dt;
        }

           

        ErrorProvider errorP = new ErrorProvider();
        private void txtNomUsuario_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtNomUsuario))
                errorP.SetError(txtNomUsuario, "No puede dejar vacio");
            else
                errorP.Clear();
        }

        private void txtContraseniaUsuario_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtContraseniaUsuario))
                errorP.SetError(txtContraseniaUsuario, "No puede dejar vacio");
            else
                errorP.Clear();
        }

        private void txtCorreoUsuario_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtCorreoUsuario))
                errorP.SetError(txtCorreoUsuario, "No puede dejar vacio");
            if (!ValidarTxt.validarEmail(txtCorreoUsuario.Text))
                errorP.SetError(txtCorreoUsuario, "Correo no valido");
            else
                errorP.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
