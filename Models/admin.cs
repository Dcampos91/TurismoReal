using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismo.Models
{
    public partial class admin : Form
    {
        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion



        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        OracleCommand cmd;
        OracleDataReader dr;
        public admin()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        

        private void admin_Load(object sender, EventArgs e)
        {
            GrafDepartamento();
            ClienteFrecuente();
            MaxId();
            Check();


        }
        ArrayList Departamentos = new ArrayList();
        ArrayList Reserva = new ArrayList();
        ArrayList Nombre_cliente = new ArrayList();
        ArrayList Reservas = new ArrayList();
        private object oracleType;

        private void GrafDepartamento()
        {


            cmd = new OracleCommand("select d.NOM_DEPTO, count(*) as RESERVA from reserva r, departamento d where r.departamento_id_departamento = d.id_departamento group by d.NOM_DEPTO order by RESERVA desc", ora);


            ora.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Departamentos.Add(dr.GetString(0));
                Reserva.Add(dr.GetInt32(1));
            }
            chartDepartamento.Series[0].Points.DataBindXY(Departamentos, Reserva);
            dr.Close();
            ora.Close();

        }
        private void ClienteFrecuente()
        {

            cmd = new OracleCommand("select c.NOM_CLIENTE ||' '|| c.APELLIDO_PATERNO ||' '|| c.APELLIDO_MATERNO as \"NOMBRE CLIENTE\", count(*) as RESERVA from reserva r, cliente c \r\nwhere r.usuario_id_usuario = c.usuario_id_usuario group by c.NOM_CLIENTE, c.APELLIDO_PATERNO, c.APELLIDO_MATERNO order by RESERVA desc", ora);


            ora.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre_cliente.Add(dr.GetString(0));
                Reservas.Add(dr.GetInt32(1));
            }
            ChartCliente.Series[0].Points.DataBindXY(Nombre_cliente, Reservas);
            dr.Close();
            ora.Close();

        }
        private void MaxId()
        {
            cmd = new OracleCommand("SELECT COUNT(*) \"Total Reservas\" FROM reserva", ora);            
            {
                ora.Open();
                string codmax = Convert.ToString(cmd.ExecuteScalar());
                int cod = Convert.ToInt32(codmax);
                textBox1.Text = Convert.ToString(cod);
                ora.Close();
            }
        }

        private void Check()
        {
            cmd = new OracleCommand("SELECT COUNT(*) \"Total Check out\" FROM check_out", ora);
            {
                ora.Open();
                string codmax = Convert.ToString(cmd.ExecuteScalar());
                int cod = Convert.ToInt32(codmax);
                textBox2.Text = Convert.ToString(cod);
                ora.Close();
            }
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            D.Controls.Add(childForm);
            D.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        


        private int borderSize = 2;
        private Size formSize;
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
























        private void deptoMantencion_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Mantenimiento());
        }

        private void deptoInventario_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MantenedorInventario());
        }

        private void deptoAdm_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Mantendor_depto());
        }

        private void deptoListar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ListadoDepartamento());
        }

        private void deptoCheck_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Menu_Checkeo());
        }

        private void clienteUsers_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MantenedorUsuario());
        }

        private void clientesListar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ListarUsuario());
        }

        private void clientesAdmCliente_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MantenedorCliente());
        }

        private void servTransporte_Click(object sender, EventArgs e)
        {

        }

        private void servExtra_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ServicioExtra());
        }

        private void servReportes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReporteDepartamento());
        }

        private void servReserva_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Reserva());
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //openChildFormInPanel(new Login());
        }


        

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void chartDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fechahora_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }

        private void chartDepartamento_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ListarReserva());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ListadoDepartamento());
            
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ListarUsuario());
            
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Reserva());
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void admin_MouseDown(object sender, MouseEventArgs e)
        {
            //para poder arrastrar el formulario sin bordes

            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }
    }

}
