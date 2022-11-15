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
//using Turismo.Models.Request;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Runtime.InteropServices;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.Kernel.Pdf.Canvas.Wmf;


namespace Turismo.Models
{
    public partial class MantenedorCliente : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public MantenedorCliente()
        {
            InitializeComponent();
            cargaUsuario();
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
        private int borderSize = 2;
        private Size formSize;
        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
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
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
              

        public async Task<string> GetHttp() // cargar los clientes en el datagrid
        {
         
                string url = "http://127.0.0.1:8000/listarCliente/";
                WebRequest oRequest = WebRequest.Create(url);
                WebResponse oResponse = oRequest.GetResponse();
                StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                return await sr.ReadToEndAsync();  

            
        }

        private async void MantenedorCliente_Load_1(object sender, EventArgs e)// cargar los clientes en el datagrid
        {
            string respuesta = await GetHttp();
            List<PostViewCliente> lst = JsonConvert.DeserializeObject<List<PostViewCliente>>(respuesta);
            dgvCliente.DataSource = lst;
            

        }

        private async void btnGuardarCliente_Click(object sender, EventArgs e)//agregar cliente
        {
            string rut = txtRutCliente.Text;
            bool respuesta = validarRut(rut);

            if (validarRut(txtRutCliente.Text) == false)
            {
                lblrut.Text = "RUT INVALIDO";
                lblrut.ForeColor = Color.Red;
            }
            else
            {
                lblrut.Text = "RUT VALIDO";
                lblrut.ForeColor = Color.Green;
            }

            int idUsuario = int.Parse(cbxUsuario.SelectedValue.ToString());
            string url = "http://127.0.0.1:8000/cliente/crear/";
            var cliente = new HttpClient();

            PostViewCliente post = new PostViewCliente()
            {
                RUT_CLIENTE = rut,
                NOM_CLIENTE = txtNombreCliente.Text,
                APELLIDO_PATERNO = txtApellidoPaterno.Text,
                APELLIDO_MATERNO = txtApellidoMaterno.Text,
                EDAD = int.Parse(txtEdad.Text),
                NACIONALIDAD = cbxNacionalidad.Text,
                GENERO = cbxGenero.Text,
                DIRECCION_CLIENTE = txtDireccion.Text,
                TELEFONO = int.Parse(txtTelefono.Text),
                EMAIL = txtDireccion.Text,
                USUARIO_ID_USUARIO = idUsuario,

            };
            var data = JsonSerializer.Serialize<PostViewCliente>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await cliente.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewCliente>(result);

                MessageBox.Show("Creado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear el cliente intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnBuscarCliente_Click(object sender, EventArgs e)// Buscar cliente por ID
        {
            var buscar = txtBuscarCliente.Text;
            string respuesta = await GetHttp();
            List<PostViewCliente> lst = JsonConvert.DeserializeObject<List<PostViewCliente>>(respuesta);
            dgvCliente.DataSource = lst;

            async Task<string> GetHttp()
            {
                string url = "http://127.0.0.1:8000/cliente/"+buscar;
                WebRequest oRequest = WebRequest.Create(url);
                WebResponse oResponse = oRequest.GetResponse();
                StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                return await sr.ReadToEndAsync();

            }
        }

        private async void btnEliminarCliente_Click(object sender, EventArgs e)// Eliminar cliente
        {
            var buscar = txtBuscarCliente.Text;
            string url = "http://127.0.0.1:8000/cliente/eliminar/" + buscar;
            var depto = new HttpClient();

            PostViewCliente post = new PostViewCliente()
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
                MessageBox.Show("Error al Eliminar el cliente intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)//autorellenar el datagrid
        {
            txtBuscarCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtRutCliente.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtNombreCliente.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtApellidoPaterno.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtApellidoMaterno.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtEdad.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            cbxNacionalidad.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            cbxGenero.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells[9].Value.ToString();
            txtCorreo.Text = dgvCliente.CurrentRow.Cells[10].Value.ToString();
            cbxUsuario.Text = dgvCliente.CurrentRow.Cells[11].Value.ToString();
            
        }

        private async void btnActualizar_Click(object sender, EventArgs e)//Actualizar el datagrid
        {
            string respuesta = await GetHttp();
            List<PostViewCliente> lst = JsonConvert.DeserializeObject<List<PostViewCliente>>(respuesta);
            dgvCliente.DataSource = lst;

        }
        private void cargaUsuario()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("select id_usuario,nom_usuario,tipo_usuario_id_tipo_usuario from usuario  WHERE tipo_usuario_id_tipo_usuario = 3 ORDER BY id_usuario ASC", ora);
            OracleDataAdapter data = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            ora.Close();

            DataRow fila = dt.NewRow();
            fila["nom_usuario"] = "Nombre";
            dt.Rows.InsertAt(fila, 0);

            cbxUsuario.ValueMember = "id_usuario";
            cbxUsuario.DisplayMember = "nom_usuario";
            cbxUsuario.DataSource = dt;
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(cbxUsuario.SelectedValue.ToString());
            var buscar = txtBuscarCliente.Text;
            string url = "http://127.0.0.1:8000/cliente/modificar/"+buscar;
            var cliente = new HttpClient();

            PostViewCliente post = new PostViewCliente()
            {
                RUT_CLIENTE = txtRutCliente.Text,
                NOM_CLIENTE = txtNombreCliente.Text,
                APELLIDO_PATERNO = txtApellidoPaterno.Text,
                APELLIDO_MATERNO = txtApellidoMaterno.Text,
                EDAD = int.Parse(txtEdad.Text),
                NACIONALIDAD = cbxNacionalidad.Text,
                GENERO = cbxGenero.Text,
                DIRECCION_CLIENTE = txtDireccion.Text,
                TELEFONO = int.Parse(txtTelefono.Text),
                EMAIL = txtDireccion.Text,
                USUARIO_ID_USUARIO = idUsuario,

            };
            var data = JsonSerializer.Serialize<PostViewCliente>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await cliente.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<PostViewCliente>(result);

                MessageBox.Show("Modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al modificar el cliente intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }

            }
            catch (Exception)
            {
            }
            return validacion;

        }

    }
}
