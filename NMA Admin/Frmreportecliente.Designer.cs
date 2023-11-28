namespace NMA_Admin
{
    partial class Frmreportecliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmreportecliente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetclient = new NMA_Admin.DataSetclient();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientes = new NMA_Admin.Clientes();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new NMA_Admin.ClientesTableAdapters.CLIENTETableAdapter();
            this.cLIENTETableAdapter1 = new NMA_Admin.DataSetclientTableAdapters.CLIENTETableAdapter();
            this.btnreportepdf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nmabd = new NMA_Admin.nmabd();
            this.nmabdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmabd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmabdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.nmabdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cLIENTEBindingSource1
            // 
            this.cLIENTEBindingSource1.DataMember = "CLIENTE";
            this.cLIENTEBindingSource1.DataSource = this.dataSetclient;
            // 
            // dataSetclient
            // 
            this.dataSetclient.DataSetName = "DataSetclient";
            this.dataSetclient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.clientes;
            // 
            // clientes
            // 
            this.clientes.DataSetName = "Clientes";
            this.clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = this.clientes;
            this.clientesBindingSource.Position = 0;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTETableAdapter1
            // 
            this.cLIENTETableAdapter1.ClearBeforeFill = true;
            // 
            // btnreportepdf
            // 
            this.btnreportepdf.Location = new System.Drawing.Point(345, 270);
            this.btnreportepdf.Name = "btnreportepdf";
            this.btnreportepdf.Size = new System.Drawing.Size(125, 32);
            this.btnreportepdf.TabIndex = 1;
            this.btnreportepdf.Text = "Generar Reporte PDF";
            this.btnreportepdf.UseVisualStyleBackColor = true;
            this.btnreportepdf.Click += new System.EventHandler(this.btnreportepdf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 60);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reportes de  Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::NMA_Admin.Properties.Resources.agregar_usuario__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // nmabd
            // 
            this.nmabd.DataSetName = "nmabd";
            this.nmabd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nmabdBindingSource
            // 
            this.nmabdBindingSource.DataSource = this.nmabd;
            this.nmabdBindingSource.Position = 0;
            // 
            // Frmreportecliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnreportepdf);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmreportecliente";
            this.Text = "Frmreportecliente";
            this.Load += new System.EventHandler(this.Frmreportecliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmabd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmabdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Clientes clientes;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private ClientesTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private DataSetclient dataSetclient;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource1;
        private DataSetclientTableAdapters.CLIENTETableAdapter cLIENTETableAdapter1;
        private System.Windows.Forms.Button btnreportepdf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource nmabdBindingSource;
        private nmabd nmabd;
    }
}