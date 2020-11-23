namespace SeccionesFormularios
{
    partial class SubSeccionProductos
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
            this.label4 = new System.Windows.Forms.Label();
            this.textNombreP = new System.Windows.Forms.TextBox();
            this.textPrecioP = new System.Windows.Forms.TextBox();
            this.comboCategoriaP = new System.Windows.Forms.ComboBox();
            this.BotonCrearProducto = new System.Windows.Forms.Button();
            this.GridProductos = new System.Windows.Forms.DataGridView();
            this.botonModificarProducto = new System.Windows.Forms.Button();
            this.botonEliminarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textfiltroproducto = new System.Windows.Forms.TextBox();
            this.botonactulizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // textNombreP
            // 
            this.textNombreP.Location = new System.Drawing.Point(206, 89);
            this.textNombreP.Name = "textNombreP";
            this.textNombreP.Size = new System.Drawing.Size(129, 20);
            this.textNombreP.TabIndex = 4;
            // 
            // textPrecioP
            // 
            this.textPrecioP.Location = new System.Drawing.Point(726, 89);
            this.textPrecioP.Name = "textPrecioP";
            this.textPrecioP.Size = new System.Drawing.Size(145, 20);
            this.textPrecioP.TabIndex = 5;
            // 
            // comboCategoriaP
            // 
            this.comboCategoriaP.FormattingEnabled = true;
            this.comboCategoriaP.Location = new System.Drawing.Point(461, 89);
            this.comboCategoriaP.Name = "comboCategoriaP";
            this.comboCategoriaP.Size = new System.Drawing.Size(157, 21);
            this.comboCategoriaP.TabIndex = 6;
            // 
            // BotonCrearProducto
            // 
            this.BotonCrearProducto.Location = new System.Drawing.Point(902, 79);
            this.BotonCrearProducto.Name = "BotonCrearProducto";
            this.BotonCrearProducto.Size = new System.Drawing.Size(127, 39);
            this.BotonCrearProducto.TabIndex = 7;
            this.BotonCrearProducto.Text = "Crear Producto";
            this.BotonCrearProducto.UseVisualStyleBackColor = true;
            this.BotonCrearProducto.Click += new System.EventHandler(this.BotonCrearProducto_Click);
            // 
            // GridProductos
            // 
            this.GridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProductos.Location = new System.Drawing.Point(95, 186);
            this.GridProductos.Name = "GridProductos";
            this.GridProductos.RowHeadersWidth = 45;
            this.GridProductos.Size = new System.Drawing.Size(776, 380);
            this.GridProductos.TabIndex = 8;
            // 
            // botonModificarProducto
            // 
            this.botonModificarProducto.Location = new System.Drawing.Point(902, 232);
            this.botonModificarProducto.Name = "botonModificarProducto";
            this.botonModificarProducto.Size = new System.Drawing.Size(135, 40);
            this.botonModificarProducto.TabIndex = 9;
            this.botonModificarProducto.Text = "Modificiar Producto";
            this.botonModificarProducto.UseVisualStyleBackColor = true;
            this.botonModificarProducto.Click += new System.EventHandler(this.botonModificarProducto_Click);
            // 
            // botonEliminarProducto
            // 
            this.botonEliminarProducto.Location = new System.Drawing.Point(902, 278);
            this.botonEliminarProducto.Name = "botonEliminarProducto";
            this.botonEliminarProducto.Size = new System.Drawing.Size(135, 40);
            this.botonEliminarProducto.TabIndex = 10;
            this.botonEliminarProducto.Text = "Eliminar Producto";
            this.botonEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Buscar productos";
            // 
            // textfiltroproducto
            // 
            this.textfiltroproducto.Location = new System.Drawing.Point(189, 160);
            this.textfiltroproducto.Name = "textfiltroproducto";
            this.textfiltroproducto.Size = new System.Drawing.Size(137, 20);
            this.textfiltroproducto.TabIndex = 12;
            this.textfiltroproducto.TextChanged += new System.EventHandler(this.textfiltroproducto_TextChanged);
            // 
            // botonactulizar
            // 
            this.botonactulizar.Location = new System.Drawing.Point(902, 186);
            this.botonactulizar.Name = "botonactulizar";
            this.botonactulizar.Size = new System.Drawing.Size(135, 40);
            this.botonactulizar.TabIndex = 13;
            this.botonactulizar.Text = "Actualizar Lista";
            this.botonactulizar.UseVisualStyleBackColor = true;
            this.botonactulizar.Click += new System.EventHandler(this.botonactulizar_Click);
            // 
            // SubSeccionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 592);
            this.Controls.Add(this.botonactulizar);
            this.Controls.Add(this.textfiltroproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonEliminarProducto);
            this.Controls.Add(this.botonModificarProducto);
            this.Controls.Add(this.GridProductos);
            this.Controls.Add(this.BotonCrearProducto);
            this.Controls.Add(this.comboCategoriaP);
            this.Controls.Add(this.textPrecioP);
            this.Controls.Add(this.textNombreP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubSeccionProductos";
            this.Text = "SubSeccionProductos";
            this.Load += new System.EventHandler(this.SubSeccionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombreP;
        private System.Windows.Forms.TextBox textPrecioP;
        private System.Windows.Forms.ComboBox comboCategoriaP;
        private System.Windows.Forms.Button BotonCrearProducto;
        private System.Windows.Forms.DataGridView GridProductos;
        private System.Windows.Forms.Button botonModificarProducto;
        private System.Windows.Forms.Button botonEliminarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textfiltroproducto;
        private System.Windows.Forms.Button botonactulizar;
    }
}