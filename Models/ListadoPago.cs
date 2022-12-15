using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismo.Models
{
    public partial class ListadoPago : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public ListadoPago()
        {
            InitializeComponent();
        }

        private void ListadoPago_Load(object sender, EventArgs e)
        {
            string con = "select oc.id_orden_compra as \"NUMERO DE ORDEN\" ,oc.fecha_orden_compra, oc.total_compra, tp.tipo_pago from orden_compra oc, tipo_pago tp, pago p \r\nwhere oc.pago_id_pago = p.id_pago and p.tipo_pago_id_tipo_pago = tp.id_tipo_pago";
            OracleDataAdapter adaptador = new OracleDataAdapter(con,ora);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
