using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismo.Models
{
    public partial class CheckList : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public CheckList()
        {
            InitializeComponent();
            cargaDepartamento();
        }

        private void CheckList_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbxItem.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un item!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe seleccionar una cantidad!");
            else if (cbxDepartamento.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un departamento!");
            else 
            {
                string item = cbxItem.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string depa = cbxDepartamento.Text;

                ListViewItem fila = new ListViewItem(item);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(depa.ToString());
                lvLista.Items.Add(fila);
                btnCancelar_Click(sender, e);
            }

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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
            //fila["nom_depto"] = "Nombre";
            //dt.Rows.InsertAt(fila, 0);

            cbxDepartamento.ValueMember = "nom_depto";
            cbxDepartamento.DisplayMember = "nom_depto";
            cbxDepartamento.DataSource = dt;
            ora.Close();
        }

        private void Imprimir(object sender,PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int ancho = 200;
            int y = 20;

            e.Graphics.DrawString("-- Listado de Item --", font, Brushes.Black, new RectangleF(0, y + 20, ancho, 20));
            
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();

        }
    }
}
