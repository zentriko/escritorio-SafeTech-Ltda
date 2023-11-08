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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDACTIVIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividades = new NMA_Admin.Actividades();
            this.aCTIVIDADTableAdapter = new NMA_Admin.ActividadesTableAdapters.ACTIVIDADTableAdapter();
            this.act1 = new NMA_Admin.act1();
            this.aCTIVIDADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aCTIVIDADTableAdapter1 = new NMA_Admin.act1TableAdapters.ACTIVIDADTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDACTIVIDADDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.nOMBREACTDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCTIVIDADBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(46, 155);
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
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // nOMBREACTDataGridViewTextBoxColumn
            // 
            this.nOMBREACTDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_ACT";
            this.nOMBREACTDataGridViewTextBoxColumn.HeaderText = "NOMBRE_ACT";
            this.nOMBREACTDataGridViewTextBoxColumn.Name = "nOMBREACTDataGridViewTextBoxColumn";
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
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
            // act1
            // 
            this.act1.DataSetName = "act1";
            this.act1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCTIVIDADBindingSource1
            // 
            this.aCTIVIDADBindingSource1.DataMember = "ACTIVIDAD";
            this.aCTIVIDADBindingSource1.DataSource = this.act1;
            // 
            // aCTIVIDADTableAdapter1
            // 
            this.aCTIVIDADTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 499);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActividades";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.FrmActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVIDADBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Actividades actividades;
        private System.Windows.Forms.BindingSource aCTIVIDADBindingSource;
        private ActividadesTableAdapters.ACTIVIDADTableAdapter aCTIVIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDACTIVIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private act1 act1;
        private System.Windows.Forms.BindingSource aCTIVIDADBindingSource1;
        private act1TableAdapters.ACTIVIDADTableAdapter aCTIVIDADTableAdapter1;
    }
}