namespace EA_U202321121_TemaA
{
    partial class FrmIngredientes
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
            this.dgvListadoIngredientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarIngrediente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoIngrediente = new System.Windows.Forms.ComboBox();
            this.txtCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.txtNombreIngrediente = new System.Windows.Forms.TextBox();
            this.txtCodigoIngrediente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoIngredientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoIngredientes
            // 
            this.dgvListadoIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoIngredientes.Location = new System.Drawing.Point(65, 216);
            this.dgvListadoIngredientes.Name = "dgvListadoIngredientes";
            this.dgvListadoIngredientes.RowHeadersWidth = 51;
            this.dgvListadoIngredientes.RowTemplate.Height = 24;
            this.dgvListadoIngredientes.Size = new System.Drawing.Size(673, 208);
            this.dgvListadoIngredientes.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrarIngrediente);
            this.groupBox2.Location = new System.Drawing.Point(501, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // btnRegistrarIngrediente
            // 
            this.btnRegistrarIngrediente.Location = new System.Drawing.Point(62, 47);
            this.btnRegistrarIngrediente.Name = "btnRegistrarIngrediente";
            this.btnRegistrarIngrediente.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrarIngrediente.TabIndex = 0;
            this.btnRegistrarIngrediente.Text = "button1";
            this.btnRegistrarIngrediente.UseVisualStyleBackColor = true;
            this.btnRegistrarIngrediente.Click += new System.EventHandler(this.btnRegistrarIngrediente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoIngrediente);
            this.groupBox1.Controls.Add(this.txtCantidadIngrediente);
            this.groupBox1.Controls.Add(this.txtNombreIngrediente);
            this.groupBox1.Controls.Add(this.txtCodigoIngrediente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cmbTipoIngrediente
            // 
            this.cmbTipoIngrediente.FormattingEnabled = true;
            this.cmbTipoIngrediente.Items.AddRange(new object[] {
            "Vegetal",
            "Carne",
            "Pescado",
            "Lácteo",
            "Fruta",
            "Otros"});
            this.cmbTipoIngrediente.Location = new System.Drawing.Point(73, 89);
            this.cmbTipoIngrediente.Name = "cmbTipoIngrediente";
            this.cmbTipoIngrediente.Size = new System.Drawing.Size(236, 24);
            this.cmbTipoIngrediente.TabIndex = 8;
            // 
            // txtCantidadIngrediente
            // 
            this.txtCantidadIngrediente.Location = new System.Drawing.Point(73, 119);
            this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
            this.txtCantidadIngrediente.Size = new System.Drawing.Size(236, 22);
            this.txtCantidadIngrediente.TabIndex = 7;
            // 
            // txtNombreIngrediente
            // 
            this.txtNombreIngrediente.Location = new System.Drawing.Point(73, 61);
            this.txtNombreIngrediente.Name = "txtNombreIngrediente";
            this.txtNombreIngrediente.Size = new System.Drawing.Size(236, 22);
            this.txtNombreIngrediente.TabIndex = 5;
            // 
            // txtCodigoIngrediente
            // 
            this.txtCodigoIngrediente.Location = new System.Drawing.Point(73, 33);
            this.txtCodigoIngrediente.Name = "txtCodigoIngrediente";
            this.txtCodigoIngrediente.Size = new System.Drawing.Size(236, 22);
            this.txtCodigoIngrediente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FrmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListadoIngredientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmIngredientes";
            this.Text = "FrmIngredientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoIngredientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoIngredientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrarIngrediente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoIngrediente;
        private System.Windows.Forms.TextBox txtCantidadIngrediente;
        private System.Windows.Forms.TextBox txtNombreIngrediente;
        private System.Windows.Forms.TextBox txtCodigoIngrediente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}