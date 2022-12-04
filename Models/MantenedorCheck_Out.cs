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
    public partial class MantenedorCheck_Out : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public MantenedorCheck_Out()
        {
            InitializeComponent();
            cargaUsuario();
            cargaMulta();
        }

        private async void MantenedorCheck_Out_Load(object sender, EventArgs e)
        {
            try
            {
                string respuesta = await GetHttp();
                List<PostViewCheckOut> lst = JsonConvert.DeserializeObject<List<PostViewCheckOut>>(respuesta);
                dgvCheckOut.DataSource = lst;
            }
            catch 
            {
                MessageBox.Show("NO se encontraron id de check out", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/listarCheckOut/";
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

            cbxReserva.ValueMember = "id_reserva";
            cbxReserva.DisplayMember = "id_reserva";
            cbxReserva.DataSource = dt;
            ora.Close();
        }//modicar la query para cargar los datos en el combobox

        private void cargaMulta()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SELECT id_multa FROM multa", ora);
            OracleDataAdapter data = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            ora.Close();

            DataRow fila = dt.NewRow();
            //fila["nom_usuario"] = "Nombre";
            dt.Rows.InsertAt(fila, 0);

            cbxMulta.ValueMember = "id_multa";
            cbxMulta.DisplayMember = "id_multa";
            cbxMulta.DataSource = dt;
            ora.Close();
        }//modicar la query para cargar los datos en el combobox


        private async void btnAgregar_Click(object sender, EventArgs e)//
        {
            DateTime ingreso = FechaSalida.SelectionStart;
            int idReserva = int.Parse(cbxReserva.SelectedValue.ToString());
            //int idMulta = int.Parse(cbxMulta.SelectedValue.ToString());
            string url = "http://127.0.0.1:8000/checkOut/crear/";
            var checkout = new HttpClient();
            var Ingreso = ingreso.ToString("yyyy/MM/dd");

            PostViewCheckOut post = new PostViewCheckOut()
            {
                FECHA_CHECK_OUT = Ingreso,
                OBSERVACION = txtObservacion.Text,
                RESERVA_ID_RESERVA = idReserva,
                MULTA_ID_MULTA = null,


            };
            //string ignored = JsonConvert.SerializeObject(post, Formatting.Indented,new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var data = JsonSerializer.Serialize<PostViewCheckOut>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await checkout.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewCheckIn>(result);

                MessageBox.Show("Salida Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al marcar la salida , intenta de nuevo" , "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            DateTime ingreso = FechaSalida.SelectionStart;
            int idReserva = int.Parse(cbxReserva.SelectedValue.ToString());
            //int idMulta = int.Parse(cbxMulta.SelectedValue.ToString());

            string url = "http://127.0.0.1:8000/checkOut/modificar/" + buscar;
            var checkout = new HttpClient();
            var Ingreso = ingreso.ToString("yyyy/MM/dd");

            PostViewCheckOut post = new PostViewCheckOut()
            {
                FECHA_CHECK_OUT = Ingreso,
                OBSERVACION = txtObservacion.Text,
                RESERVA_ID_RESERVA = idReserva,
                MULTA_ID_MULTA = null,

            };
            var data = JsonSerializer.Serialize<PostViewCheckOut>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await checkout.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewCheckIn>(result);

                MessageBox.Show("Modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Modificar la salida , intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = dgvCheckOut.CurrentRow.Cells[0].Value.ToString();
            FechaSalida.Text = dgvCheckOut.CurrentRow.Cells[1].Value.ToString();
            txtObservacion.Text = dgvCheckOut.CurrentRow.Cells[2].Value.ToString();
            cbxReserva.Text = dgvCheckOut.CurrentRow.Cells[3].Value.ToString();
            //cbxMulta.Text = dgvCheckOut.CurrentRow.Cells[4].Value.ToString();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/checkOut/eliminar/" + buscar;
            var checkin = new HttpClient();

            PostViewCheckOut post = new PostViewCheckOut()
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
                MessageBox.Show("Error al Eliminar la salida del cliente, intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var buscar = txtBuscar.Text;
                string respuesta = await GetHttp();
                List<PostViewCheckOut> lst = JsonConvert.DeserializeObject<List<PostViewCheckOut>>(respuesta);
                dgvCheckOut.DataSource = lst;

                async Task<string> GetHttp()
                {
                    string url = "http://127.0.0.1:8000/inventariOut" + buscar;
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();

                }
            }
            catch
            {
                MessageBox.Show("NO se encontraron id de check out", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewCheckOut> lst = JsonConvert.DeserializeObject<List<PostViewCheckOut>>(respuesta);
            dgvCheckOut.DataSource = lst;
        }
    }
}
