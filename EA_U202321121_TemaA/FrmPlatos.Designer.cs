namespace EA_U202321121_TemaA
{
    partial class FrmPlatos
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
            this.cmbTipoPlato = new System.Windows.Forms.ComboBox();
            this.txtPrecioPlato = new System.Windows.Forms.TextBox();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.txtCodigoPlato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnRegistrarPlato = new System.Windows.Forms.Button();
            this.dgvListadoPlatos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoPlato);
            this.groupBox1.Controls.Add(this.txtPrecioPlato);
            this.groupBox1.Controls.Add(this.txtNombrePlato);
            this.groupBox1.Controls.Add(this.txtCodigoPlato);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTipoPlato
            // 
            this.cmbTipoPlato.FormattingEnabled = true;
            this.cmbTipoPlato.Items.AddRange(new object[] {
            "Peruana",
            "Internacional",
            "Fusión",
            "Vegetariana"});
            this.cmbTipoPlato.Location = new System.Drawing.Point(73, 89);
            this.cmbTipoPlato.Name = "cmbTipoPlato";
            this.cmbTipoPlato.Size = new System.Drawing.Size(236, 24);
            this.cmbTipoPlato.TabIndex = 8;
            // 
            // txtPrecioPlato
            // 
            this.txtPrecioPlato.Location = new System.Drawing.Point(73, 119);
            this.txtPrecioPlato.Name = "txtPrecioPlato";
            this.txtPrecioPlato.Size = new System.Drawing.Size(236, 22);
            this.txtPrecioPlato.TabIndex = 7;
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Location = new System.Drawing.Point(73, 61);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(236, 22);
            this.txtNombrePlato.TabIndex = 5;
            // 
            // txtCodigoPlato
            // 
            this.txtCodigoPlato.Location = new System.Drawing.Point(73, 33);
            this.txtCodigoPlato.Name = "txtCodigoPlato";
            this.txtCodigoPlato.Size = new System.Drawing.Size(236, 22);
            this.txtCodigoPlato.TabIndex = 4;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIngredientes);
            this.groupBox2.Controls.Add(this.btnRegistrarPlato);
            this.groupBox2.Location = new System.Drawing.Point(465, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Location = new System.Drawing.Point(62, 76);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(100, 23);
            this.btnIngredientes.TabIndex = 1;
            this.btnIngredientes.Text = "button2";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnRegistrarPlato
            // 
            this.btnRegistrarPlato.Location = new System.Drawing.Point(62, 47);
            this.btnRegistrarPlato.Name = "btnRegistrarPlato";
            this.btnRegistrarPlato.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrarPlato.TabIndex = 0;
            this.btnRegistrarPlato.Text = "button1";
            this.btnRegistrarPlato.UseVisualStyleBackColor = true;
            this.btnRegistrarPlato.Click += new System.EventHandler(this.btnRegistrarPlato_Click);
            // 
            // dgvListadoPlatos
            // 
            this.dgvListadoPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPlatos.Location = new System.Drawing.Point(29, 230);
            this.dgvListadoPlatos.Name = "dgvListadoPlatos";
            this.dgvListadoPlatos.RowHeadersWidth = 51;
            this.dgvListadoPlatos.RowTemplate.Height = 24;
            this.dgvListadoPlatos.Size = new System.Drawing.Size(673, 208);
            this.dgvListadoPlatos.TabIndex = 2;
            // 
            // FrmPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.dgvListadoPlatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPlatos";
            this.Text = "FrmPlatos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPlatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoPlato;
        private System.Windows.Forms.TextBox txtPrecioPlato;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.TextBox txtCodigoPlato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnRegistrarPlato;
        private System.Windows.Forms.DataGridView dgvListadoPlatos;
    }
}