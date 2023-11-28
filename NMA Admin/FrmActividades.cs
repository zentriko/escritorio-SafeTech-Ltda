using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NMA_Admin
{
    public partial class FrmActividades : Form
    {
        private Timer notificacionTimer;
        private NotifyIcon notifyIcon;

        public FrmActividades()
        {
            InitializeComponent();
            InicializarTimer();
            InicializarNotificacionIcono();
        }

        private void FrmActividades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'nmaA.ACTIVIDAD' Puede moverla o quitarla según sea necesario.
            this.aCTIVIDADTableAdapter2.Fill(this.nmaA.ACTIVIDAD);
            // TODO: esta línea de código carga datos en la tabla 'act1.ACTIVIDAD' Puede moverla o quitarla según sea necesario.
            this.aCTIVIDADTableAdapter1.Fill(this.act1.ACTIVIDAD);
            // Cargar datos en el DataGridView cuando el formulario se carga

            // Eliminar el código relacionado con el botón Notificar Atrasos
        }

        private void InicializarTimer()
        {
            // Inicializar el timer
            notificacionTimer = new Timer();
            notificacionTimer.Interval = 60000; // Intervalo en milisegundos (1 minuto)
            notificacionTimer.Tick += NotificacionTimer_Tick;
            notificacionTimer.Start();
        }

        private void InicializarNotificacionIcono()
        {
            // Inicializar el icono de notificación
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon("C:\\Users\\Diego\\Documents\\h4znm1lo.ico"); // Establece la ruta correcta para tu ícono
            notifyIcon.Visible = true;
        }

        private void NotificacionTimer_Tick(object sender, EventArgs e)
        {
            // Verificar periódicamente si hay actividades pendientes
            VerificarActividadesPendientes();
        }

        private void VerificarActividadesPendientes()
        {
            // Filtrar las actividades con estado "Pendiente"
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_ACTIVIDAD", typeof(int));
            dt.Columns.Add("ESTADO", typeof(string));
            dt.Columns.Add("NOMBRE_ACT", typeof(string));
            dt.Columns.Add("FECHA", typeof(DateTime));
            dt.Columns.Add("ADMINISTRADOR_ID", typeof(int));
            dt.Columns.Add("CHECKLIST_ID", typeof(int));
            dt.Columns.Add("CLIENTE_ID", typeof(int));
            dt.Columns.Add("PROFESIONAL_ID", typeof(int));
            dt.Columns.Add("NOMBRE_CLIENTE", typeof(string));
            dt.Columns.Add("TIPO_EMPRESA", typeof(string));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["eSTADODataGridViewTextBoxColumn1"].Value != null &&
                    row.Cells["iDACTIVIDADDataGridViewTextBoxColumn"].Value != null &&
                    row.Cells["dataGridViewTextBoxColumn1"].Value != null &&
                    row.Cells["fECHADataGridViewTextBoxColumn"].Value != null &&
                    row.Cells["aDMINISTRADORIDDataGridViewTextBoxColumn"].Value != null &&
                    row.Cells["cHECKLISTIDDataGridViewTextBoxColumn"].Value != null &&
                    row.Cells["cLIENTEIDDataGridViewTextBoxColumn"].Value != null &&
                    row.Cells["pROFESIONALIDDataGridViewTextBoxColumn"].Value != null &&
                    row.Cells["nOMBRECLIENTEDataGridViewTextBoxColumn"].Value != null &&
                    row.Cells["tIPOEMPRESADataGridViewTextBoxColumn"].Value != null &&
                    row.Cells["eSTADODataGridViewTextBoxColumn1"].Value.ToString() == "pendiente")
                {
                    string nombreCliente = row.Cells["nOMBRECLIENTEDataGridViewTextBoxColumn"].Value.ToString();

                    dt.Rows.Add(
                        row.Cells["iDACTIVIDADDataGridViewTextBoxColumn"].Value,
                        row.Cells["eSTADODataGridViewTextBoxColumn1"].Value,
                        row.Cells["dataGridViewTextBoxColumn1"].Value,
                        row.Cells["fECHADataGridViewTextBoxColumn"].Value,
                        row.Cells["aDMINISTRADORIDDataGridViewTextBoxColumn"].Value,
                        row.Cells["cHECKLISTIDDataGridViewTextBoxColumn"].Value,
                        row.Cells["cLIENTEIDDataGridViewTextBoxColumn"].Value,
                        row.Cells["pROFESIONALIDDataGridViewTextBoxColumn"].Value,
                        nombreCliente, // Usar el nombre del cliente de la columna NOMBRECLIENTE directamente
                        row.Cells["tIPOEMPRESADataGridViewTextBoxColumn"].Value
                    );

                    // Envía el correo electrónico al administrador incluyendo el nombre del cliente en el mensaje
                    
                }
            }
        }

        private void MostrarNotificacion(string mensaje)
        {
            // Mostrar notificación utilizando NotifyIcon
            notifyIcon.ShowBalloonTip(5000, "Notificación de actividad", mensaje, ToolTipIcon.Info);
        }

        // Resto del código...

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Cuando se agregan filas al DataGridView, verificar automáticamente las actividades pendientes
            VerificarActividadesPendientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código para manejar eventos de celdas si es necesario
        }
    }
}
