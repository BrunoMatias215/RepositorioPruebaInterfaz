namespace WindowsFormsApp1
{
    partial class FormularioPedidos
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
            this.BarraHerramientas = new System.Windows.Forms.Panel();
            this.BotonGestionDePedido = new System.Windows.Forms.Button();
            this.BotonCrearPedido = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.BackColor = System.Drawing.SystemColors.Control;
            this.BarraHerramientas.Controls.Add(this.BotonGestionDePedido);
            this.BarraHerramientas.Controls.Add(this.BotonCrearPedido);
            this.BarraHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Margin = new System.Windows.Forms.Padding(0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(1067, 52);
            this.BarraHerramientas.TabIndex = 0;
            // 
            // BotonGestionDePedido
            // 
            this.BotonGestionDePedido.FlatAppearance.BorderSize = 0;
            this.BotonGestionDePedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonGestionDePedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGestionDePedido.Location = new System.Drawing.Point(163, 7);
            this.BotonGestionDePedido.Name = "BotonGestionDePedido";
            this.BotonGestionDePedido.Size = new System.Drawing.Size(145, 40);
            this.BotonGestionDePedido.TabIndex = 1;
            this.BotonGestionDePedido.Text = "Gestión de Pedido";
            this.BotonGestionDePedido.UseVisualStyleBackColor = true;
            this.BotonGestionDePedido.Click += new System.EventHandler(this.button2_Click);
            // 
            // BotonCrearPedido
            // 
            this.BotonCrearPedido.FlatAppearance.BorderSize = 0;
            this.BotonCrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCrearPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearPedido.Location = new System.Drawing.Point(12, 7);
            this.BotonCrearPedido.Name = "BotonCrearPedido";
            this.BotonCrearPedido.Size = new System.Drawing.Size(145, 40);
            this.BotonCrearPedido.TabIndex = 0;
            this.BotonCrearPedido.Text = "Crear Pedido";
            this.BotonCrearPedido.UseVisualStyleBackColor = true;
            this.BotonCrearPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 592);
            this.panel2.TabIndex = 1;
            // 
            // FormularioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraHerramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPedidos";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.BarraHerramientas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BotonGestionDePedido;
        private System.Windows.Forms.Button BotonCrearPedido;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel BarraHerramientas;
    }
}