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

namespace Turismo
{
    public partial class Mantendor_depto : Form
    {
        
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");

        public Mantendor_depto()
        {
            InitializeComponent();
            cargaComuna();

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
        }//parte del diseño

        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)//auto rellenado de los textbox y combobox
        {
            txtBuscarDepto.Text = dgvDepartamento.CurrentRow.Cells[0].Value.ToString();
            txtNomdepto.Text = dgvDepartamento.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = dgvDepartamento.CurrentRow.Cells[2].Value.ToString();
            txtdireccion.Text = dgvDepartamento.CurrentRow.Cells[3].Value.ToString();            
            cbxHabitacion.Text = dgvDepartamento.CurrentRow.Cells[4].Value.ToString();
            cbxBanio.Text = dgvDepartamento.CurrentRow.Cells[5].Value.ToString();
            cbxCalefaccion.Text = dgvDepartamento.CurrentRow.Cells[6].Value.ToString();
            cbxInternet.Text = dgvDepartamento.CurrentRow.Cells[7].Value.ToString();
            cbxAmoblado.Text = dgvDepartamento.CurrentRow.Cells[8].Value.ToString();   
            cbxTelevision.Text = dgvDepartamento.CurrentRow.Cells[9].Value.ToString();
            cbxDisponibilidad.Text = dgvDepartamento.CurrentRow.Cells[10].Value.ToString();
            txtValor.Text = dgvDepartamento.CurrentRow.Cells[11].Value.ToString();
            cbxComuna.Text = dgvDepartamento.CurrentRow.Cells[12].Value.ToString();

        }

        private async void button2_Click(object sender, EventArgs e)//agregar un departamento
        {
            try 
            {
                string url = "http://127.0.0.1:8000/departamento/crear/";
                var depto = new HttpClient();
                int idComuna = int.Parse(cbxComuna.SelectedValue.ToString());

                PostViewDepartamento post = new PostViewDepartamento()
                {

                    NOM_DEPTO = txtNomdepto.Text,
                    DESC_DEPTO = txtDesc.Text,
                    DIRECCION = txtdireccion.Text,
                    CANT_HABITACION = int.Parse(cbxHabitacion.Text),
                    CANT_BANIO = int.Parse(cbxBanio.Text),
                    CALEFACCION = cbxCalefaccion.Text,
                    INTERNET = cbxInternet.Text,
                    AMOBLADO = cbxAmoblado.Text,
                    TELEVISION = cbxTelevision.Text,
                    DISPONIBLE = cbxDisponibilidad.Text,
                    VALOR_DIA = int.Parse(txtValor.Text),
                    COMUNA_ID_COMUNA = idComuna,
                };
                var data = JsonSerializer.Serialize<PostViewDepartamento>(post);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                var httpResponse = await depto.PostAsync(url, content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    var postResult = JsonSerializer.Deserialize<PostViewDepartamento>(result);

                    MessageBox.Show("Creado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Error al crear departamento intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("NO se agrego Departamentos", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void Mantendor_depto_Load(object sender, EventArgs e)// carga el datagrid
        {
            try
            {
                string respuesta = await GetHttp();
                List<PostViewDepartamento> lst = JsonConvert.DeserializeObject<List<PostViewDepartamento>>(respuesta);
                dgvDepartamento.DataSource = lst;
            }
            catch 
            {
                MessageBox.Show("NO se encontraron departamentos", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/departamento/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private async void btnBuscar_Click(object sender, EventArgs e)//busca un departamento por su ID
        {
            try 
            {
                var buscar = txtBuscarDepto.Text;
                string respuesta = await GetHttp();
                List<PostViewDepartamento> lst = JsonConvert.DeserializeObject<List<PostViewDepartamento>>(respuesta);
                dgvDepartamento.DataSource = lst;

                async Task<string> GetHttp()
                {
                    string url = "http://127.0.0.1:8000/departamento/" + buscar;
                    WebRequest oRequest = WebRequest.Create(url);
                    WebResponse oResponse = oRequest.GetResponse();
                    StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                    return await sr.ReadToEndAsync();

                }

            }
            catch 
            {
                MessageBox.Show("NO se encontraron departamento solicitado", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void btnEliminarDepto_Click(object sender, EventArgs e)//elimina un departamento
        {
            var buscar = txtBuscarDepto.Text;
            string url = "http://127.0.0.1:8000/departamento/eliminar/"+buscar;
            var depto = new HttpClient();

            PostViewDepartamento post = new PostViewDepartamento()
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
                MessageBox.Show("Error al Eliminar el departamento intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void btnActualizar_Click(object sender, EventArgs e) //actualizar el data grid
        {
            try 
            {
                string respuesta = await GetHttp();
                List<PostViewDepartamento> lst = JsonConvert.DeserializeObject<List<PostViewDepartamento>>(respuesta);
                dgvDepartamento.DataSource = lst;
            }
            catch
            {
                MessageBox.Show("NO se encontraron Departamentos", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private async void btnActualizarDepto_Click(object sender, EventArgs e)
        {
            try 
            {
                var buscar = txtBuscarDepto.Text;
                string url = "http://127.0.0.1:8000/departamento/modificar/" + buscar;
                var depto = new HttpClient();
                int idComuna = int.Parse(cbxComuna.SelectedValue.ToString());

                PostViewDepartamento post = new PostViewDepartamento()
                {
                    NOM_DEPTO = txtNomdepto.Text,
                    DESC_DEPTO = txtDesc.Text,
                    DIRECCION = txtdireccion.Text,
                    CANT_HABITACION = int.Parse(cbxHabitacion.Text),
                    CANT_BANIO = int.Parse(cbxBanio.Text),
                    CALEFACCION = cbxCalefaccion.Text,
                    INTERNET = cbxInternet.Text,
                    AMOBLADO = cbxAmoblado.Text,
                    TELEVISION = cbxTelevision.Text,
                    DISPONIBLE = cbxDisponibilidad.Text,
                    VALOR_DIA = int.Parse(txtValor.Text),
                    COMUNA_ID_COMUNA = idComuna,
                };
                var data = JsonSerializer.Serialize<PostViewDepartamento>(post);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                var httpResponse = await depto.PostAsync(url, content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    var postResult = JsonSerializer.Deserialize<PostViewDepartamento>(result);

                    MessageBox.Show("Modificado Correctamente", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al modificar el departamento intenta de nuevo", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("NO se encontraron Departamentos", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void cargaComuna() 
        {
            
            ora.Open();
            OracleCommand comando = new OracleCommand("SELECT id_comuna,nom_comuna FROM comuna ORDER BY nom_comuna ASC", ora);
            OracleDataAdapter data = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            ora.Close();

            DataRow fila = dt.NewRow();
            fila["nom_comuna"] = "Seleccionar Comuna";
            dt.Rows.InsertAt(fila,0);

            cbxComuna.ValueMember = "id_comuna";
            cbxComuna.DisplayMember = "nom_comuna";
            cbxComuna.DataSource = dt;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        ErrorProvider errorP = new ErrorProvider();
        private void txtNomdepto_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtNomdepto))
                errorP.SetError(txtNomdepto, "No puede dejar vacio");
            else
                errorP.Clear();
        }

        private void txtdireccion_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtdireccion))
                errorP.SetError(txtdireccion, "No puede dejar vacio");
            else
                errorP.Clear();

        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.textVacio(txtDesc))
                errorP.SetError(txtDesc, "No puede dejar vacio");
            else
                errorP.Clear();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtValor, "Solo números");
            else
                errorP.Clear();
        }
    }
}
