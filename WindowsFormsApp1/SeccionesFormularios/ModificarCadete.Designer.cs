namespace SeccionesFormularios
{
    partial class ModificarCadete
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
            this.labelid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.textlicencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.texttelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(89, 33);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 62;
            this.labelid.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "ID Cadete";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(138, 313);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(79, 35);
            this.botonCancelar.TabIndex = 60;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(31, 313);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(79, 35);
            this.BotonAceptar.TabIndex = 59;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // textlicencia
            // 
            this.textlicencia.Location = new System.Drawing.Point(31, 264);
            this.textlicencia.Name = "textlicencia";
            this.textlicencia.Size = new System.Drawing.Size(186, 20);
            this.textlicencia.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Licencia";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(31, 145);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(186, 20);
            this.textApellido.TabIndex = 56;
            // 
            // texttelefono
            // 
            this.texttelefono.Location = new System.Drawing.Point(31, 204);
            this.texttelefono.Name = "texttelefono";
            this.texttelefono.Size = new System.Drawing.Size(186, 20);
            this.texttelefono.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Apellido";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(31, 88);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(186, 20);
            this.textNombre.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre";
            // 
            // ModificarCadete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 379);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.textlicencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.texttelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModificarCadete";
            this.Text = "Modificar Cadete";
            this.Load += new System.EventHandler(this.ModificarCadete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.TextBox textlicencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox texttelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
    }
}