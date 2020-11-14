namespace WindowsFormsApp1
{
    partial class InterfazGeneral
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuOpciones = new System.Windows.Forms.Panel();
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.BotonGestion = new System.Windows.Forms.Button();
            this.BotonCajas = new System.Windows.Forms.Button();
            this.BotonClientes = new System.Windows.Forms.Button();
            this.BotonPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelInterfaz = new System.Windows.Forms.Panel();
            this.MenuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOpciones
            // 
            this.MenuOpciones.Controls.Add(this.BotonCerrarSesion);
            this.MenuOpciones.Controls.Add(this.BotonGestion);
            this.MenuOpciones.Controls.Add(this.BotonCajas);
            this.MenuOpciones.Controls.Add(this.BotonClientes);
            this.MenuOpciones.Controls.Add(this.BotonPedidos);
            this.MenuOpciones.Controls.Add(this.label1);
            this.MenuOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuOpciones.Location = new System.Drawing.Point(0, 0);
            this.MenuOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.MenuOpciones.Name = "MenuOpciones";
            this.MenuOpciones.Size = new System.Drawing.Size(183, 729);
            this.MenuOpciones.TabIndex = 1;
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.Location = new System.Drawing.Point(35, 690);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(111, 27);
            this.BotonCerrarSesion.TabIndex = 5;
            this.BotonCerrarSesion.Text = "Cerrar Sesion";
            this.BotonCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // BotonGestion
            // 
            this.BotonGestion.Location = new System.Drawing.Point(12, 288);
            this.BotonGestion.Name = "BotonGestion";
            this.BotonGestion.Size = new System.Drawing.Size(162, 37);
            this.BotonGestion.TabIndex = 2;
            this.BotonGestion.Text = "Gestion";
            this.BotonGestion.UseVisualStyleBackColor = true;
            this.BotonGestion.Click += new System.EventHandler(this.BotonGestion_Click);
            // 
            // BotonCajas
            // 
            this.BotonCajas.Location = new System.Drawing.Point(12, 245);
            this.BotonCajas.Name = "BotonCajas";
            this.BotonCajas.Size = new System.Drawing.Size(162, 37);
            this.BotonCajas.TabIndex = 4;
            this.BotonCajas.Text = "Caja";
            this.BotonCajas.UseVisualStyleBackColor = true;
            this.BotonCajas.Click += new System.EventHandler(this.BotonCajas_Click);
            // 
            // BotonClientes
            // 
            this.BotonClientes.Location = new System.Drawing.Point(12, 202);
            this.BotonClientes.Name = "BotonClientes";
            this.BotonClientes.Size = new System.Drawing.Size(162, 37);
            this.BotonClientes.TabIndex = 3;
            this.BotonClientes.Text = "Clientes";
            this.BotonClientes.UseVisualStyleBackColor = true;
            this.BotonClientes.Click += new System.EventHandler(this.BotonClientes_Click);
            // 
            // BotonPedidos
            // 
            this.BotonPedidos.Location = new System.Drawing.Point(12, 159);
            this.BotonPedidos.Name = "BotonPedidos";
            this.BotonPedidos.Size = new System.Drawing.Size(162, 37);
            this.BotonPedidos.TabIndex = 0;
            this.BotonPedidos.Text = "Pedidos";
            this.BotonPedidos.UseVisualStyleBackColor = true;
            this.BotonPedidos.Click += new System.EventHandler(this.BotonPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Usuario [Rol]";
            // 
            // PanelInterfaz
            // 
            this.PanelInterfaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInterfaz.Location = new System.Drawing.Point(183, 0);
            this.PanelInterfaz.Margin = new System.Windows.Forms.Padding(0);
            this.PanelInterfaz.Name = "PanelInterfaz";
            this.PanelInterfaz.Size = new System.Drawing.Size(1167, 729);
            this.PanelInterfaz.TabIndex = 2;
            // 
            // InterfazGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.PanelInterfaz);
            this.Controls.Add(this.MenuOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazGeneral";
            this.Text = "InterfazGeneral";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuOpciones.ResumeLayout(false);
            this.MenuOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuOpciones;
        private System.Windows.Forms.Button BotonCerrarSesion;
        private System.Windows.Forms.Button BotonClientes;
        private System.Windows.Forms.Button BotonGestion;
        private System.Windows.Forms.Button BotonCajas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonPedidos;
        private System.Windows.Forms.Panel PanelInterfaz;
    }
}

