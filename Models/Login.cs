using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeccion_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            VentanaPrincipal v1 = new VentanaPrincipal();//llama al siguiente formulario
            v1.Show();
        }
    }
}
