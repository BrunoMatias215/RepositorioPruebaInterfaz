namespace WindowsFormsApp1.SeccionClientes
{
    partial class FormularioClientes
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelBúsquedaClientes = new System.Windows.Forms.Label();
            this.BotonNuevoCliente = new System.Windows.Forms.Button();
            this.BotonModificarCliente = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.labelPedido = new System.Windows.Forms.Label();
            this.labelDetallePedido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(145, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(668, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // labelBúsquedaClientes
            // 
            this.labelBúsquedaClientes.AutoSize = true;
            this.labelBúsquedaClientes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBúsquedaClientes.Location = new System.Drawing.Point(16, 23);
            this.labelBúsquedaClientes.Name = "labelBúsquedaClientes";
            this.labelBúsquedaClientes.Size = new System.Drawing.Size(119, 13);
            this.labelBúsquedaClientes.TabIndex = 2;
            this.labelBúsquedaClientes.Text = "Búsqueda de Clientes";
            // 
            // BotonNuevoCliente
            // 
            this.BotonNuevoCliente.FlatAppearance.BorderSize = 0;
            this.BotonNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNuevoCliente.Location = new System.Drawing.Point(19, 224);
            this.BotonNuevoCliente.Name = "BotonNuevoCliente";
            this.BotonNuevoCliente.Size = new System.Drawing.Size(120, 37);
            this.BotonNuevoCliente.TabIndex = 3;
            this.BotonNuevoCliente.Text = "Nuevo Cliente";
            this.BotonNuevoCliente.UseVisualStyleBackColor = true;
            this.BotonNuevoCliente.Click += new System.EventHandler(this.BotonNuevoCliente_Click);
            // 
            // BotonModificarCliente
            // 
            this.BotonModificarCliente.FlatAppearance.BorderSize = 0;
            this.BotonModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonModificarCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonModificarCliente.Location = new System.Drawing.Point(145, 224);
            this.BotonModificarCliente.Name = "BotonModificarCliente";
            this.BotonModificarCliente.Size = new System.Drawing.Size(120, 37);
            this.BotonModificarCliente.TabIndex = 4;
            this.BotonModificarCliente.Text = "Modificar Cliente";
            this.BotonModificarCliente.UseVisualStyleBackColor = true;
            this.BotonModificarCliente.Click += new System.EventHandler(this.BotonModificarCliente_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 45;
            this.dataGridView2.Size = new System.Drawing.Size(668, 141);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(19, 468);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 45;
            this.dataGridView3.Size = new System.Drawing.Size(668, 141);
            this.dataGridView3.TabIndex = 7;
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedido.Location = new System.Drawing.Point(16, 275);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(43, 15);
            this.labelPedido.TabIndex = 8;
            this.labelPedido.Text = "Pedido";
            // 
            // labelDetallePedido
            // 
            this.labelDetallePedido.AutoSize = true;
            this.labelDetallePedido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetallePedido.Location = new System.Drawing.Point(16, 452);
            this.labelDetallePedido.Name = "labelDetallePedido";
            this.labelDetallePedido.Size = new System.Drawing.Size(82, 13);
            this.labelDetallePedido.TabIndex = 9;
            this.labelDetallePedido.Text = "Detalle Pedido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelBúsquedaClientes);
            this.panel1.Controls.Add(this.labelDetallePedido);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelPedido);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.BotonNuevoCliente);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.BotonModificarCliente);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 626);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(145, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 1);
            this.panel2.TabIndex = 11;
            // 
            // FormularioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioClientes";
            this.Text = "FormularioClientes";
            this.Load += new System.EventHandler(this.FormularioClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelBúsquedaClientes;
        private System.Windows.Forms.Button BotonNuevoCliente;
        private System.Windows.Forms.Button BotonModificarCliente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Label labelDetallePedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}