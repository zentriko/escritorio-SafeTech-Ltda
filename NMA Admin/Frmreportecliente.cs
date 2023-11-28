using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OracleClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace NMA_Admin
{
    public partial class Frmreportecliente : Form
    {
        private OracleConnection connection;
        private int clienteIdSeleccionado;

        public Frmreportecliente()
        {
            InitializeComponent();
            connection = new OracleConnection("Data Source=xe;User Id=nma;Password=nma123;");
        }

        private void Frmreportecliente_Load(object sender, EventArgs e)
        {
            CargarDatosClientes();
        }

        private void CargarDatosClientes()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM CLIENTE";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "CLIENTE");
                dataGridView1.DataSource = dataSet.Tables["CLIENTE"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // No need to close the connection here
        }

        private void btnreportepdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    clienteIdSeleccionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDCLIENTEDataGridViewTextBoxColumn"].Value);

                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = $"SELECT * FROM cliente WHERE ID_CLIENTE = :clienteId";
                        cmd.Parameters.Add(new OracleParameter("clienteId", clienteIdSeleccionado));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string clienteNombre = reader["NOMBRE"].ToString(); // Use the client's name for the file name
                                string clienteApellido = reader["APELLIDO"].ToString(); // Use the client's last name for the file name

                                string fileName = $"C:/pruebapdf/InformeCliente_{clienteNombre}_{clienteApellido}.pdf";

                                Document doc = new Document(PageSize.LETTER);
                                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));

                                doc.Open();
                                doc.AddTitle("Ejemplo PDF");
                                doc.AddCreator("Administrador");

                                // Set font and size for the title
                                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                                Paragraph title = new Paragraph("Información del Cliente", titleFont);
                                title.Alignment = Element.ALIGN_CENTER;
                                doc.Add(title);

                                // Set font and size for the content
                                Font contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK);

                                // Add data from the database to the PDF with specific formatting
                                doc.Add(new Paragraph($"ID_CLIENTE: {reader["ID_CLIENTE"]}", contentFont));
                                doc.Add(new Paragraph($"NOMBRE: {reader["NOMBRE"]}", contentFont));
                                doc.Add(new Paragraph($"APELLIDO: {reader["APELLIDO"]}", contentFont));
                                doc.Add(new Paragraph($"CORREO: {reader["CORREO"]}", contentFont));
                                doc.Add(new Paragraph($"USUARIO: {reader["USUARIO"]}", contentFont));
                                doc.Add(new Paragraph($"CONTRASEÑA: {reader["CONTRASENA"]}", contentFont));
                                doc.Add(new Paragraph($"FECHA_REGISTRO: {reader["FECHA_REGISTRO"]}", contentFont));

                                doc.Add(Chunk.NEWLINE);

                                doc.Close();
                                MessageBox.Show($"Archivo Creado: {fileName}");
                            }
                        }
                    }

                    MessageBox.Show("Informe creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente antes de generar el informe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
