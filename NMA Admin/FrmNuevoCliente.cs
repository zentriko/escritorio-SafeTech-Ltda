using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace NMA_Admin
{
    public partial class FrmNuevoCliente : Form
    {
        // Cadena de conexión a la base de datos Oracle
        string connectionString = "Data Source=xe;User Id=nma;Password=nma123;";

        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        // Función para insertar datos en la base de datos
        private void InsertarDatos()
        {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Consulta SQL para la inserción de datos
                    string query = "INSERT INTO cliente (id_cliente, nombre, apellido, tipo_empresa, usuario, contrasena) VALUES (:valorCampo1, :valorCampo2, :valorCampo3, :valorCampo4, :valorCampo5,  :valorCampo6)";

                    // Formatear la fecha
                    
                


                    // Crear el comando con la consulta y la conexión

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":valorCampo1", OracleType.VarChar).Value = txtID.Text;
                        command.Parameters.Add(":valorCampo2", OracleType.VarChar).Value = txtNombre.Text;
                        command.Parameters.Add(":valorCampo3", OracleType.VarChar).Value = txtApellido.Text;
                        command.Parameters.Add(":valorCampo4", OracleType.VarChar).Value = comboBoxEmpresa.SelectedItem.ToString(); // Asumiendo que comboBoxEmpresa tiene opciones válidas seleccionadas
                        command.Parameters.Add(":valorCampo5", OracleType.VarChar).Value = txtUsuario.Text; // Agregado el campo de usuario
                        command.Parameters.Add(":valorCampo6", OracleType.VarChar).Value = txtContrasena.Text; // No es seguro almacenar contraseñas en texto plano

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();

                        MessageBox.Show("Datos insertados correctamente.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llamar a la función para insertar datos cuando se haga clic en el botón "Registrarse"
            InsertarDatos();
        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}