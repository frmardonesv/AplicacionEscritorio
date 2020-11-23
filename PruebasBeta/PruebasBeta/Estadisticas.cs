using iText.IO.Font.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using static PruebasBeta.Form1;

namespace PruebasBeta
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }


        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");

        
        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        public void crearPdf(String filename)
        {
            
        }

        public DataTable deptoList()
        {

            DataTable dt = new DataTable();
            if (MantenerDato.valorPersonal == "1")
            {
                {
                    ora.Open();
                    OracleCommand comando = new OracleCommand("GETPRUEBAS", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = MantenerDato.valorZona;
                    comando.Parameters.Add("CURSOR_", OracleType.Cursor).Direction = ParameterDirection.Output;


                    OracleDataAdapter adapter = new OracleDataAdapter(comando);
                    adapter.Fill(dt);
                    adapter.Dispose();
                    ora.Close();

                }
            }
            else {
                ora.Open();
                OracleCommand comando = new OracleCommand("REPORTE_SA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("CURSOR_", OracleType.Cursor).Direction = ParameterDirection.Output;


                OracleDataAdapter adapter = new OracleDataAdapter(comando);
                adapter.Fill(dt);
                adapter.Dispose();
                ora.Close();

            }

            return dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("reporte.pdf", FileMode.Create));
            document.Open();
            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.BLACK);
            title.Add("Reporte de reservas y ganancias por departamento");
            document.Add(title);
            document.Add(new Paragraph(" "));


            dt = deptoList();
            if (dt.Rows.Count != 0)
            {
                document.Open();
                Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
                Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);

                PdfPTable table = new PdfPTable(dt.Columns.Count);

                document.Add(new Chunk("\n"));

                float[] widths = new float[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                    widths[i] = 4f;

                table.SetWidths(widths);
                table.WidthPercentage = 90;

                PdfPCell cell = new PdfPCell(new Phrase("columns"));
                cell.Colspan = dt.Columns.Count;

                foreach (DataColumn c in dt.Columns)
                {
                    table.AddCell(new Phrase(c.ColumnName, font9));
                }

                foreach (DataRow r in dt.Rows)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int h = 0; h < dt.Columns.Count; h++)
                        {
                            table.AddCell(new Phrase(r[h].ToString(), font9));
                        }
                    }

                }
                document.Add(table);

            }
            document.Close();
            MessageBox.Show("Reporte creado, revise su carpeta de reportes.");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            btnReporte.Visible = true;
            btnListar.Visible = false;
            if (MantenerDato.valorPersonal == "1")
            {
                {
                    ora.Open();
                    OracleCommand comando = new OracleCommand("GETPRUEBAS", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = MantenerDato.valorZona;
                    comando.Parameters.Add("CURSOR_", OracleType.Cursor).Direction = ParameterDirection.Output;


                    OracleDataAdapter adapter = new OracleDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable tabla1 = new DataTable();
                    adapter.Fill(tabla1);
                    dataGridView1.DataSource = tabla1;

                    ora.Close();

                }
            }
            else
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("REPORTE_SA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("CURSOR_", OracleType.Cursor).Direction = ParameterDirection.Output;


                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = comando;
                DataTable tabla1 = new DataTable();
                adapter.Fill(tabla1);
                dataGridView1.DataSource = tabla1;

                ora.Close();
            }
            }
        }
    }

