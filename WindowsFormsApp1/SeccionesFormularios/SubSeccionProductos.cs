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


            this.GridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           

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
    }
}

