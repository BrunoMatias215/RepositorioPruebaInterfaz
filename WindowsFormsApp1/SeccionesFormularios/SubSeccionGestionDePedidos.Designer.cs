namespace SeccionesFormularios
{
    partial class SubSeccionGestionDePedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonModificarEstado = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BotonAsignarCadete = new System.Windows.Forms.Button();
            this.BotonVerDetallePedido = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 35);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(675, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedidos";
            // 
            // BotonModificarEstado
            // 
            this.BotonModificarEstado.FlatAppearance.BorderSize = 0;
            this.BotonModificarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonModificarEstado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonModificarEstado.Location = new System.Drawing.Point(165, 310);
            this.BotonModificarEstado.Name = "BotonModificarEstado";
            this.BotonModificarEstado.Size = new System.Drawing.Size(110, 42);
            this.BotonModificarEstado.TabIndex = 2;
            this.BotonModificarEstado.Text = "Modificar Pedido";
            this.BotonModificarEstado.UseVisualStyleBackColor = true;
            this.BotonModificarEstado.Click += new System.EventHandler(this.BotonModificarEstado_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cadete";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(302, 326);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // BotonAsignarCadete
            // 
            this.BotonAsignarCadete.FlatAppearance.BorderSize = 0;
            this.BotonAsignarCadete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAsignarCadete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAsignarCadete.Location = new System.Drawing.Point(456, 310);
            this.BotonAsignarCadete.Name = "BotonAsignarCadete";
            this.BotonAsignarCadete.Size = new System.Drawing.Size(110, 42);
            this.BotonAsignarCadete.TabIndex = 7;
            this.BotonAsignarCadete.Text = "Asignar Cadete";
            this.BotonAsignarCadete.UseVisualStyleBackColor = true;
            // 
            // BotonVerDetallePedido
            // 
            this.BotonVerDetallePedido.FlatAppearance.BorderSize = 0;
            this.BotonVerDetallePedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVerDetallePedido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerDetallePedido.Location = new System.Drawing.Point(583, 310);
            this.BotonVerDetallePedido.Name = "BotonVerDetallePedido";
            this.BotonVerDetallePedido.Size = new System.Drawing.Size(110, 42);
            this.BotonVerDetallePedido.TabIndex = 8;
            this.BotonVerDetallePedido.Text = "Ver Detalle Pedido";
            this.BotonVerDetallePedido.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BotonModificarEstado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BotonVerDetallePedido);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.BotonAsignarCadete);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 378);
            this.panel1.TabIndex = 9;
            // 
            // SubSeccionGestionDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 592);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubSeccionGestionDePedidos";
            this.Text = "SubSeccionGestionDePedidos";
            this.Load += new System.EventHandler(this.SubSeccionGestionDePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonModificarEstado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BotonAsignarCadete;
        private System.Windows.Forms.Button BotonVerDetallePedido;
        private System.Windows.Forms.Panel panel1;
    }
}