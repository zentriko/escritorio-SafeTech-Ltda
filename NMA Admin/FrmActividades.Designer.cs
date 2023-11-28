namespace NMA_Admin
{
    partial class FrmActividades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividades));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDACTIVIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINISTRADORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHECKLISTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFESIONALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOEMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVIDADBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.nmaABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nmaA = new NMA_Admin.nmaA();
            this.aCTIVIDADBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPO_EMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVIDADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.act1 = new NMA_Admin.act1();
            this.nOMBRE_CLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividades = new NMA_Admin.Actividades();
            this.aCTIVIDADTableAdapter = new NMA_Admin.ActividadesTableAdapters.ACTIVIDADTableAdapter();
            this.aCTIVIDADTableAdapter1 = new NMA_Admin.act1TableAdapters.ACTIVIDADTableAdapter();
            this.aCTIVIDADTableAdapter2 = new NMA_Admin.nmaATableAdapters.ACTIVIDADTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmaABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividades)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDACTIVIDADDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.fECHADataGridViewTextBoxColumn,
            this.aDMINISTRADORIDDataGridViewTextBoxColumn,
            this.cHECKLISTIDDataGridViewTextBoxColumn,
            this.cLIENTEIDDataGridViewTextBoxColumn,
            this.pROFESIONALIDDataGridViewTextBoxColumn,
            this.nOMBRECLIENTEDataGridViewTextBoxColumn,
            this.tIPOEMPRESADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCTIVIDADBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(35, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDACTIVIDADDataGridViewTextBoxColumn
            // 
            this.iDACTIVIDADDataGridViewTextBoxColumn.DataPropertyName = "ID_ACTIVIDAD";
            this.iDACTIVIDADDataGridViewTextBoxColumn.HeaderText = "ID_ACTIVIDAD";
            this.iDACTIVIDADDataGridViewTextBoxColumn.Name = "iDACTIVIDADDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn1
            // 
            this.eSTADODataGridViewTextBoxColumn1.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn1.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn1.Name = "eSTADODataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE_ACT";
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE_ACT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // aDMINISTRADORIDDataGridViewTextBoxColumn
            // 
            this.aDMINISTRADORIDDataGridViewTextBoxColumn.DataPropertyName = "ADMINISTRADOR_ID";
            this.aDMINISTRADORIDDataGridViewTextBoxColumn.HeaderText = "ADMINISTRADOR_ID";
            this.aDMINISTRADORIDDataGridViewTextBoxColumn.Name = "aDMINISTRADORIDDataGridViewTextBoxColumn";
            // 
            // cHECKLISTIDDataGridViewTextBoxColumn
            // 
            this.cHECKLISTIDDataGridViewTextBoxColumn.DataPropertyName = "CHECKLIST_ID";
            this.cHECKLISTIDDataGridViewTextBoxColumn.HeaderText = "CHECKLIST_ID";
            this.cHECKLISTIDDataGridViewTextBoxColumn.Name = "cHECKLISTIDDataGridViewTextBoxColumn";
            // 
            // cLIENTEIDDataGridViewTextBoxColumn
            // 
            this.cLIENTEIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_ID";
            this.cLIENTEIDDataGridViewTextBoxColumn.HeaderText = "CLIENTE_ID";
            this.cLIENTEIDDataGridViewTextBoxColumn.Name = "cLIENTEIDDataGridViewTextBoxColumn";
            // 
            // pROFESIONALIDDataGridViewTextBoxColumn
            // 
            this.pROFESIONALIDDataGridViewTextBoxColumn.DataPropertyName = "PROFESIONAL_ID";
            this.pROFESIONALIDDataGridViewTextBoxColumn.HeaderText = "PROFESIONAL_ID";
            this.pROFESIONALIDDataGridViewTextBoxColumn.Name = "pROFESIONALIDDataGridViewTextBoxColumn";
            // 
            // nOMBRECLIENTEDataGridViewTextBoxColumn
            // 
            this.nOMBRECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CLIENTE";
            this.nOMBRECLIENTEDataGridViewTextBoxColumn.HeaderText = "NOMBRE_CLIENTE";
            this.nOMBRECLIENTEDataGridViewTextBoxColumn.Name = "nOMBRECLIENTEDataGridViewTextBoxColumn";
            // 
            // tIPOEMPRESADataGridViewTextBoxColumn
            // 
            this.tIPOEMPRESADataGridViewTextBoxColumn.DataPropertyName = "TIPO_EMPRESA";
            this.tIPOEMPRESADataGridViewTextBoxColumn.HeaderText = "TIPO_EMPRESA";
            this.tIPOEMPRESADataGridViewTextBoxColumn.Name = "tIPOEMPRESADataGridViewTextBoxColumn";
            // 
            // aCTIVIDADBindingSource3
            // 
            this.aCTIVIDADBindingSource3.DataMember = "ACTIVIDAD";
            this.aCTIVIDADBindingSource3.DataSource = this.nmaABindingSource;
            // 
            // nmaABindingSource
            // 
            this.nmaABindingSource.DataSource = this.nmaA;
            this.nmaABindingSource.Position = 0;
            // 
            // nmaA
            // 
            this.nmaA.DataSetName = "nmaA";
            this.nmaA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCTIVIDADBindingSource2
            // 
            this.aCTIVIDADBindingSource2.DataMember = "ACTIVIDAD";
            this.aCTIVIDADBindingSource2.DataSource = this.nmaA;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // tIPO_EMPRESADataGridViewTextBoxColumn
            // 
            this.tIPO_EMPRESADataGridViewTextBoxColumn.Name = "tIPO_EMPRESADataGridViewTextBoxColumn";
            // 
            // aCTIVIDADBindingSource1
            // 
            this.aCTIVIDADBindingSource1.DataMember = "ACTIVIDAD";
            this.aCTIVIDADBindingSource1.DataSource = this.act1;
            // 
            // act1
            // 
            this.act1.DataSetName = "act1";
            this.act1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOMBRE_CLIENTEDataGridViewTextBoxColumn
            // 
            this.nOMBRE_CLIENTEDataGridViewTextBoxColumn.Name = "nOMBRE_CLIENTEDataGridViewTextBoxColumn";
            // 
            // aCTIVIDADBindingSource
            // 
            this.aCTIVIDADBindingSource.DataMember = "ACTIVIDAD";
            this.aCTIVIDADBindingSource.DataSource = this.actividades;
            // 
            // actividades
            // 
            this.actividades.DataSetName = "Actividades";
            this.actividades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCTIVIDADTableAdapter
            // 
            this.aCTIVIDADTableAdapter.ClearBeforeFill = true;
            // 
            // aCTIVIDADTableAdapter1
            // 
            this.aCTIVIDADTableAdapter1.ClearBeforeFill = true;
            // 
            // aCTIVIDADTableAdapter2
            // 
            this.aCTIVIDADTableAdapter2.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 60);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Visualizar Actividades";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::NMA_Admin.Properties.Resources.lapiz;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Actividad Pendiente";
            this.notifyIcon1.Visible = true;
            // 
            // FrmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActividades";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.FrmActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmaABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Actividades actividades;
        private System.Windows.Forms.BindingSource aCTIVIDADBindingSource;
        private ActividadesTableAdapters.ACTIVIDADTableAdapter aCTIVIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRE_CLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPO_EMPRESADataGridViewTextBoxColumn;
#pragma warning disable CS0169 // El campo 'FrmActividades.nOMBREACTDataGridViewTextBoxColumn' nunca se usa
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREACTDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // El campo 'FrmActividades.nOMBREACTDataGridViewTextBoxColumn' nunca se usa
        private act1 act1;
        private System.Windows.Forms.BindingSource aCTIVIDADBindingSource1;
        private act1TableAdapters.ACTIVIDADTableAdapter aCTIVIDADTableAdapter1;
        private nmaA nmaA;
        private System.Windows.Forms.BindingSource aCTIVIDADBindingSource2;
        private nmaATableAdapters.ACTIVIDADTableAdapter aCTIVIDADTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDACTIVIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINISTRADORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHECKLISTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFESIONALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOEMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aCTIVIDADBindingSource3;
        private System.Windows.Forms.BindingSource nmaABindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}