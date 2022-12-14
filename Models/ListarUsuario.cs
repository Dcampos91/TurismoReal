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
    public partial class ListarUsuario : Form
    {
        public ListarUsuario()
        {
            InitializeComponent();
        }

        private void dgvListarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ListarUsuario_Load(object sender, EventArgs e)
        {
            try 
            {
                string respuesta = await GetHttp();
                List<PostViewListarUsuario> lst = JsonConvert.DeserializeObject<List<PostViewListarUsuario>>(respuesta);
                dgvListarUsuario.DataSource = lst;
            }
            catch
            {
                MessageBox.Show("NO se encontraron usuario", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/usuarioAdmin/";
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
                List<PostViewListarUsuario> lst = JsonConvert.DeserializeObject<List<PostViewListarUsuario>>(respuesta);
                dgvListarUsuario.DataSource = lst;

                async Task<string> GetHttp()
                {
                    string url = "http://127.0.0.1:8000/usuariocorreo/" ;
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();

                }
            }
            catch
            {
                MessageBox.Show("NO se encontraron usuario", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewUsuario> lst = JsonConvert.DeserializeObject<List<PostViewUsuario>>(respuesta);
            dgvListarUsuario.DataSource = lst;
        }
    }
}
