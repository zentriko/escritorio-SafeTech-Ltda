namespace NMA_Admin
{
    partial class FrmControlpago
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCONTRATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHATERMINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREEMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOSUSCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRATOBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new NMA_Admin.DataSet2();
            this.nmapago = new NMA_Admin.nmapago();
            this.cONTRATOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONTRATOTableAdapter = new NMA_Admin.nmapagoTableAdapters.CONTRATOTableAdapter();
            this.nmapagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONTRATOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cONTRATOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cONTRATOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NMA_Admin.DataSet1();
            this.cONTRATOBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cONTRATOTableAdapter1 = new NMA_Admin.DataSet1TableAdapters.CONTRATOTableAdapter();
            this.btnNuevocontrato = new System.Windows.Forms.Button();
            this.btnModificarcon = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cONTRATOTableAdapter2 = new NMA_Admin.DataSet2TableAdapters.CONTRATOTableAdapter();
            this.cONTRATOBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.cONTRATOBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmapago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmapagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCONTRATODataGridViewTextBoxColumn,
            this.fECHAINICIODataGridViewTextBoxColumn,
            this.fECHATERMINODataGridViewTextBoxColumn,
            this.mONTODataGridViewTextBoxColumn,
            this.cLIENTEIDDataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn,
            this.nOMBREEMPRESADataGridViewTextBoxColumn,
            this.nOMBREUSUARIODataGridViewTextBoxColumn,
            this.tIPOSUSCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONTRATOBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDCONTRATODataGridViewTextBoxColumn
            // 
            this.iDCONTRATODataGridViewTextBoxColumn.DataPropertyName = "ID_CONTRATO";
            this.iDCONTRATODataGridViewTextBoxColumn.HeaderText = "ID_CONTRATO";
            this.iDCONTRATODataGridViewTextBoxColumn.Name = "iDCONTRATODataGridViewTextBoxColumn";
            // 
            // fECHAINICIODataGridViewTextBoxColumn
            // 
            this.fECHAINICIODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.HeaderText = "FECHA_INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.Name = "fECHAINICIODataGridViewTextBoxColumn";
            // 
            // fECHATERMINODataGridViewTextBoxColumn
            // 
            this.fECHATERMINODataGridViewTextBoxColumn.DataPropertyName = "FECHA_TERMINO";
            this.fECHATERMINODataGridViewTextBoxColumn.HeaderText = "FECHA_TERMINO";
            this.fECHATERMINODataGridViewTextBoxColumn.Name = "fECHATERMINODataGridViewTextBoxColumn";
            // 
            // mONTODataGridViewTextBoxColumn
            // 
            this.mONTODataGridViewTextBoxColumn.DataPropertyName = "MONTO";
            this.mONTODataGridViewTextBoxColumn.HeaderText = "MONTO";
            this.mONTODataGridViewTextBoxColumn.Name = "mONTODataGridViewTextBoxColumn";
            // 
            // cLIENTEIDDataGridViewTextBoxColumn
            // 
            this.cLIENTEIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_ID";
            this.cLIENTEIDDataGridViewTextBoxColumn.HeaderText = "CLIENTE_ID";
            this.cLIENTEIDDataGridViewTextBoxColumn.Name = "cLIENTEIDDataGridViewTextBoxColumn";
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            // 
            // nOMBREEMPRESADataGridViewTextBoxColumn
            // 
            this.nOMBREEMPRESADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_EMPRESA";
            this.nOMBREEMPRESADataGridViewTextBoxColumn.HeaderText = "NOMBRE_EMPRESA";
            this.nOMBREEMPRESADataGridViewTextBoxColumn.Name = "nOMBREEMPRESADataGridViewTextBoxColumn";
            // 
            // nOMBREUSUARIODataGridViewTextBoxColumn
            // 
            this.nOMBREUSUARIODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_USUARIO";
            this.nOMBREUSUARIODataGridViewTextBoxColumn.HeaderText = "NOMBRE_USUARIO";
            this.nOMBREUSUARIODataGridViewTextBoxColumn.Name = "nOMBREUSUARIODataGridViewTextBoxColumn";
            // 
            // tIPOSUSCRIPCIONDataGridViewTextBoxColumn
            // 
            this.tIPOSUSCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "TIPO_SUSCRIPCION";
            this.tIPOSUSCRIPCIONDataGridViewTextBoxColumn.HeaderText = "TIPO_SUSCRIPCION";
            this.tIPOSUSCRIPCIONDataGridViewTextBoxColumn.Name = "tIPOSUSCRIPCIONDataGridViewTextBoxColumn";
            // 
            // cONTRATOBindingSource5
            // 
            this.cONTRATOBindingSource5.DataMember = "CONTRATO";
            this.cONTRATOBindingSource5.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nmapago
            // 
            this.nmapago.DataSetName = "nmapago";
            this.nmapago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTRATOBindingSource
            // 
            this.cONTRATOBindingSource.DataMember = "CONTRATO";
            this.cONTRATOBindingSource.DataSource = this.nmapago;
            // 
            // cONTRATOTableAdapter
            // 
            this.cONTRATOTableAdapter.ClearBeforeFill = true;
            // 
            // nmapagoBindingSource
            // 
            this.nmapagoBindingSource.DataSource = this.nmapago;
            this.nmapagoBindingSource.Position = 0;
            // 
            // cONTRATOBindingSource1
            // 
            this.cONTRATOBindingSource1.DataMember = "CONTRATO";
            this.cONTRATOBindingSource1.DataSource = this.nmapagoBindingSource;
            // 
            // cONTRATOBindingSource2
            // 
            this.cONTRATOBindingSource2.DataMember = "CONTRATO";
            this.cONTRATOBindingSource2.DataSource = this.nmapago;
            // 
            // cONTRATOBindingSource3
            // 
            this.cONTRATOBindingSource3.DataMember = "CONTRATO";
            this.cONTRATOBindingSource3.DataSource = this.nmapagoBindingSource;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTRATOBindingSource4
            // 
            this.cONTRATOBindingSource4.DataMember = "CONTRATO";
            this.cONTRATOBindingSource4.DataSource = this.dataSet1;
            // 
            // cONTRATOTableAdapter1
            // 
            this.cONTRATOTableAdapter1.ClearBeforeFill = true;
            // 
            // btnNuevocontrato
            // 
            this.btnNuevocontrato.Location = new System.Drawing.Point(214, 325);
            this.btnNuevocontrato.Name = "btnNuevocontrato";
            this.btnNuevocontrato.Size = new System.Drawing.Size(125, 29);
            this.btnNuevocontrato.TabIndex = 1;
            this.btnNuevocontrato.Text = "Crear Contrato";
            this.btnNuevocontrato.UseVisualStyleBackColor = true;
            this.btnNuevocontrato.Click += new System.EventHandler(this.btnNuevocontrato_Click);
            // 
            // btnModificarcon
            // 
            this.btnModificarcon.Location = new System.Drawing.Point(427, 325);
            this.btnModificarcon.Name = "btnModificarcon";
            this.btnModificarcon.Size = new System.Drawing.Size(118, 29);
            this.btnModificarcon.TabIndex = 2;
            this.btnModificarcon.Text = "Modificar Contrato";
            this.btnModificarcon.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(621, 325);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Contrato";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cONTRATOTableAdapter2
            // 
            this.cONTRATOTableAdapter2.ClearBeforeFill = true;
            // 
            // cONTRATOBindingSource6
            // 
            this.cONTRATOBindingSource6.DataMember = "CONTRATO";
            this.cONTRATOBindingSource6.DataSource = this.nmapagoBindingSource;
            // 
            // cONTRATOBindingSource7
            // 
            this.cONTRATOBindingSource7.DataMember = "CONTRATO";
            this.cONTRATOBindingSource7.DataSource = this.nmapagoBindingSource;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 60);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Controlar Contratos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // FrmControlpago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarcon);
            this.Controls.Add(this.btnNuevocontrato);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControlpago";
            this.Text = "FrmControlpago";
            this.Load += new System.EventHandler(this.FrmControlpago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmapago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmapagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private nmapago nmapago;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource;
        private nmapagoTableAdapters.CONTRATOTableAdapter cONTRATOTableAdapter;
        private System.Windows.Forms.BindingSource nmapagoBindingSource;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource1;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource2;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource4;
        private DataSet1TableAdapters.CONTRATOTableAdapter cONTRATOTableAdapter1;
        private System.Windows.Forms.Button btnNuevocontrato;
        private System.Windows.Forms.Button btnModificarcon;
        private System.Windows.Forms.Button btnEliminar;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource5;
        private DataSet2TableAdapters.CONTRATOTableAdapter cONTRATOTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCONTRATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHATERMINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREEMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOSUSCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource6;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}