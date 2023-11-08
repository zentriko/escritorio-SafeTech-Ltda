namespace NMA_Admin
{
    partial class FrmMantencionPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantencionPro));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPECIALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRASENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFESIONALBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nmabda = new NMA_Admin.nmabda();
            this.pROFESIONALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProfesional = new NMA_Admin.DBProfesional();
            this.pROFESIONALTableAdapter = new NMA_Admin.DBProfesionalTableAdapters.PROFESIONALTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregarPro = new System.Windows.Forms.Button();
            this.pROFESIONALTableAdapter1 = new NMA_Admin.nmabdaTableAdapters.PROFESIONALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESIONALBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmabda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESIONALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.eSPECIALIDADDataGridViewTextBoxColumn,
            this.uSUARIODataGridViewTextBoxColumn,
            this.cONTRASENADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROFESIONALBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(150, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 279);
            this.dataGridView1.TabIndex = 8;
     
            // 
            // iDPRODataGridViewTextBoxColumn
            // 
            this.iDPRODataGridViewTextBoxColumn.DataPropertyName = "ID_PRO";
            this.iDPRODataGridViewTextBoxColumn.HeaderText = "ID_PRO";
            this.iDPRODataGridViewTextBoxColumn.Name = "iDPRODataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            // 
            // eSPECIALIDADDataGridViewTextBoxColumn
            // 
            this.eSPECIALIDADDataGridViewTextBoxColumn.DataPropertyName = "ESPECIALIDAD";
            this.eSPECIALIDADDataGridViewTextBoxColumn.HeaderText = "ESPECIALIDAD";
            this.eSPECIALIDADDataGridViewTextBoxColumn.Name = "eSPECIALIDADDataGridViewTextBoxColumn";
            // 
            // uSUARIODataGridViewTextBoxColumn
            // 
            this.uSUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.Name = "uSUARIODataGridViewTextBoxColumn";
            // 
            // cONTRASENADataGridViewTextBoxColumn
            // 
            this.cONTRASENADataGridViewTextBoxColumn.DataPropertyName = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.HeaderText = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.Name = "cONTRASENADataGridViewTextBoxColumn";
            // 
            // pROFESIONALBindingSource1
            // 
            this.pROFESIONALBindingSource1.DataMember = "PROFESIONAL";
            this.pROFESIONALBindingSource1.DataSource = this.nmabda;
            // 
            // nmabda
            // 
            this.nmabda.DataSetName = "nmabda";
            this.nmabda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFESIONALBindingSource
            // 
            this.pROFESIONALBindingSource.DataMember = "PROFESIONAL";
            this.pROFESIONALBindingSource.DataSource = this.dBProfesional;
            // 
            // dBProfesional
            // 
            this.dBProfesional.DataSetName = "DBProfesional";
            this.dBProfesional.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFESIONALTableAdapter
            // 
            this.pROFESIONALTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de Profesionales";
         
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Image = global::NMA_Admin.Properties.Resources.boton_eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(599, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(180, 62);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "        Eliminar Profesional";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Image = global::NMA_Admin.Properties.Resources.lapiz;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(371, 346);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(180, 62);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "        Editar  Profesional";
            this.btnEditar.UseVisualStyleBackColor = true;
            
            // 
            // btnAgregarPro
            // 
            this.btnAgregarPro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarPro.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPro.Image")));
            this.btnAgregarPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPro.Location = new System.Drawing.Point(135, 346);
            this.btnAgregarPro.Name = "btnAgregarPro";
            this.btnAgregarPro.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAgregarPro.Size = new System.Drawing.Size(180, 62);
            this.btnAgregarPro.TabIndex = 5;
            this.btnAgregarPro.Text = "          Agregar Profesional";
            this.btnAgregarPro.UseVisualStyleBackColor = true;
            this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
            // 
            // pROFESIONALTableAdapter1
            // 
            this.pROFESIONALTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmMantencionPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregarPro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantencionPro";
            this.Text = "FrmMantencionPro";
            this.Load += new System.EventHandler(this.FrmMantencionPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESIONALBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmabda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESIONALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBProfesional dBProfesional;
        private System.Windows.Forms.BindingSource pROFESIONALBindingSource;
        private DBProfesionalTableAdapters.PROFESIONALTableAdapter pROFESIONALTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPECIALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASENADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private nmabda nmabda;
        private System.Windows.Forms.BindingSource pROFESIONALBindingSource1;
        private nmabdaTableAdapters.PROFESIONALTableAdapter pROFESIONALTableAdapter1;
    }
}