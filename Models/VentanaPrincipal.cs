using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismo.Models;

namespace Turismo
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminDepto_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            Mantendor_depto v2 = new Mantendor_depto();//llama al siguiente formulario
            v2.Show();
        }

        private void btnAdminCliente_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            MantenedorCliente v3 = new MantenedorCliente();//llama al siguiente formulario
            v3.Show();
        }

        private void btnManteDepartamento_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            Mantenimiento v5 = new Mantenimiento();//llama al siguiente formulario
            v5.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            IngresarInventario v6 = new IngresarInventario();//llama al siguiente formulario
            v6.Show();
        }
    }
}
