using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMA_Admin
{
    public partial class FrmMantencion : Form
    {
        public FrmMantencion()
        {
            InitializeComponent();
        }
        private void AbrirSubMenu(object formSubMenu)
        {
            if (this.panelContenedorMan.Controls.Count > 0)
                this.panelContenedorMan.Controls.RemoveAt(0);
            Form fh = formSubMenu as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorMan.Controls.Add(fh);
            this.panelContenedorMan.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMantencion_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FrmMantencionClient());
        }

        private void panelContenedorMan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirSubMenu(new FrmMantencionPro());
        }
    }
}
