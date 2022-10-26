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
    public partial class ListarReserva : Form
    {
        public ListarReserva()
        {
            InitializeComponent();
        }

        private async void ListarReserva_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewListarReserva> lst = JsonConvert.DeserializeObject<List<PostViewListarReserva>>(respuesta);
            dgvReserva.DataSource = lst;
        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/reserva/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }
    }
}
