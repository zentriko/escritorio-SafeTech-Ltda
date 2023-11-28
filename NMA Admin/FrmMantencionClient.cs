using System;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace NMA_Admin
{
    public partial class FrmMantencionClient : Form
    {
        public FrmMantencionClient()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmMantencionClient_Load);
        }

        private void FrmMantencionClient_Load(object sender, EventArgs e)
        {
            // Cargar datos en el DataGridView cuando el formulario se carga
            this.cLIENTETableAdapter1.Fill(this.nmabd.CLIENTE);
        }

        private void btnNuevoClient_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoClienteForm = new FrmNuevoCliente();
            nuevoClienteForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDCLIENTEDataGridViewTextBoxColumn"].Value);

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
                        string query = "DELETE FROM cliente WHERE id_cliente = :idCliente";

                        // Crear el comando con la consulta y la conexión
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            // Asignar el valor del parámetro
                            command.Parameters.Add(":idCliente", OracleType.Number).Value = idCliente;

                            // Ejecutar la consulta
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente eliminado correctamente.");
                            }
                            else
                            {
                                MessageBox.Show("Cliente no encontrado o no se pudo eliminar.");
                            }
                        }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                    }
                }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}