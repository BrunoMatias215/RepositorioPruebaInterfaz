namespace WindowsFormsApp1.SeccionGestión
{
    partial class FormularioGestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonDiario = new System.Windows.Forms.RadioButton();
            this.radioButtonMensual = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.comboBoxAño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonVerPedidos = new System.Windows.Forms.Button();
            this.BotonVerProductos = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.BotonGenerarReporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonPersonal = new System.Windows.Forms.Button();
            this.BotonProductos = new System.Windows.Forms.Button();
            this.BotonInformes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // radioButtonDiario
            // 
            this.radioButtonDiario.AutoSize = true;
            this.radioButtonDiario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDiario.Location = new System.Drawing.Point(24, 196);
            this.radioButtonDiario.Name = "radioButtonDiario";
            this.radioButtonDiario.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDiario.TabIndex = 2;
            this.radioButtonDiario.TabStop = true;
            this.radioButtonDiario.Text = "Diario";
            this.radioButtonDiario.UseVisualStyleBackColor = true;
            // 
            // radioButtonMensual
            // 
            this.radioButtonMensual.AutoSize = true;
            this.radioButtonMensual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMensual.Location = new System.Drawing.Point(24, 239);
            this.radioButtonMensual.Name = "radioButtonMensual";
            this.radioButtonMensual.Size = new System.Drawing.Size(69, 17);
            this.radioButtonMensual.TabIndex = 3;
            this.radioButtonMensual.TabStop = true;
            this.radioButtonMensual.Text = "Mensual";
            this.radioButtonMensual.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Location = new System.Drawing.Point(118, 234);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMes.TabIndex = 5;
            // 
            // comboBoxAño
            // 
            this.comboBoxAño.FormattingEnabled = true;
            this.comboBoxAño.Location = new System.Drawing.Point(265, 234);
            this.comboBoxAño.Name = "comboBoxAño";
            this.comboBoxAño.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAño.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // BotonVerPedidos
            // 
            this.BotonVerPedidos.FlatAppearance.BorderSize = 0;
            this.BotonVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVerPedidos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerPedidos.Location = new System.Drawing.Point(415, 215);
            this.BotonVerPedidos.Name = "BotonVerPedidos";
            this.BotonVerPedidos.Size = new System.Drawing.Size(114, 41);
            this.BotonVerPedidos.TabIndex = 8;
            this.BotonVerPedidos.Text = "Ver Pedidos";
            this.BotonVerPedidos.UseVisualStyleBackColor = true;
            // 
            // BotonVerProductos
            // 
            this.BotonVerProductos.FlatAppearance.BorderSize = 0;
            this.BotonVerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVerProductos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerProductos.Location = new System.Drawing.Point(631, 477);
            this.BotonVerProductos.Name = "BotonVerProductos";
            this.BotonVerProductos.Size = new System.Drawing.Size(114, 41);
            this.BotonVerProductos.TabIndex = 17;
            this.BotonVerProductos.Text = "Ver Productos";
            this.BotonVerProductos.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 497);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(687, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 497);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Productos";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(24, 502);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mensual";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(24, 459);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Diario";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(721, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mes";
            // 
            // BotonGenerarReporte
            // 
            this.BotonGenerarReporte.FlatAppearance.BorderSize = 0;
            this.BotonGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGenerarReporte.Location = new System.Drawing.Point(551, 215);
            this.BotonGenerarReporte.Name = "BotonGenerarReporte";
            this.BotonGenerarReporte.Size = new System.Drawing.Size(114, 41);
            this.BotonGenerarReporte.TabIndex = 19;
            this.BotonGenerarReporte.Text = "Generar Reporte";
            this.BotonGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.BotonPersonal);
            this.panel1.Controls.Add(this.BotonProductos);
            this.panel1.Controls.Add(this.BotonInformes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 52);
            this.panel1.TabIndex = 20;
            // 
            // BotonPersonal
            // 
            this.BotonPersonal.FlatAppearance.BorderSize = 0;
            this.BotonPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPersonal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPersonal.Location = new System.Drawing.Point(213, 7);
            this.BotonPersonal.Name = "BotonPersonal";
            this.BotonPersonal.Size = new System.Drawing.Size(96, 40);
            this.BotonPersonal.TabIndex = 2;
            this.BotonPersonal.Text = "Personal";
            this.BotonPersonal.UseVisualStyleBackColor = true;
            // 
            // BotonProductos
            // 
            this.BotonProductos.FlatAppearance.BorderSize = 0;
            this.BotonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonProductos.Location = new System.Drawing.Point(111, 7);
            this.BotonProductos.Name = "BotonProductos";
            this.BotonProductos.Size = new System.Drawing.Size(96, 40);
            this.BotonProductos.TabIndex = 1;
            this.BotonProductos.Text = "Productos";
            this.BotonProductos.UseVisualStyleBackColor = true;
            // 
            // BotonInformes
            // 
            this.BotonInformes.FlatAppearance.BorderSize = 0;
            this.BotonInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonInformes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInformes.Location = new System.Drawing.Point(9, 7);
            this.BotonInformes.Name = "BotonInformes";
            this.BotonInformes.Size = new System.Drawing.Size(96, 40);
            this.BotonInformes.TabIndex = 0;
            this.BotonInformes.Text = "Informes";
            this.BotonInformes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BotonVerProductos);
            this.panel2.Controls.Add(this.BotonGenerarReporte);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.radioButtonDiario);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.radioButtonMensual);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.comboBoxMes);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.comboBoxAño);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BotonVerPedidos);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 543);
            this.panel2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Año";
            // 
            // FormularioGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioGestion";
            this.Text = "FormularioGestion";
            this.Load += new System.EventHandler(this.FormularioGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonDiario;
        private System.Windows.Forms.RadioButton radioButtonMensual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.ComboBox comboBoxAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonVerPedidos;
        private System.Windows.Forms.Button BotonVerProductos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BotonGenerarReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonProductos;
        private System.Windows.Forms.Button BotonInformes;
        private System.Windows.Forms.Button BotonPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}