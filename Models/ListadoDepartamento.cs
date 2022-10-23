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

namespace Turismo.Models
{
    public partial class ListadoDepartamento : Form
    {
        public ListadoDepartamento()
        {
            InitializeComponent();
        }

        private  async void ListadoDepartamento_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewListarDepartamento> lst = JsonConvert.DeserializeObject<List<PostViewListarDepartamento>>(respuesta);
            dgvListarDepartamento.DataSource = lst;
                      
        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/departamentoAdmin/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            string respuesta = await GetHttp();
            List<PostViewUsuario> lst = JsonConvert.DeserializeObject<List<PostViewUsuario>>(respuesta);
            dgvListarDepartamento.DataSource = lst;

            async Task<string> GetHttp()
            {
                string url = "http://127.0.0.1:8000/departamento/buscar/" + buscar;
                WebRequest oRequest = WebRequest.Create(url);
                WebResponse oResponse = oRequest.GetResponse();
                StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                return await sr.ReadToEndAsync();

            }
        }
    }
}
