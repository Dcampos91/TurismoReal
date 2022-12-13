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
using System.Windows.Media;
using Brushes = System.Drawing.Brushes;

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

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvList);
                fila.Cells[0].Value = (depa.ToString());
                fila.Cells[1].Value = (item.ToString());
                fila.Cells[2].Value = (cantidad.ToString());
                dgvList.Rows.Add(fila);
                cbxItem.Text = "";
                txtCantidad.Text = "";                
               
            }

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Remove(dgvList.CurrentRow);

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
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int ancho = 200;
            int y = 20;
            //int altura = 50;
            e.Graphics.DrawString("-- Listado de Item --", font, Brushes.Black, new RectangleF(0,10,120,20));
            //e.Graphics.DrawString(lvLista.ToString(), font, Brushes.Black, new RectangleF(0, 10, 120, 20));

            
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Show();
            //printDocument1  = new PrintDocument();
            //PrinterSettings ps = new PrinterSettings();
            //printDocument1.PrinterSettings = ps;
            //printDocument1.PrintPage += Imprimir;
            //printDocument1.Print();  

            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc};
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in dgvList.Columns) 
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width;

                    if (col.Index < dgvList.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvList.RowCount - 1) * DGV_ALTO);

                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    if (row.Index == dgvList.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells) 
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe Ui", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top,ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();

        }

       

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
