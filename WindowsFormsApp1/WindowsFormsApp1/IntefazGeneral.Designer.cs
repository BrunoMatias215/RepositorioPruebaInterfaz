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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazGeneral));
            this.MenuOpciones = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.BotonGestion = new System.Windows.Forms.Button();
            this.BotonCajas = new System.Windows.Forms.Button();
            this.BotonClientes = new System.Windows.Forms.Button();
            this.BotonPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelInterfaz = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuOpciones
            // 
            this.MenuOpciones.Controls.Add(this.label2);
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
            this.MenuOpciones.Size = new System.Drawing.Size(183, 673);
            this.MenuOpciones.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarSesion.Location = new System.Drawing.Point(12, 635);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(92, 26);
            this.BotonCerrarSesion.TabIndex = 5;
            this.BotonCerrarSesion.Text = "Cerrar Sesion";
            this.BotonCerrarSesion.UseVisualStyleBackColor = true;
            this.BotonCerrarSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // BotonGestion
            // 
            this.BotonGestion.FlatAppearance.BorderSize = 0;
            this.BotonGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonGestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGestion.Location = new System.Drawing.Point(12, 356);
            this.BotonGestion.Name = "BotonGestion";
            this.BotonGestion.Size = new System.Drawing.Size(141, 37);
            this.BotonGestion.TabIndex = 2;
            this.BotonGestion.Text = "Gestión";
            this.BotonGestion.UseVisualStyleBackColor = true;
            this.BotonGestion.Click += new System.EventHandler(this.BotonGestion_Click);
            // 
            // BotonCajas
            // 
            this.BotonCajas.FlatAppearance.BorderSize = 0;
            this.BotonCajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCajas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCajas.Location = new System.Drawing.Point(12, 313);
            this.BotonCajas.Name = "BotonCajas";
            this.BotonCajas.Size = new System.Drawing.Size(141, 37);
            this.BotonCajas.TabIndex = 4;
            this.BotonCajas.Text = "Caja";
            this.BotonCajas.UseVisualStyleBackColor = true;
            this.BotonCajas.Click += new System.EventHandler(this.BotonCajas_Click);
            // 
            // BotonClientes
            // 
            this.BotonClientes.FlatAppearance.BorderSize = 0;
            this.BotonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonClientes.Location = new System.Drawing.Point(12, 270);
            this.BotonClientes.Name = "BotonClientes";
            this.BotonClientes.Size = new System.Drawing.Size(141, 37);
            this.BotonClientes.TabIndex = 3;
            this.BotonClientes.Text = "Clientes";
            this.BotonClientes.UseVisualStyleBackColor = true;
            this.BotonClientes.Click += new System.EventHandler(this.BotonClientes_Click);
            // 
            // BotonPedidos
            // 
            this.BotonPedidos.FlatAppearance.BorderSize = 0;
            this.BotonPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPedidos.Location = new System.Drawing.Point(12, 227);
            this.BotonPedidos.Name = "BotonPedidos";
            this.BotonPedidos.Size = new System.Drawing.Size(141, 37);
            this.BotonPedidos.TabIndex = 0;
            this.BotonPedidos.Text = "Pedidos";
            this.BotonPedidos.UseVisualStyleBackColor = true;
            this.BotonPedidos.Click += new System.EventHandler(this.BotonPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // PanelInterfaz
            // 
            this.PanelInterfaz.Location = new System.Drawing.Point(183, 29);
            this.PanelInterfaz.Margin = new System.Windows.Forms.Padding(0);
            this.PanelInterfaz.Name = "PanelInterfaz";
            this.PanelInterfaz.Size = new System.Drawing.Size(1067, 644);
            this.PanelInterfaz.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(183, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 29);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1016, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1040, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InterfazGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelInterfaz);
            this.Controls.Add(this.MenuOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazGeneral";
            this.Text = "InterfazGeneral";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuOpciones.ResumeLayout(false);
            this.MenuOpciones.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

