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
            
        }

        private void textfiltroproducto_TextChanged(object sender, EventArgs e)
        {

            ProductoBLL productobll = new ProductoBLL();

            string filtro = "%"+textfiltroproducto.Text+"%";
            GridProductos.DataSource= productobll.FIltroProductos(filtro);



        }
    }
}
