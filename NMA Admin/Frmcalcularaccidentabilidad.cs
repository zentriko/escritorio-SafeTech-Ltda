using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.OracleClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Collections.Generic;

namespace NMA_Admin
{
    public partial class Frmcalcularaccidentabilidad : Form
    {
        private readonly string connectionString = "Data Source=xe;User Id=nma;Password=nma123;";

        public Frmcalcularaccidentabilidad()
        {
            InitializeComponent();
        }

        private void Frmcalcularaccidentabilidad_Load(object sender, EventArgs e)
        {
            this.rEPORTETableAdapter.Fill(this.dataSetrepo.REPORTE);
            comboBox1.Items.Add("Minera");
            comboBox1.Items.Add("Industrial");
            comboBox1.Items.Add("Construcción");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = comboBox1.SelectedItem.ToString();
            DataTable REPORTE = ObtenerDatosREPORTE(tipoSeleccionado);
            int accidentabilidad = REPORTE.AsEnumerable()
                .Where(fila => fila.Field<string>("tipo").Equals(tipoSeleccionado, StringComparison.OrdinalIgnoreCase))
                .Sum(fila => Convert.ToInt32(fila["numero"]));

            lblAccidentabilidad.Text = $"Accidentabilidad para {tipoSeleccionado}: {accidentabilidad} accidentes";
            dataGridView1.DataSource = REPORTE;
        }

        private DataTable ObtenerDatosREPORTE(string tipoSeleccionado)
        {
            return this.dataSetrepo.REPORTE;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear un nuevo gráfico de barras
            Chart chartAccidentes = new Chart();

            // Establecer un tamaño específico para el control de Chart
            chartAccidentes.Size = new Size(400, 300);

            // Configurar el gráfico
            chartAccidentes.ChartAreas.Add("ChartArea");
            chartAccidentes.Series.Add("Accidentes");
            chartAccidentes.Series["Accidentes"].ChartType = SeriesChartType.Bar;

            // Obtener los datos del tipo seleccionado
            DataTable datosTipo = ObtenerDatosREPORTE(comboBox1.SelectedItem.ToString());

            // Crear un diccionario para almacenar la suma de accidentes por tipo
            Dictionary<string, int> sumaAccidentesPorTipo = new Dictionary<string, int>();

            // Sumar los accidentes por tipo
            foreach (DataRow row in datosTipo.Rows)
            {
                string tipo = row["tipo"].ToString();
                int numeroAccidentes = Convert.ToInt32(row["numero"]);

                if (sumaAccidentesPorTipo.ContainsKey(tipo))
                {
                    sumaAccidentesPorTipo[tipo] += numeroAccidentes;
                }
                else
                {
                    sumaAccidentesPorTipo.Add(tipo, numeroAccidentes);
                }
            }

            // Agregar las sumas al gráfico
            foreach (var tipoSuma in sumaAccidentesPorTipo)
            {
                chartAccidentes.Series["Accidentes"].Points.AddXY(tipoSuma.Key, tipoSuma.Value);
            }

            // Establecer la ubicación debajo del botón
            chartAccidentes.Location = new Point(button1.Left, button1.Bottom + 10);  // Ajusta el espacio entre el botón y el gráfico según tus necesidades

            // Agregar el control de Chart al formulario
            this.Controls.Add(chartAccidentes);
        }



    }
}
