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
using System.Windows.Forms;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Turismo.Models
{
    public partial class ServicioExtra : Form
    {
        public ServicioExtra()
        {
            InitializeComponent();
        }

        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://localhost:8000/listarServicioExtra/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async void ServicioExtra_Load(object sender, EventArgs e)
        {
            try
            {
                string respuesta = await GetHttp();
                List<PostViewServicioExtra> lst = JsonConvert.DeserializeObject<List<PostViewServicioExtra>>(respuesta);
                dgvServicioExtra.DataSource = lst;
            }
            catch
            {
                MessageBox.Show("NO se encontraron Servicios Extras", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var buscar = txtBuscar.Text;
                string respuesta = await GetHttp();
                List<PostViewServicioExtra> lst = JsonConvert.DeserializeObject<List<PostViewServicioExtra>>(respuesta);
                dgvServicioExtra.DataSource = lst;

                async Task<string> GetHttp()
                {
                    string url = "http://127.0.0.1:8000/ServicioExtra/" + buscar;
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();

                }

            }
            catch
            {
                MessageBox.Show("NO se encontraron los Servicios solicitado", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/ServicioExtra/eliminar/" + buscar;
            var servicio = new HttpClient();

            PostViewServicioExtra post = new PostViewServicioExtra()
            {

            };

            var httpResponse = await servicio.DeleteAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();


                MessageBox.Show("Eliminado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Eliminar el Servicio, intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/ServicioExtra/modificar/" + buscar;
            var servicio = new HttpClient();

            PostViewServicioExtra post = new PostViewServicioExtra()
            {
                NOM_SERVICIO_EXTRA = txtNombreExtra.Text,
                VALOR_SERVICIO_EXTRA = int.Parse(txtValor.Text)                
            };
            var data = JsonSerializer.Serialize<PostViewServicioExtra>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await servicio.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewServicioExtra>(result);

                MessageBox.Show("Modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al modificar el servicio intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:8000/ServicioExtra/crear/";
            var depto = new HttpClient();
            

            PostViewServicioExtra post = new PostViewServicioExtra()
            {
                NOM_SERVICIO_EXTRA = txtNombreExtra.Text,
                VALOR_SERVICIO_EXTRA = int.Parse(txtValor.Text)
            };
            var data = JsonSerializer.Serialize<PostViewServicioExtra>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await depto.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewServicioExtra>(result);

                MessageBox.Show("Creado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al crear servicio intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServicioExtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = dgvServicioExtra.CurrentRow.Cells[0].Value.ToString();
            txtNombreExtra.Text = dgvServicioExtra.CurrentRow.Cells[1].Value.ToString();
            txtValor.Text = dgvServicioExtra.CurrentRow.Cells[2].Value.ToString();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewServicioExtra> lst = JsonConvert.DeserializeObject<List<PostViewServicioExtra>>(respuesta);
            dgvServicioExtra.DataSource = lst;

        }

        ErrorProvider errorP = new ErrorProvider();

        private void txtNombreExtra_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtNombreExtra))
                errorP.SetError(txtNombreExtra, "No puede dejar vacio");
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
    }
}
