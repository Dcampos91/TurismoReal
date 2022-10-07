using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismo.Models
{
    public partial class IngresarProducto : Form
    {
        public IngresarProducto()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            IngresarInventario v1 = new IngresarInventario();//llama al siguiente formulario
            v1.Show();
        }
    }
}
