using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismo.Models
{
    public partial class ListarReserva : Form
    {
        OracleConnection ora = new OracleConnection("Data Source=orcl; User ID=C##TReal1; Password=oracle");
        public ListarReserva()
        {
            InitializeComponent();
        }

        private async void ListarReserva_Load(object sender, EventArgs e)
        {
            try 
            {
                string respuesta = await GetHttp();
                List<PostViewListarReserva> lst = JsonConvert.DeserializeObject<List<PostViewListarReserva>>(respuesta);
                dgvReserva.DataSource = lst;
            }
            catch
            {
                MessageBox.Show("NO se encontraron reservas", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public async Task<string> GetHttp() //cargar el datagrid
        {
            string url = "http://127.0.0.1:8000/reserva/";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private void CrearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter(@"C:\Users\Diego\Desktop\Reporte\Reporte1.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(75, 17, 55, 17);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Fecha ingreso", "Fecha salida", "Cantidad de dias reservados", "Estado Reserva", "Nombre Departamento", "Nombre Usuario" };

            float[] tamanios = { 4, 4, 4, 4, 4, 4 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }
            ora.Open();
            OracleCommand comando = new OracleCommand("select r.fecha_ingreso, r.fecha_salida,r.cant_dia_reserva, r.estado_reserva, d.nom_depto , u.nom_usuario from reserva r, departamento d, usuario u where r.departamento_id_departamento = d.id_departamento and r.usuario_id_usuario = u.id_usuario", ora);
            OracleDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_ingreso"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_salida"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["cant_dia_reserva"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["estado_reserva"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["nom_depto"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["nom_usuario"].ToString()).SetFont(fontContenido)));
            }

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/Diego/Desktop/Turismo Escritorio/Turismo/Resources/TurismoReal-removebg-preview.png")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var titulo = new Paragraph("Reporte de Reserva");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(17);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(10);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte1.pdf"), new PdfWriter(@"C:\Users\Diego\Desktop\Reporte\ReporteReserva.pdf"));

            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i <= numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);
                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 50, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            }
            doc.Close();
            ora.Close();


        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            CrearPDF();
            MessageBox.Show("Reporete Generado", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = await GetHttp();
                List<PostViewListarReserva> lst = JsonConvert.DeserializeObject<List<PostViewListarReserva>>(respuesta);
                dgvReserva.DataSource = lst;
            }
            catch 
            {
                MessageBox.Show("No se encontraron Reserva", "Turismo Real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
