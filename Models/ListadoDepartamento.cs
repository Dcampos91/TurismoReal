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
            try 
            {
                string respuesta = await GetHttp();
                List<PostViewListarDepartamento> lst = JsonConvert.DeserializeObject<List<PostViewListarDepartamento>>(respuesta);
                dgvListarDepartamento.DataSource = lst;
            }
            catch
            {
                MessageBox.Show("NO se encontraron departamentos", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                      
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
            try 
            {
                //var buscar = txtBuscar.Text;
                string respuesta = await GetHttp();
                List<PostViewDepartamento> lst = JsonConvert.DeserializeObject<List<PostViewDepartamento>>(respuesta);
                dgvListarDepartamento.DataSource = lst;

                async Task<string> GetHttp()
                {
                    string url = "http://127.0.0.1:8000/departamento/";
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();
                }
            }
            catch
            {
                MessageBox.Show("No se encontraron departamentos con ese ID", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
