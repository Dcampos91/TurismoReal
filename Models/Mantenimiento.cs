using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Runtime.InteropServices;
using iText.Kernel.Geom;
using System.Globalization;
using System.Data.OracleClient;
using Point = System.Drawing.Point;

namespace Turismo.Models
{
    public partial class Mantenimiento : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public Mantenimiento()
        {
            InitializeComponent();
            cargaDepartamento();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private int borderSize = 2;
        private Size formSize;
        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }
        private int borderSizef = 2;
        private Size formSizeF;
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
        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();//cierra la pantalla para pasar a la siguiente
            //VentanaPrincipal v1 = new VentanaPrincipal();//llama al siguiente formulario
            //v1.Show();
        }

        private async void Mantenimiento_Load(object sender, EventArgs e)
        {
            try 
            {
                string respuesta = await GetHttp();
                List<PostViewMTTO> lst = JsonConvert.DeserializeObject<List<PostViewMTTO>>(respuesta);
                dgvMTTO.DataSource = lst;
            }
            catch
            {
                MessageBox.Show("NO se encontraron mantenimientos", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public async Task<string> GetHttp()
        {
            string url = "http://127.0.0.1:8000/mttoDepartamento/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async void btnAgregarMTTO_Click(object sender, EventArgs e)
        {
            DateTime ingreso = FechaIngreso.SelectionStart;
            DateTime salida = FechaSalida.SelectionStart;
            
            string url = "http://127.0.0.1:8000/mttoDepartamento/crear/";
            var reserva = new HttpClient();
            var Ingreso = ingreso.ToString("yyyy/MM/dd");
            var Salida = salida.ToString("yyyy/MM/dd");
   
           
            int idDepartamento = int.Parse(cbxDepartamento.SelectedValue.ToString());

            PostViewMTTO post = new PostViewMTTO()
            {
                FECHA_INGRESO = Ingreso,
                FECHA_SALIDA = Salida,
                DESCRIPCION_MTTO = txtDescripcionMtto.Text,
                DISPONIBILIDAD = cbxDisponibilidad.Text,
                DEPARTAMENTO_ID_DEPARTAMENTO = idDepartamento,

            };
            var data = JsonSerializer.Serialize<PostViewMTTO>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await reserva.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewMTTO>(result);

                MessageBox.Show("Creado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Modificar la orden de MTTO, intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            fila["nom_depto"] = "Nombre";
            dt.Rows.InsertAt(fila, 0);

            cbxDepartamento.ValueMember = "id_departamento";
            cbxDepartamento.DisplayMember = "nom_depto";
            cbxDepartamento.DataSource = dt;
            ora.Close();
        }

        private async void btnModificarMtto_Click(object sender, EventArgs e)
        {
            try 
            {
                var buscar = txtBuscar.Text;
                DateTime ingreso = FechaIngreso.SelectionStart;
                DateTime salida = FechaSalida.SelectionStart;

                string url = "http://127.0.0.1:8000/mttoDepartamento/modificar/" + buscar;
                var reserva = new HttpClient();
                var Ingreso = ingreso.ToString("yyyy/MM/dd");
                var Salida = salida.ToString("yyyy/MM/dd");


                int idDepartamento = int.Parse(cbxDepartamento.SelectedValue.ToString());

                PostViewMTTO post = new PostViewMTTO()
                {
                    FECHA_INGRESO = Ingreso,
                    FECHA_SALIDA = Salida,
                    DESCRIPCION_MTTO = txtDescripcionMtto.Text,
                    DISPONIBILIDAD = cbxDisponibilidad.Text,
                    DEPARTAMENTO_ID_DEPARTAMENTO = idDepartamento,

                };
                var data = JsonSerializer.Serialize<PostViewMTTO>(post);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                var httpResponse = await reserva.PostAsync(url, content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    var postResult = JsonSerializer.Deserialize<PostViewMTTO>(result);

                    MessageBox.Show("Modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Modificar la orden de MTTO, intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("NO se puede modificar", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dgvMTTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = dgvMTTO.CurrentRow.Cells[0].Value.ToString();
            FechaIngreso.Text = dgvMTTO.CurrentRow.Cells[1].Value.ToString();
            FechaSalida.Text = dgvMTTO.CurrentRow.Cells[2].Value.ToString();
            txtDescripcionMtto.Text = dgvMTTO.CurrentRow.Cells[3].Value.ToString();
            cbxDisponibilidad.Text = dgvMTTO.CurrentRow.Cells[4].Value.ToString();
            cbxDepartamento.Text = dgvMTTO.CurrentRow.Cells[5].Value.ToString();

        }

        private async void btnEliminarMtto_Click(object sender, EventArgs e)
        {
            var buscar = txtBuscar.Text;
            string url = "http://127.0.0.1:8000/mttoDepartamento/eliminar/" + buscar;
            var depto = new HttpClient();

            PostViewMTTO post = new PostViewMTTO()
            {

            };

            var httpResponse = await depto.DeleteAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();


                MessageBox.Show("Eliminado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Eliminar la Orden de Matenimiento, intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try 
            {
                var buscar = txtBuscar.Text;
                string respuesta = await GetHttp();
                List<PostViewMTTO> lst = JsonConvert.DeserializeObject<List<PostViewMTTO>>(respuesta);
                dgvMTTO.DataSource = lst;

                async Task<string> GetHttp()
                {
                    string url = "http://127.0.0.1:8000/mttoDepartamento/" + buscar;
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();

                }
            }
            catch
            {
                MessageBox.Show("NO se encontraron id de mantenimiento", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       

        private async void btnActualizar_Click_1(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostViewMTTO> lst = JsonConvert.DeserializeObject<List<PostViewMTTO>>(respuesta);
            dgvMTTO.DataSource = lst;

        }
        ErrorProvider errorP = new ErrorProvider();
        private void txtDescripcionMtto_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtDescripcionMtto))
                errorP.SetError(txtDescripcionMtto, "No puede dejar vacio");
            else
                errorP.Clear();
        }
    }
}
