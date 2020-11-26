using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;

namespace SeccionesFormularios
{

    public partial class SubSeccionProductos : Form
    {

        public SubSeccionProductos()
        {

            InitializeComponent();

        }

        private void SubSeccionProductos_Load(object sender, EventArgs e)
        {

            comboCategoriaP.DisplayMember = "Nombre";
            CategoriaProductoBLL categoria = new CategoriaProductoBLL();
            foreach (CategoriaProductoBLL cate in categoria.CargarProductoCategoria())
            {
                comboCategoriaP.Items.Add(cate);
            }
            ProductoBLL productobll = new ProductoBLL();

            GridProductos.DataSource = productobll.CargarTodolosproductos();

            this.GridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.GridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.CentrarElemento(this, this.panel1);

            this.label5.ForeColor = Color.White;

            this.label2.ForeColor = Color.White;

            this.label3.ForeColor = Color.White;

            this.label4.ForeColor = Color.White;

            this.BotonCrearProducto.ForeColor = Color.White;

            this.BotonCrearProducto.BackColor = Color.FromArgb(98, 104, 140);

            this.botonactulizar.ForeColor = Color.White;

            this.botonactulizar.BackColor = Color.FromArgb(98, 104, 140);

            this.botonModificarProducto.ForeColor = Color.White;

            this.botonModificarProducto.BackColor = Color.FromArgb(98, 104, 140);

            this.botonEliminarProducto.ForeColor = Color.White;

            this.botonEliminarProducto.BackColor = Color.FromArgb(98, 104, 140);

            // Productos

            this.GridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.GridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.GridProductos.AllowUserToAddRows = false;

            this.GridProductos.AllowUserToDeleteRows = false;

            this.GridProductos.AllowUserToResizeRows = false;

            this.GridProductos.AllowUserToOrderColumns = false;

            this.GridProductos.AllowUserToResizeColumns = false;

            this.GridProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.GridProductos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.GridProductos.ReadOnly = true;

            this.GridProductos.BackgroundColor = Color.Lavender;

        }

        private void textfiltroproducto_TextChanged(object sender, EventArgs e)
        {

            ProductoBLL productobll = new ProductoBLL();

            string filtro = "%"+textfiltroproducto.Text+"%";
            GridProductos.DataSource= productobll.FIltroProductos(filtro);

        }

        private void BotonCrearProducto_Click(object sender, EventArgs e)
        {

            int precio = 0;
            int idcate = 0;
            ProductoBLL producto = new ProductoBLL();
            string descri = textNombreP.Text;
           
           
            if (descri == ""  )

            {
                MessageBox.Show("No se coloco nombre al producto");
            }

                else if(comboCategoriaP.SelectedItem == null)
                {

                MessageBox.Show("Categoria no seleccionada");
                  }

                     else if (textPrecioP.Text=="")
                    {


                     MessageBox.Show("Precio no definido");
                     }
                             else
                              {
                            idcate = ((CategoriaProductoBLL)comboCategoriaP.SelectedItem).Idcategoriaproducto;
                                
                                precio = int.Parse(textPrecioP.Text);
                            producto.CrearProducto(descri, idcate, precio);
                MessageBox.Show("Producto creado con exito");
                                 }
            
            }

        private void botonModificarProducto_Click(object sender, EventArgs e)
        {

            int idproducto;
            string nombre;
            CategoriaProductoBLL categoria;
            int precio;

            if (GridProductos.SelectedRows.Count == 1) {

                idproducto = int.Parse(GridProductos.SelectedRows[0].Cells[0].Value.ToString());
                nombre = GridProductos.SelectedRows[0].Cells[1].Value.ToString();

               

                precio = int.Parse(GridProductos.SelectedRows[0].Cells[3].Value.ToString());

                SubSeccionModificarProducto modificar = new SubSeccionModificarProducto(idproducto, nombre, precio);
                modificar.ShowDialog();
     
            }
            else
            {

                MessageBox.Show("No se selecciono nigun producto");

            }

        }

        private void botonactulizar_Click(object sender, EventArgs e)
        {

            ProductoBLL productobll = new ProductoBLL();

            GridProductos.DataSource = productobll.CargarTodolosproductos();

        }

        private void botonEliminarProducto_Click(object sender, EventArgs e)
        {
            
            int idproducto;
            idproducto = int.Parse(GridProductos.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = (GridProductos.SelectedRows[0].Cells[1].Value.ToString());
            ProductoBLL producto = new ProductoBLL();

                if (GridProductos.SelectedRows.Count == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Realmente quiere eliminar el producto "+nombre+"?", "Eliminar Producto", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                    producto.EliminarProducto(idproducto);


                    MessageBox.Show("El producto ha sido eliminado");

                   
                    GridProductos.DataSource = producto.CargarTodolosproductos();
                }
               
                }
                else
                {

                MessageBox.Show("No se selecciono nigun producto");

                }

        }

        public void CentrarElemento(Control ppadre, Control phijo)
        {

            int posx;

            posx = (ppadre.Width / 2) - (phijo.Width / 2);

            phijo.Location = new System.Drawing.Point(posx, phijo.Location.Y);

            int posy;

            posy = (ppadre.Height / 2) - (phijo.Height / 2);

            phijo.Location = new System.Drawing.Point(posx, posy);

        }

    }

}

