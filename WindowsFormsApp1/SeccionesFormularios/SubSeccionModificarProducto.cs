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
    public partial class SubSeccionModificarProducto : Form { 


  
    
        public SubSeccionModificarProducto(int pidproducto,string pNombre, int pprecio)
        {
            InitializeComponent();
            labelid.Text = pidproducto.ToString();
            textnombre.Text = pNombre;
            textprecio.Text = pprecio.ToString();
            


        }

        private void SubSeccionModificarProducto_Load(object sender, EventArgs e)
        {
           
            
            combocategoria.DisplayMember = "Nombre";
            CategoriaProductoBLL categoria = new CategoriaProductoBLL();
            foreach (CategoriaProductoBLL cate in categoria.CargarProductoCategoria())
            {
                combocategoria.Items.Add(cate);                   
                    
            
            }

          



        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (textnombre.Text == "")
            {
                MessageBox.Show("Falta completar el nombre");
            }
            else if (textprecio.Text == "")
            {


                MessageBox.Show("Falta completar el precio");
            }
            else if (combocategoria.SelectedItem == null)
                
            {
                MessageBox.Show("Falta completar la categoria");

            }

            else{

                int idcategoria = ((CategoriaProductoBLL)combocategoria.SelectedItem).Idcategoriaproducto;
                int idproducto = int.Parse(labelid.Text);
                string nombre = textnombre.Text;
                int precio = int.Parse(textprecio.Text);

                ProductoBLL producto = new ProductoBLL();
                producto.ModificarProducto(idproducto, textnombre.Text, idcategoria, precio);
                MessageBox.Show("Producto modificado correctamente, actualice la lista para visualizar los cambios");

                Close();
            }



        }
    }
}



