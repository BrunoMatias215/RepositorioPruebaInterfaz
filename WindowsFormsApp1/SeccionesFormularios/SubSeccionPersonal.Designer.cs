namespace SeccionesFormularios
{
    partial class SubSeccionPersonal
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
            this.botonactulizar = new System.Windows.Forms.Button();
            this.botonEliminarUsuario = new System.Windows.Forms.Button();
            this.botonModificarUsuario = new System.Windows.Forms.Button();
            this.GridPersonal = new System.Windows.Forms.DataGridView();
            this.BotonCrearUsuario = new System.Windows.Forms.Button();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.textCUIL = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textcontraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textcontraseña2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonactulizar
            // 
            this.botonactulizar.Location = new System.Drawing.Point(810, 110);
            this.botonactulizar.Name = "botonactulizar";
            this.botonactulizar.Size = new System.Drawing.Size(135, 40);
            this.botonactulizar.TabIndex = 24;
            this.botonactulizar.Text = "Actualizar Lista";
            this.botonactulizar.UseVisualStyleBackColor = true;
            this.botonactulizar.Click += new System.EventHandler(this.botonactulizar_Click);
            // 
            // botonEliminarUsuario
            // 
            this.botonEliminarUsuario.Location = new System.Drawing.Point(810, 202);
            this.botonEliminarUsuario.Name = "botonEliminarUsuario";
            this.botonEliminarUsuario.Size = new System.Drawing.Size(135, 40);
            this.botonEliminarUsuario.TabIndex = 21;
            this.botonEliminarUsuario.Text = "Eliminar Usuario";
            this.botonEliminarUsuario.UseVisualStyleBackColor = true;
            this.botonEliminarUsuario.Click += new System.EventHandler(this.botonEliminarUsuario_Click);
            // 
            // botonModificarUsuario
            // 
            this.botonModificarUsuario.Location = new System.Drawing.Point(810, 156);
            this.botonModificarUsuario.Name = "botonModificarUsuario";
            this.botonModificarUsuario.Size = new System.Drawing.Size(135, 40);
            this.botonModificarUsuario.TabIndex = 20;
            this.botonModificarUsuario.Text = "Modificiar Usuario";
            this.botonModificarUsuario.UseVisualStyleBackColor = true;
            this.botonModificarUsuario.Click += new System.EventHandler(this.botonModificarUsuario_Click);
            // 
            // GridPersonal
            // 
            this.GridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPersonal.Location = new System.Drawing.Point(16, 110);
            this.GridPersonal.Name = "GridPersonal";
            this.GridPersonal.RowHeadersWidth = 45;
            this.GridPersonal.Size = new System.Drawing.Size(776, 156);
            this.GridPersonal.TabIndex = 19;
            // 
            // BotonCrearUsuario
            // 
            this.BotonCrearUsuario.Location = new System.Drawing.Point(742, 40);
            this.BotonCrearUsuario.Name = "BotonCrearUsuario";
            this.BotonCrearUsuario.Size = new System.Drawing.Size(127, 39);
            this.BotonCrearUsuario.TabIndex = 18;
            this.BotonCrearUsuario.Text = "Crear Usuario";
            this.BotonCrearUsuario.UseVisualStyleBackColor = true;
            this.BotonCrearUsuario.Click += new System.EventHandler(this.BotonCrearUsuario_Click);
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(538, 72);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(157, 21);
            this.comboCategoria.TabIndex = 17;
            // 
            // textCUIL
            // 
            this.textCUIL.Location = new System.Drawing.Point(538, 40);
            this.textCUIL.Name = "textCUIL";
            this.textCUIL.Size = new System.Drawing.Size(157, 20);
            this.textCUIL.TabIndex = 16;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(89, 37);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(129, 20);
            this.textNombre.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "CUIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(337, 40);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(129, 20);
            this.textApellido.TabIndex = 29;
            // 
            // textcontraseña
            // 
            this.textcontraseña.Location = new System.Drawing.Point(89, 79);
            this.textcontraseña.Name = "textcontraseña";
            this.textcontraseña.PasswordChar = '*';
            this.textcontraseña.Size = new System.Drawing.Size(129, 20);
            this.textcontraseña.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Repita contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Categoria";
            // 
            // textcontraseña2
            // 
            this.textcontraseña2.Location = new System.Drawing.Point(337, 76);
            this.textcontraseña2.Name = "textcontraseña2";
            this.textcontraseña2.PasswordChar = '*';
            this.textcontraseña2.Size = new System.Drawing.Size(129, 20);
            this.textcontraseña2.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textcontraseña2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textApellido);
            this.groupBox1.Controls.Add(this.textcontraseña);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.botonactulizar);
            this.groupBox1.Controls.Add(this.botonEliminarUsuario);
            this.groupBox1.Controls.Add(this.botonModificarUsuario);
            this.groupBox1.Controls.Add(this.GridPersonal);
            this.groupBox1.Controls.Add(this.BotonCrearUsuario);
            this.groupBox1.Controls.Add(this.comboCategoria);
            this.groupBox1.Controls.Add(this.textCUIL);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 292);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // SubSeccionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 592);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubSeccionPersonal";
            this.Text = "SubSeccionPersonal";
            this.Load += new System.EventHandler(this.SubSeccionPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonactulizar;
        private System.Windows.Forms.Button botonEliminarUsuario;
        private System.Windows.Forms.Button botonModificarUsuario;
        private System.Windows.Forms.DataGridView GridPersonal;
        private System.Windows.Forms.Button BotonCrearUsuario;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.TextBox textCUIL;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textcontraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textcontraseña2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}