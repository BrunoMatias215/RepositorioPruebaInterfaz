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
            this.BotonEliminarCliente = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelBúsquedaClientes
            // 
            this.labelBúsquedaClientes.AutoSize = true;
            this.labelBúsquedaClientes.Location = new System.Drawing.Point(16, 15);
            this.labelBúsquedaClientes.Name = "labelBúsquedaClientes";
            this.labelBúsquedaClientes.Size = new System.Drawing.Size(110, 13);
            this.labelBúsquedaClientes.TabIndex = 2;
            this.labelBúsquedaClientes.Text = "Búsqueda de Clientes";
            // 
            // BotonNuevoCliente
            // 
            this.BotonNuevoCliente.Location = new System.Drawing.Point(19, 207);
            this.BotonNuevoCliente.Name = "BotonNuevoCliente";
            this.BotonNuevoCliente.Size = new System.Drawing.Size(94, 37);
            this.BotonNuevoCliente.TabIndex = 3;
            this.BotonNuevoCliente.Text = "Nuevo Cliente";
            this.BotonNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // BotonModificarCliente
            // 
            this.BotonModificarCliente.Location = new System.Drawing.Point(119, 207);
            this.BotonModificarCliente.Name = "BotonModificarCliente";
            this.BotonModificarCliente.Size = new System.Drawing.Size(94, 37);
            this.BotonModificarCliente.TabIndex = 4;
            this.BotonModificarCliente.Text = "Modificar Cliente";
            this.BotonModificarCliente.UseVisualStyleBackColor = true;
            // 
            // BotonEliminarCliente
            // 
            this.BotonEliminarCliente.Location = new System.Drawing.Point(219, 207);
            this.BotonEliminarCliente.Name = "BotonEliminarCliente";
            this.BotonEliminarCliente.Size = new System.Drawing.Size(94, 37);
            this.BotonEliminarCliente.TabIndex = 5;
            this.BotonEliminarCliente.Text = "Eliminar Cliente";
            this.BotonEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(705, 141);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(19, 474);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(705, 141);
            this.dataGridView3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Detalle Pedido";
            // 
            // FormularioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BotonEliminarCliente);
            this.Controls.Add(this.BotonModificarCliente);
            this.Controls.Add(this.BotonNuevoCliente);
            this.Controls.Add(this.labelBúsquedaClientes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioClientes";
            this.Text = "FormularioClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelBúsquedaClientes;
        private System.Windows.Forms.Button BotonNuevoCliente;
        private System.Windows.Forms.Button BotonModificarCliente;
        private System.Windows.Forms.Button BotonEliminarCliente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}