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

namespace Turismo.Models
{
    public partial class MantenedorCheck_In : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public MantenedorCheck_In()
        {
            InitializeComponent();
            cargaUsuario();
        }

        private async void MantenedorCheck_In_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewCheckIn> lst = JsonConvert.DeserializeObject<List<PostViewCheckIn>>(respuesta);
            dgvCheckIn.DataSource = lst;
        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/listarCheckIn/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }
        private void cargaUsuario()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SELECT id_reserva FROM reserva", ora);
            OracleDataAdapter data = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            ora.Close();

            DataRow fila = dt.NewRow();
            //fila["nom_usuario"] = "Nombre";
            dt.Rows.InsertAt(fila, 0);

            cbxIDReserva.ValueMember = "id_reserva";
            cbxIDReserva.DisplayMember = "id_reserva";
            cbxIDReserva.DataSource = dt;
        }//modicar la query para cargar los datos en el combobox

        private async void button1_Click(object sender, EventArgs e) // ingresar check-in
        {
            DateTime ingreso = FechaIngreso.SelectionStart;
            int idReserva = int.Parse(cbxIDReserva.SelectedValue.ToString());
            string url = "http://127.0.0.1:8000/checkIn/crear/";
            var checkin = new HttpClient();
            var Ingreso = ingreso.ToString("yyyy/MM/dd");

            PostViewCheckIn post = new PostViewCheckIn()
            {
                FECHA_CHECK_IN = Ingreso,
                OBSERVACION = txtObservacion.Text,
                RESERVA_ID_RESERVA = idReserva,
                

            };
            var data = JsonSerializer.Serialize<PostViewCheckIn>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await checkin.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewCheckIn>(result);

                MessageBox.Show("Ingresado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al ingresar el cliente intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            DateTime ingreso = FechaIngreso.SelectionStart;
            int idReserva = int.Parse(cbxIDReserva.SelectedValue.ToString());

            string url = "http://127.0.0.1:8000/checkIn/modificar/" + buscar;
            var checkin = new HttpClient();
            var Ingreso = ingreso.ToString("yyyy/MM/dd");            

            PostViewCheckIn post = new PostViewCheckIn()
            {
                FECHA_CHECK_IN = Ingreso,
                OBSERVACION = txtObservacion.Text,
                RESERVA_ID_RESERVA = idReserva,

            };
            var data = JsonSerializer.Serialize<PostViewCheckIn>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await checkin.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewCheckIn>(result);

                MessageBox.Show("Modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Modificar el ingreso del cliente, intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCheckIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = dgvCheckIn.CurrentRow.Cells[0].Value.ToString();
            FechaIngreso.Text = dgvCheckIn.CurrentRow.Cells[1].Value.ToString();
            txtObservacion.Text = dgvCheckIn.CurrentRow.Cells[2].Value.ToString();
            cbxIDReserva.Text = dgvCheckIn.CurrentRow.Cells[3].Value.ToString();
            
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/checkIn/eliminar/" + buscar;
            var checkin = new HttpClient();

            PostViewCheckIn post = new PostViewCheckIn()
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
                MessageBox.Show("Error al Eliminar el ingreso del cliente, intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            string respuesta = await GetHttp();
            List<PostViewCheckIn> lst = JsonConvert.DeserializeObject<List<PostViewCheckIn>>(respuesta);
            dgvCheckIn.DataSource = lst;

            async Task<string> GetHttp()
            {
                string url = "http://127.0.0.1:8000/checkIn/" + buscar;
                WebRequest oRequest = WebRequest.Create(url);
                WebResponse oResponse = oRequest.GetResponse();
                StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                return await sr.ReadToEndAsync();

            }
        }
    }
}
