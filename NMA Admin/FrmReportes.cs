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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Frmreportecliente reporteclienteForm = new Frmreportecliente();
            reporteclienteForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmreporteglobal reporteglobalForm = new Frmreporteglobal();
            reporteglobalForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmcalcularaccidentabilidad calcularaccidentabilidadForm = new Frmcalcularaccidentabilidad();
            calcularaccidentabilidadForm.Show();
        }
    }


}
