using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismo.Models;
using System.Collections;

namespace Turismo
{
    public partial class VentanaPrincipal : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public VentanaPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
            this.Padding = new Padding(borderSizeF);
            this.BackColor = Color.FromArgb(22, 31, 56);
          
        }   
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private int borderSizeF = 2;
        private Size formSizeF;
        private void Form1_Load(object sender, EventArgs e)
        {
            formSizeF = this.ClientSize;
        }
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
                    formSizeF = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSizeF;
            }
            base.WndProc(ref m);
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
      
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
      
        private void VentanaPrincipal_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSizeF)
                        this.Padding = new Padding(borderSizeF);
                    break;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSizeF = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSizeF;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.PrincipalMenu.Width > 200) //Collapse menu
            {
                PrincipalMenu.Width = 100;
                pictureBox12.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in PrincipalMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                PrincipalMenu.Width = 230;
                pictureBox12.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in PrincipalMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
       
        private void hideSubMenu()
        {
            PanelSubMenuDepa.Visible = false;
            PanelSubMenuCliente.Visible = false;
            PanelSubMenuTransporte.Visible = false;
            PanelSubMenuPagos.Visible = false;
            PanelSubMenuServicios.Visible = false;
            PanelSubMenuInformes.Visible = false;
            PanelSubMenuReserva.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuDepa);
            
        }
     
        private void iconButton10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form AbrirForms = null;
        private void AbrirSubFormulario(Form subform)
        {
            if (AbrirForms != null)
            {
                AbrirForms.Close();
            }
            AbrirForms = subform;
            subform.TopLevel = false;
            subform.Dock = DockStyle.Fill;
            subform.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(subform);
            panel2.Tag = subform;
            subform.BringToFront();
            subform.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
        
            AbrirSubFormulario(new Mantendor_depto());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirSubFormulario(new Mantenimiento());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //openChildFormInPanel(new AgregarDepto());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuCliente);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirSubFormulario(new MantenedorInventario());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirSubFormulario(new MantenedorUsuario());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirSubFormulario(new ListadoDepartamento());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirSubFormulario(new MantenedorCliente());
        }


        
        private void iconButton4_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuTransporte);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuPagos);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuServicios);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuInformes);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AbrirSubFormulario(new ReporteDepartamento());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirSubFormulario(new ListarUsuario());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AbrirSubFormulario(new Reserva());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AbrirSubFormulario(new ListarReserva());

        }

        private void button18_Click(object sender, EventArgs e)
        {
            AbrirSubFormulario(new Reserva());
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            AbrirSubFormulario(new ListarReserva());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuReserva);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            AbrirSubFormulario(new Menu_Checkeo());
        }

        private void fechahora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }      

    }
}
