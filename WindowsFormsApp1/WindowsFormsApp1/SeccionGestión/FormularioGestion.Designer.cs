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
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.BotonPersonal = new System.Windows.Forms.Button();
            this.BotonProductos = new System.Windows.Forms.Button();
            this.BotonInformes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BarraSuperior.Controls.Add(this.BotonPersonal);
            this.BarraSuperior.Controls.Add(this.BotonProductos);
            this.BarraSuperior.Controls.Add(this.BotonInformes);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1067, 52);
            this.BarraSuperior.TabIndex = 20;
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
            this.BotonPersonal.Click += new System.EventHandler(this.BotonPersonal_Click);
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
            this.BotonProductos.Click += new System.EventHandler(this.BotonProductos_Click);
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
            this.BotonInformes.Click += new System.EventHandler(this.BotonInformes_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 592);
            this.panel2.TabIndex = 21;
            // 
            // FormularioGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioGestion";
            this.Text = "FormularioGestion";
            this.Load += new System.EventHandler(this.FormularioGestion_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Button BotonProductos;
        private System.Windows.Forms.Button BotonInformes;
        private System.Windows.Forms.Button BotonPersonal;
        private System.Windows.Forms.Panel panel2;
    }
}