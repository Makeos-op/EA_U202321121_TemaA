namespace EA_U202321121_TemaA
{
    partial class FrmReportes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSeleccionReporte = new System.Windows.Forms.ComboBox();
            this.btnEjecutarReporte = new System.Windows.Forms.Button();
            this.dgvResultadosReporte = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEjecutarReporte);
            this.groupBox1.Controls.Add(this.cmbSeleccionReporte);
            this.groupBox1.Location = new System.Drawing.Point(53, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte";
            // 
            // cmbSeleccionReporte
            // 
            this.cmbSeleccionReporte.FormattingEnabled = true;
            this.cmbSeleccionReporte.Items.AddRange(new object[] {
            "Listar los platos especiales ordenándolos ascendentemente por su precio de venta",
            "Listar el o los platos especiales con el mayor número de ingredientes frescos",
            "Listar el o los platos de Cocina Peruana con ingredientes frescos que tienen una " +
                "cantidad disponible menor a 1 kg",
            "Listar el o los platos especiales con el menor número de ingredientes de tipo Pes" +
                "cado"});
            this.cmbSeleccionReporte.Location = new System.Drawing.Point(23, 31);
            this.cmbSeleccionReporte.Name = "cmbSeleccionReporte";
            this.cmbSeleccionReporte.Size = new System.Drawing.Size(479, 24);
            this.cmbSeleccionReporte.TabIndex = 0;
            // 
            // btnEjecutarReporte
            // 
            this.btnEjecutarReporte.Location = new System.Drawing.Point(529, 31);
            this.btnEjecutarReporte.Name = "btnEjecutarReporte";
            this.btnEjecutarReporte.Size = new System.Drawing.Size(112, 23);
            this.btnEjecutarReporte.TabIndex = 1;
            this.btnEjecutarReporte.Text = "button1";
            this.btnEjecutarReporte.UseVisualStyleBackColor = true;
            this.btnEjecutarReporte.Click += new System.EventHandler(this.btnEjecutarReporte_Click);
            // 
            // dgvResultadosReporte
            // 
            this.dgvResultadosReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosReporte.Location = new System.Drawing.Point(53, 133);
            this.dgvResultadosReporte.Name = "dgvResultadosReporte";
            this.dgvResultadosReporte.RowHeadersWidth = 51;
            this.dgvResultadosReporte.RowTemplate.Height = 24;
            this.dgvResultadosReporte.Size = new System.Drawing.Size(669, 305);
            this.dgvResultadosReporte.TabIndex = 1;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultadosReporte);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEjecutarReporte;
        private System.Windows.Forms.ComboBox cmbSeleccionReporte;
        private System.Windows.Forms.DataGridView dgvResultadosReporte;
    }
}