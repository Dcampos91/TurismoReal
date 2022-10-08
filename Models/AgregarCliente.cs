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
namespace Turismo.Models
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            VentanaPrincipal v1 = new VentanaPrincipal();//llama al siguiente formulario
            v1.Show();
        }

        private async void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:8000/cliente/crear/";
            var cliente = new HttpClient();

            PostViewCliente post = new PostViewCliente()
            {
                RUT_CLIENTE = txtRutCliente.Text,
                NOM_CLIENTE = txtNombreCliente.Text,
                APELLIDO_PATERNO = txtApellidoPaterno.Text,
                APELLIDO_MATERMO = txtApellidoPaterno.Text,
                EDAD = int.Parse(txtEdad.Text),
                NACIONALIDAD = txtNacionalidad.Text,
                GENERO = txtGenero.Text,
                DIRECCION_CLIENTE = txtDireccion.Text,
                TELEFONO = int.Parse(txtTelefono.Text),
                EMAIL = txtCorreo.Text,
                USUARIO_ID_USUARIO = int.Parse(txtTipoCliente.Text),
               
            };
            var data = JsonSerializer.Serialize<PostViewCliente>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await cliente.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewDepartamento>(result);
            }


        }
    }
}
