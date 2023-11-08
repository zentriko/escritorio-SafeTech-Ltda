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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void AbrirSubMenu (object formSubMenu )
        {
            if(this.panelContenedor.Controls.Count>0)
               this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formSubMenu as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();        
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás Seguro de salir del programa?","Confirmación",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

            /* FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();*/
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FrmMantencion());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirSubMenu(new FrmActividades());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FrmPagos());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FrmReportes());
        }
    }
}
