using System;
using System.Windows.Forms;

namespace NMA_Admin
{
    public partial class FrmActividades : Form
    {
        public FrmActividades()
        {
            InitializeComponent();
        }

        private void FrmActividades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'act1.ACTIVIDAD' Puede moverla o quitarla según sea necesario.
            this.aCTIVIDADTableAdapter1.Fill(this.act1.ACTIVIDAD);
            // Cargar datos en el DataGridView cuando el formulario se carga

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código adicional si es necesario
        }
    }
}
