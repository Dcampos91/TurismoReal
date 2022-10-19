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


namespace Turismo.Models
{
    public partial class MantenedorUsuario : Form
    {
        public MantenedorUsuario()
        {
            InitializeComponent();
        }

        private async void MantenedorUsuario_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewUsuario> lst = JsonConvert.DeserializeObject<List<PostViewUsuario>>(respuesta);
            dgvUsuario.DataSource = lst;
        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/usuario/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async void btnBuscar_Click(object sender, EventArgs e)//Buscar Usuario
        {
            var buscar = txtBuscar.Text;
            string respuesta = await GetHttp();
            List<PostViewUsuario> lst = JsonConvert.DeserializeObject<List<PostViewUsuario>>(respuesta);
            dgvUsuario.DataSource = lst;

            async Task<string> GetHttp()
            {
                string url = "http://127.0.0.1:8000/usuario/"+buscar;
                WebRequest oRequest = WebRequest.Create(url);
                WebResponse oResponse = oRequest.GetResponse();
                StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                return await sr.ReadToEndAsync();

            }
        }

        private async void btnAgregarUsuario_Click(object sender, EventArgs e)//Crear Usuario
        {
            string url = "http://127.0.0.1:8000/usuario/crear/";
            var usuario = new HttpClient();

            PostViewUsuario post = new PostViewUsuario()
            {
                NOM_USUARIO = txtNomUsuario.Text,
                CORREO_USUARIO = txtCorreoUsuario.Text,
                CONTRASENIA = txtContraseniaUsuario.Text,
                ESTADO_USUARIO = char.Parse(txtEstadoUsuario.Text),
                TIPO_USUARIO_ID_TIPO_USUARIO = int.Parse(txtTipoUsuario.Text)
               
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
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/usuario/modificar/"+buscar;
            var usuario = new HttpClient();

            PostViewUsuario post = new PostViewUsuario()
            {
                NOM_USUARIO = txtNomUsuario.Text,
                CORREO_USUARIO = txtCorreoUsuario.Text,
                CONTRASENIA = txtContraseniaUsuario.Text,
                ESTADO_USUARIO = char.Parse(txtEstadoUsuario.Text),
                TIPO_USUARIO_ID_TIPO_USUARIO = int.Parse(txtTipoUsuario.Text)

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
            txtEstadoUsuario.Text = dgvUsuario.CurrentRow.Cells[4].Value.ToString();
            txtTipoUsuario.Text = dgvUsuario.CurrentRow.Cells[5].Value.ToString();
            
        }
    }
}
