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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//cierra la pantalla para pasar a la siguiente
            VentanaPrincipal v1 = new VentanaPrincipal();//llama al siguiente formulario
            v1.Show();
        }
    }
}
