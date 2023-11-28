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
    public partial class Frmnuevocontrato : Form
    {
        private const string ConnectionString = "Data Source=xe;User ID=nma;Password=nma123";

        public Frmnuevocontrato()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id_contrato = textBox1.Text;
            string fecha_inicio = textBox2.Text;
            string fecha_termino = textBox3.Text;
            string monto = textBox4.Text;
            string cliente_id = textBox5.Text;
            string correo = textBox6.Text;
            string nombre_empresa = textBox7.Text;
            string nombre_usuario = textBox8.Text;
            string tipo_suscripcion = textBox9.Text;

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            using (OracleConnection connection = new OracleConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Contrato (id_contrato, fecha_inicio, fecha_termino, monto, cliente_id, correo, nombre_empresa, nombre_usuario, tipo_suscripcion) " +
                                    "VALUES (:ID_CONTRATO, :FECHA_INICIO, :FECHA_TERMINO, :MONTO, :CLIENTE_ID, :CORREO, :NOMBRE_EMPRESA, :NOMBRE_USUARIO, :TIPO_SUSCRIPCION)";

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("ID_CONTRATO", OracleType.VarChar).Value = id_contrato;
                        command.Parameters.Add("FECHA_INICIO", OracleType.VarChar).Value = fecha_inicio;
                        command.Parameters.Add("FECHA_TERMINO", OracleType.VarChar).Value = fecha_termino;
                        command.Parameters.Add("MONTO", OracleType.VarChar).Value = monto;
                        command.Parameters.Add("CLIENTE_ID", OracleType.VarChar).Value = cliente_id;
                        command.Parameters.Add("CORREO", OracleType.VarChar).Value = correo;
                        command.Parameters.Add("NOMBRE_EMPRESA", OracleType.VarChar).Value = nombre_empresa;
                        command.Parameters.Add("NOMBRE_USUARIO", OracleType.VarChar).Value = nombre_usuario;
                        command.Parameters.Add("TIPO_SUSCRIPCION", OracleType.VarChar).Value = tipo_suscripcion;

                        command.ExecuteNonQuery();

                        MessageBox.Show("Contrato registrado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error al registrar el Contrato en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Otro error al registrar el Contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        }

        private void btnAgregarcontrato_Click(object sender, EventArgs e)
        {
            {
                string id_contrato = textBox1.Text;
                string fecha_inicio = textBox2.Text;
                string fecha_termino = textBox3.Text;
                string monto = textBox4.Text;
                string cliente_id = textBox5.Text;
                string correo = textBox6.Text;
                string nombre_empresa = textBox7.Text;
                string nombre_usuario = textBox8.Text;
                string tipo_suscripcion = textBox9.Text;

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                using (OracleConnection connection = new OracleConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO Contrato (id_contrato, fecha_inicio, fecha_termino, monto, cliente_id, correo, nombre_empresa, nombre_usuario, tipo_suscripcion) " +
                                        "VALUES (:ID_CONTRATO, :FECHA_INICIO, :FECHA_TERMINO, :MONTO, :CLIENTE_ID, :CORREO, :NOMBRE_EMPRESA, :NOMBRE_USUARIO, :TIPO_SUSCRIPCION)";

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.Parameters.Add("ID_CONTRATO", OracleType.VarChar).Value = id_contrato;
                            command.Parameters.Add("FECHA_INICIO", OracleType.VarChar).Value = fecha_inicio;
                            command.Parameters.Add("FECHA_TERMINO", OracleType.VarChar).Value = fecha_termino;
                            command.Parameters.Add("MONTO", OracleType.VarChar).Value = monto;
                            command.Parameters.Add("CLIENTE_ID", OracleType.VarChar).Value = cliente_id;
                            command.Parameters.Add("CORREO", OracleType.VarChar).Value = correo;
                            command.Parameters.Add("NOMBRE_EMPRESA", OracleType.VarChar).Value = nombre_empresa;
                            command.Parameters.Add("NOMBRE_USUARIO", OracleType.VarChar).Value = nombre_usuario;
                            command.Parameters.Add("TIPO_SUSCRIPCION", OracleType.VarChar).Value = tipo_suscripcion;

                            command.ExecuteNonQuery();

                            MessageBox.Show("Contrato registrado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error al registrar el Contrato en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Otro error al registrar el Contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
