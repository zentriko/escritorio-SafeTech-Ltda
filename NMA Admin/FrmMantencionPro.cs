using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace NMA_Admin
{
    public partial class FrmMantencionPro : Form
    {
        // Cadena de conexión a la base de datos Oracle
        private const string ConnectionString = "Data Source=xe;User Id=nma;Password=nma123;";

        public FrmMantencionPro()
        {
            InitializeComponent();
        }

        private void FrmMantencionPro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'nmabda.PROFESIONAL' Puede moverla o quitarla según sea necesario.
            this.pROFESIONALTableAdapter1.Fill(this.nmabda.PROFESIONAL);
        }

        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            FrmNuevoPro nuevoPro = new FrmNuevoPro();
            nuevoPro.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtén el ID del profesional seleccionado en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idProfesional = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDPRODataGridViewTextBoxColumn"].Value);

                // Realiza la eliminación en la base de datos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                using (OracleConnection connection = new OracleConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM profesional WHERE ID_PRO = :ID";

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.Parameters.Add("ID", OracleType.Number).Value = idProfesional;

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Profesional eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el profesional para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el profesional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un profesional para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
