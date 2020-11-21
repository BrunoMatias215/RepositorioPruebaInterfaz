namespace WindowsFormsApp1.SeccionCaja
{
    partial class FormularioCaja
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
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCajaEfectivoInicial = new System.Windows.Forms.TextBox();
            this.BotonCrearCaja = new System.Windows.Forms.Button();
            this.BotonCerrarCaja = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(20, 274);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(121, 21);
            this.comboUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(675, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Efectivo Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Caja";
            // 
            // textBoxCajaEfectivoInicial
            // 
            this.textBoxCajaEfectivoInicial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCajaEfectivoInicial.Location = new System.Drawing.Point(174, 273);
            this.textBoxCajaEfectivoInicial.Name = "textBoxCajaEfectivoInicial";
            this.textBoxCajaEfectivoInicial.Size = new System.Drawing.Size(121, 22);
            this.textBoxCajaEfectivoInicial.TabIndex = 5;
            // 
            // BotonCrearCaja
            // 
            this.BotonCrearCaja.FlatAppearance.BorderSize = 0;
            this.BotonCrearCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCrearCaja.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearCaja.Location = new System.Drawing.Point(468, 254);
            this.BotonCrearCaja.Name = "BotonCrearCaja";
            this.BotonCrearCaja.Size = new System.Drawing.Size(105, 41);
            this.BotonCrearCaja.TabIndex = 6;
            this.BotonCrearCaja.Text = "Crear Caja";
            this.BotonCrearCaja.UseVisualStyleBackColor = true;
            this.BotonCrearCaja.Click += new System.EventHandler(this.BotonCrearCaja_Click);
            // 
            // BotonCerrarCaja
            // 
            this.BotonCerrarCaja.FlatAppearance.BorderSize = 0;
            this.BotonCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrarCaja.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarCaja.Location = new System.Drawing.Point(590, 254);
            this.BotonCerrarCaja.Name = "BotonCerrarCaja";
            this.BotonCerrarCaja.Size = new System.Drawing.Size(105, 41);
            this.BotonCerrarCaja.TabIndex = 7;
            this.BotonCerrarCaja.Text = "Cerrar Caja";
            this.BotonCerrarCaja.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BotonCerrarCaja);
            this.panel1.Controls.Add(this.comboUsuarios);
            this.panel1.Controls.Add(this.BotonCrearCaja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCajaEfectivoInicial);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 317);
            this.panel1.TabIndex = 8;
            // 
            // FormularioCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioCaja";
            this.Text = "FormularioCaja";
            this.Load += new System.EventHandler(this.FormularioCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCajaEfectivoInicial;
        private System.Windows.Forms.Button BotonCrearCaja;
        private System.Windows.Forms.Button BotonCerrarCaja;
        private System.Windows.Forms.Panel panel1;
    }
}