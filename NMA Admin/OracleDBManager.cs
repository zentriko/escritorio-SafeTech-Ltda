    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.OracleClient;
    using System.Windows.Forms;
    using System.Data;

    public class OracleDBManager
    {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
        private OracleConnection connection;
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        private string connectionString;

        public OracleDBManager(string dataSource, string userId, string password)
        {
            // Define la cadena de conexión en el constructor
            connectionString = $"User Id=nma;Password=nma123;Data Source=xe";
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            connection = new OracleConnection(connectionString);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        }

        public bool OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    MessageBox.Show("Conexión Exitosa");
                    return true;
                }
                else
                {
                    MessageBox.Show("La conexión ya está abierta.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
                return false;
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada exitosamente.");
            }
            else
            {
                MessageBox.Show("La conexión ya está cerrada.");
            }
        }
     
    public int ObtenerNumeroSiguiente()
    {
        int numeroSiguiente = 1; // Valor predeterminado si no hay registros en la base de datos

        try
        {
            if (OpenConnection())
            {
                // Consulta SQL para obtener el último número de código
                string query = "SELECT MAX(ID_CLIENTE) FROM CLIENTE";

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        numeroSiguiente = Convert.ToInt32(result) + 1;
                    }
                }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos

                CloseConnection();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al obtener el número siguiente: " + ex.Message);
        }

        return numeroSiguiente;
    }




}


