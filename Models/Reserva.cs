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
            //cargaDepartamento();
            cargaCliente();
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
            DateTime ingreso = FechaIngreso.SelectionStart;
            DateTime salida = FechaSalida.SelectionStart;
            DateTime modificacion = FechaEstado.SelectionStart;
            string url = "http://127.0.0.1:8000/reserva/crear";
            var reserva = new HttpClient();
            var Ingreso = ingreso.ToString("yyyy/MM/dd");
            var Salida = salida.ToString("yyyy/MM/dd");
            var Modificacion = modificacion.ToString("yyyy/MM/dd");
            PostViewReserva post = new PostViewReserva()
            {
                FECHA_INGRESO = Ingreso,
                FECHA_SALIDA = Salida,
                CANT_DIA_RESERVA = int.Parse(txtCantidadDias.Text),
                ESTADO_RESERVA = cbxEstadoReserva.Text,
                FECHA_ESTADO_RESERVA = Modificacion,
                DEPARTAMENTO_ID_DEPARTAMENTO = int.Parse(cbxDepartamento.Text),
                USUARIO_ID_USUARIO = int.Parse(cbxCliente.Text)


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
    }
}
