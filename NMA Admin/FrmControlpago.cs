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

namespace NMA_Admin
{
    public partial class FrmControlpago : Form
    {
        public FrmControlpago()
        {
            InitializeComponent();
        }

        private void FrmControlpago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.CONTRATO' Puede moverla o quitarla según sea necesario.
            this.cONTRATOTableAdapter2.Fill(this.dataSet2.CONTRATO);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.CONTRATO' Puede moverla o quitarla según sea necesario.
            this.cONTRATOTableAdapter1.Fill(this.dataSet1.CONTRATO);
            // TODO: esta línea de código carga datos en la tabla 'nmapago.CONTRATO' Puede moverla o quitarla según sea necesario.
            this.cONTRATOTableAdapter.Fill(this.nmapago.CONTRATO);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Cliente(object sender, EventArgs e)
        {
            Frmnuevocontrato nuevocontratoForm = new Frmnuevocontrato();
            nuevocontratoForm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado
                int idContrato = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDCONTRATODataGridViewTextBoxColumn"].Value);

                // Realizar la conexión a la base de datos
                string connectionString = "Data Source=xe;User Id=nma;Password=nma123;";

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Consulta SQL para eliminar el cliente por su ID
                        string query = "DELETE FROM contrato WHERE id_contrato = :idContrato";

                        // Crear el comando con la consulta y la conexión
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            // Asignar el valor del parámetro
                            command.Parameters.Add(":idContrato", OracleType.Number).Value = idContrato;

                            // Ejecutar la consulta
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Contrato  eliminado correctamente.");
                            }
                            else
                            {
                                MessageBox.Show("Contrato no encontrado o no se pudo eliminar.");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar Contrato: " + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un Contrato para eliminar.");
            }
        }

        private void btnNuevocontrato_Click(object sender, EventArgs e)
        {
            Frmnuevocontrato nuevocontratoForm = new Frmnuevocontrato();
            nuevocontratoForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
