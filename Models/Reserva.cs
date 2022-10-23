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

namespace Turismo.Models
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private async void Reserva_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewReserva> lst = JsonConvert.DeserializeObject<List<PostViewReserva>>(respuesta);
            dgvReserva.DataSource = lst;
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
            string url = "http://127.0.0.1:8000/reserva/crear";
            var reserva = new HttpClient();

            PostViewReserva post = new PostViewReserva()
            {
                FECHA_INGRESO = FechaIngreso.MaxDate,
                FECHA_SALIDA = FechaSalida.MaxDate,
                CANT_DIA_RESERVA = int.Parse(txtCantidadDias.Text),
                ESTADO_RESERVA = cbxEstadoReserva.Text,
                FECHA_ESTADO_RESERVA = FechaEstado.MaxDate,
                DEPARTAMENTO_ID_DEPARTAMENTO = int.Parse(cbxDepartamento.Text),
                USUARIO_ID_USUAIRO = int.Parse(cbxUsuario.Text)


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
    }
}
