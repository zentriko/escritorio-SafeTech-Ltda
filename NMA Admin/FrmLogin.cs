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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = xe; PASSWORD=nma123; USER ID=nma");
            con.Open();
            MessageBox.Show("Conexión Exitosa");
            con.Close();
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtboxUsuario.Text == "admin" && txtboxContrasena.Text == "123") 
            {
                
                FrmMenu menu = new FrmMenu();
                this.Hide();
                menu.Show();

            }
            else
            {
                MessageBox.Show("ERROR: Los datos ingresados son incorrectos");
                txtboxUsuario.Clear();
                txtboxContrasena.Clear();

            }
           
                


        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
