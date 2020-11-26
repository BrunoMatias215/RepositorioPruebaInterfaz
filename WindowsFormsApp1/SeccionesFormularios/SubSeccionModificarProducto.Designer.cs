namespace SeccionesFormularios
{
    partial class SubSeccionModificarProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.combocategoria = new System.Windows.Forms.ComboBox();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(26, 79);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(186, 20);
            this.textnombre.TabIndex = 3;
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(26, 202);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(186, 20);
            this.textprecio.TabIndex = 4;
            // 
            // combocategoria
            // 
            this.combocategoria.FormattingEnabled = true;
            this.combocategoria.Location = new System.Drawing.Point(26, 139);
            this.combocategoria.Name = "combocategoria";
            this.combocategoria.Size = new System.Drawing.Size(186, 21);
            this.combocategoria.TabIndex = 5;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(26, 251);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(79, 35);
            this.BotonAceptar.TabIndex = 6;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(133, 251);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(79, 35);
            this.botonCancelar.TabIndex = 7;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Producto";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(93, 24);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 9;
            this.labelid.Text = "0";
            // 
            // SubSeccionModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 312);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.combocategoria);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubSeccionModificarProducto";
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.SubSeccionModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.ComboBox combocategoria;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelid;
    }
}