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

namespace Turismo
{
    public partial class AgregarDepto : Form
    {
        public AgregarDepto()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            Mantendor_depto v2 = new Mantendor_depto();//llama al siguiente formulario
            v2.Show();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:8000/departamento/crear/";
            var depto = new HttpClient();

            PostViewDepartamento post = new PostViewDepartamento()
            {
                NOM_DEPTO = txtNomdepto.Text,
                DESC_DEPTO = txtDesc.Text,
                DIRECCION = txtdireccion.Text,
                CANT_HABITACION = int.Parse(cbxHabitacion.Text),
                CANT_BANIO = int.Parse(cbxBanio.Text),
                CALEFACCION = cbxCalefaccion.Text,
                INTERNET = cbxInternet.Text,
                AMOBLADO = cbxAmoblado.Text,
                TELEVISION = cbxTelevision.Text,
                DISPONIBLE = cbxDisponibilidad.Text,
                VALOR_DIA = int.Parse(txtValor.Text),
                COMUNA_ID_COMUNA = int.Parse(txtIDcomuna.Text),
            };
            var data = JsonSerializer.Serialize<PostViewDepartamento>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await depto.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewDepartamento>(result);

                MessageBox.Show("Creado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            

            
        }

       

      
    }
}

