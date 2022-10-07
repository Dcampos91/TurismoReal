using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;



namespace Turismo
{
    public partial class Mantendor_depto : Form
    {
        
        //OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal; Password=oracle");
        public Mantendor_depto()
        {
            InitializeComponent();
        }

           
        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            AgregarDepto form2 = new AgregarDepto();
            form2.Show();
        }

        private async void Mantendor_depto_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewDepartamento> lst = JsonConvert.DeserializeObject<List<PostViewDepartamento>>(respuesta);
            dgvDepartamento.DataSource = lst;
        }

        public async Task<string> GetHttp() 
        {
            string url = "http://127.0.0.1:8000/departamento/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            VentanaPrincipal v1 = new VentanaPrincipal();//llama al siguiente formulario
            v1.Show();
        }
    }
}
