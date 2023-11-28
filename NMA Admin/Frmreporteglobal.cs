using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Windows.Forms;

namespace NMA_Admin
{
    public partial class Frmreporteglobal : Form
    {
        public Frmreporteglobal()
        {
            InitializeComponent();
        }

        private void Frmreporteglobal_Load_1(object sender, EventArgs e)
        {
            // Load the initial data when the form loads
            CargarDatos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the selected index change event of the ComboBox
            CargarDatos();
        }

        private void CargarDatos()
        {
            string selectedOption = comboBox1.SelectedItem?.ToString();

            // Set the default query to select all records
            string query = "SELECT * FROM REPORTE";
            string queryActividad = "SELECT * FROM ACTIVIDAD";
            string queryCliente = "SELECT * FROM CLIENTE";
            string queryContrato = "SELECT * FROM CONTRATO";

            // If the selected option is "minera", "industrial", or "construccion," modify the queries
            if (selectedOption == "minera" || selectedOption == "industrial" || selectedOption == "construccion")
            {
                query = $"SELECT * FROM REPORTE WHERE TIPO = '{selectedOption}'";
                queryActividad = $"SELECT * FROM CLIENTE WHERE TIPO_EMPRESA = '{selectedOption}'";
                queryCliente = $"SELECT * FROM ACTIVIDAD WHERE TIPO_EMPRESA = '{selectedOption}'";
                queryContrato = $"SELECT * FROM CONTRATO WHERE TIPO_EMPRESA = '{selectedOption}'";
            }

            string connectionString = "Data Source=xe;User Id=nma;Password=nma123";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    // Cargar datos en dataGridView1 (tabla REPORTE)
                    using (OracleCommand cmdReporte = new OracleCommand(query, connection))
                    {
                        using (OracleDataAdapter adapterReporte = new OracleDataAdapter(cmdReporte))
                        {
                            DataTable dataTableReporte = new DataTable();
                            adapterReporte.Fill(dataTableReporte);
                            dataGridView1.DataSource = dataTableReporte;
                        }
                    }

                    // Cargar datos en dataGridView2 (tabla ACTIVIDAD)
                    using (OracleCommand cmdActividad = new OracleCommand(queryActividad, connection))
                    {
                        using (OracleDataAdapter adapterActividad = new OracleDataAdapter(cmdActividad))
                        {
                            DataTable dataTableActividad = new DataTable();
                            adapterActividad.Fill(dataTableActividad);
                            dataGridView2.DataSource = dataTableActividad;
                        }
                    }

                    // Cargar datos en dataGridView3 (tabla CLIENTE)
                    using (OracleCommand cmdCliente = new OracleCommand(queryCliente, connection))
                    {
                        using (OracleDataAdapter adapterCliente = new OracleDataAdapter(cmdCliente))
                        {
                            DataTable dataTableCliente = new DataTable();
                            adapterCliente.Fill(dataTableCliente);
                            dataGridView3.DataSource = dataTableCliente;
                        }
                    }

                    // Cargar datos en dataGridView4 (tabla CONTRATO)
                    using (OracleCommand cmdContrato = new OracleCommand(queryContrato, connection))
                    {
                        using (OracleDataAdapter adapterContrato = new OracleDataAdapter(cmdContrato))
                        {
                            DataTable dataTableContrato = new DataTable();
                            adapterContrato.Fill(dataTableContrato);
                            dataGridView4.DataSource = dataTableContrato;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnreportepdf_Click(object sender, EventArgs e)
        {

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF|*.pdf";
                saveFileDialog.Title = "Guardar Reporte PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document();
                        PdfWriter.GetInstance(pdfDoc, fs);
                        pdfDoc.Open();

                        // Agregar contenido al PDF
                        AgregarContenidoPDF(pdfDoc, "Reporte de REPORTE", dataGridView1);
                        AgregarContenidoPDF(pdfDoc, "Reporte de ACTIVIDAD", dataGridView2);
                        AgregarContenidoPDF(pdfDoc, "Reporte de CLIENTE", dataGridView3);
                        AgregarContenidoPDF(pdfDoc, "Reporte de CONTRATO", dataGridView4);

                        pdfDoc.Close();
                        fs.Close();
                    }

                    MessageBox.Show("El informe PDF ha sido generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el informe PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarContenidoPDF(Document pdfDoc, string titulo, DataGridView dataGridView)
        {
            pdfDoc.Add(new Paragraph(titulo));
            pdfDoc.Add(new Paragraph("\n"));

            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            // Establecer estilo para los encabezados
            PdfPCell headerCell = new PdfPCell();
            headerCell.BackgroundColor = new BaseColor(173, 216, 230); // Color de fondo (LightBlue)
            headerCell.Padding = 3;

            // Agregar encabezados al PDF con estilo
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                headerCell.Phrase = new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD));
                pdfTable.AddCell(headerCell);
            }

            // Agregar filas al PDF con bordes y formato mejorado
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? string.Empty));
                    pdfCell.Padding = 3;
                    pdfCell.BorderWidth = 1;
                    pdfTable.AddCell(pdfCell);
                }
            }

            pdfDoc.Add(pdfTable);
        }

    }
}
