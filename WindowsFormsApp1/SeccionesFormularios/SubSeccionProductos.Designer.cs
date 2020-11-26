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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // textNombreP
            // 
            this.textNombreP.Location = new System.Drawing.Point(21, 424);
            this.textNombreP.Name = "textNombreP";
            this.textNombreP.Size = new System.Drawing.Size(129, 20);
            this.textNombreP.TabIndex = 4;
            // 
            // textPrecioP
            // 
            this.textPrecioP.Location = new System.Drawing.Point(382, 424);
            this.textPrecioP.Name = "textPrecioP";
            this.textPrecioP.Size = new System.Drawing.Size(129, 20);
            this.textPrecioP.TabIndex = 5;
            // 
            // comboCategoriaP
            // 
            this.comboCategoriaP.FormattingEnabled = true;
            this.comboCategoriaP.Location = new System.Drawing.Point(203, 424);
            this.comboCategoriaP.Name = "comboCategoriaP";
            this.comboCategoriaP.Size = new System.Drawing.Size(129, 21);
            this.comboCategoriaP.TabIndex = 6;
            // 
            // BotonCrearProducto
            // 
            this.BotonCrearProducto.FlatAppearance.BorderSize = 0;
            this.BotonCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCrearProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearProducto.Location = new System.Drawing.Point(655, 406);
            this.BotonCrearProducto.Name = "BotonCrearProducto";
            this.BotonCrearProducto.Size = new System.Drawing.Size(125, 39);
            this.BotonCrearProducto.TabIndex = 7;
            this.BotonCrearProducto.Text = "Crear Producto";
            this.BotonCrearProducto.UseVisualStyleBackColor = true;
            this.BotonCrearProducto.Click += new System.EventHandler(this.BotonCrearProducto_Click);
            // 
            // GridProductos
            // 
            this.GridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProductos.Location = new System.Drawing.Point(21, 47);
            this.GridProductos.Name = "GridProductos";
            this.GridProductos.RowHeadersWidth = 45;
            this.GridProductos.Size = new System.Drawing.Size(759, 331);
            this.GridProductos.TabIndex = 8;
            // 
            // botonModificarProducto
            // 
            this.botonModificarProducto.FlatAppearance.BorderSize = 0;
            this.botonModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModificarProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificarProducto.Location = new System.Drawing.Point(801, 93);
            this.botonModificarProducto.Name = "botonModificarProducto";
            this.botonModificarProducto.Size = new System.Drawing.Size(125, 40);
            this.botonModificarProducto.TabIndex = 9;
            this.botonModificarProducto.Text = "Modificar Producto";
            this.botonModificarProducto.UseVisualStyleBackColor = true;
            this.botonModificarProducto.Click += new System.EventHandler(this.botonModificarProducto_Click);
            // 
            // botonEliminarProducto
            // 
            this.botonEliminarProducto.FlatAppearance.BorderSize = 0;
            this.botonEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminarProducto.Location = new System.Drawing.Point(801, 139);
            this.botonEliminarProducto.Name = "botonEliminarProducto";
            this.botonEliminarProducto.Size = new System.Drawing.Size(125, 40);
            this.botonEliminarProducto.TabIndex = 10;
            this.botonEliminarProducto.Text = "Eliminar Producto";
            this.botonEliminarProducto.UseVisualStyleBackColor = true;
            this.botonEliminarProducto.Click += new System.EventHandler(this.botonEliminarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Buscar Productos";
            // 
            // textfiltroproducto
            // 
            this.textfiltroproducto.Location = new System.Drawing.Point(121, 21);
            this.textfiltroproducto.Name = "textfiltroproducto";
            this.textfiltroproducto.Size = new System.Drawing.Size(129, 20);
            this.textfiltroproducto.TabIndex = 12;
            this.textfiltroproducto.TextChanged += new System.EventHandler(this.textfiltroproducto_TextChanged);
            // 
            // botonactulizar
            // 
            this.botonactulizar.FlatAppearance.BorderSize = 0;
            this.botonactulizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonactulizar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonactulizar.Location = new System.Drawing.Point(801, 47);
            this.botonactulizar.Name = "botonactulizar";
            this.botonactulizar.Size = new System.Drawing.Size(125, 40);
            this.botonactulizar.TabIndex = 13;
            this.botonactulizar.Text = "Actualizar Lista";
            this.botonactulizar.UseVisualStyleBackColor = true;
            this.botonactulizar.Click += new System.EventHandler(this.botonactulizar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.botonEliminarProducto);
            this.panel1.Controls.Add(this.botonactulizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textfiltroproducto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textNombreP);
            this.panel1.Controls.Add(this.botonModificarProducto);
            this.panel1.Controls.Add(this.textPrecioP);
            this.panel1.Controls.Add(this.GridProductos);
            this.panel1.Controls.Add(this.comboCategoriaP);
            this.panel1.Controls.Add(this.BotonCrearProducto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 470);
            this.panel1.TabIndex = 14;
            // 
            // SubSeccionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 592);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubSeccionProductos";
            this.Text = "SubSeccionProductos";
            this.Load += new System.EventHandler(this.SubSeccionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel panel1;
    }
}