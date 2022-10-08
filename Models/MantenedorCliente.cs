using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismo;


namespace Turismo.Models
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            AgregarCliente v3 = new AgregarCliente();
            v3.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            VentanaPrincipal v1 = new VentanaPrincipal();//llama al siguiente formulario
            v1.Show();
        }
       

        public async Task<string> GetHttp()
        {
            string url = "http://127.0.0.1:8000/cliente/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async void MantenedorCliente_Load_1(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewCliente> lst = JsonConvert.DeserializeObject<List<PostViewCliente>>(respuesta);
            dgvCliente.DataSource = lst;

        }
    }
}
