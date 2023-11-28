using System;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace NMA_Admin
{
    public partial class FrmNuevoPro : Form
    {
        private const string ConnectionString = "Data Source=xe;User ID=nma;Password=nma123";

        public FrmNuevoPro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string especialidad = comboBox1.SelectedItem.ToString();
            string usuario = textBox5.Text;
            string contrasena = textBox6.Text;

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            using (OracleConnection connection = new OracleConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO profesional (id_pro, Nombre, Apellido, Especialidad, Usuario, Contrasena) " +
                                   "VALUES (:ID, :Nombre, :Apellido, :Especialidad, :Usuario, :Contrasena)";

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("ID", OracleType.VarChar).Value = id;
                        command.Parameters.Add("Nombre", OracleType.VarChar).Value = nombre;
                        command.Parameters.Add("Apellido", OracleType.VarChar).Value = apellido;
                        command.Parameters.Add("Especialidad", OracleType.VarChar).Value = especialidad;
                        command.Parameters.Add("Usuario", OracleType.VarChar).Value = usuario;
                        command.Parameters.Add("Contrasena", OracleType.VarChar).Value = contrasena;

                        command.ExecuteNonQuery();

                        MessageBox.Show("Profesional registrado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el profesional en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        }

    }
}
