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
    public partial class SubSeccionCrearPedidos : Form
    {

        public SubSeccionCrearPedidos()
        {

            InitializeComponent();

        }

        private void SubSeccionPedidos_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;

            this.ListaDeProductos.DisplayMember = "descripcion";

        }

        private void BotonEntradas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> listadeentradas = new List<Producto>();

            listadeentradas = producto.CargarEntradas();

            foreach (Producto entrada in listadeentradas)
            {

                this.ListaDeProductos.Items.Add(entrada);

            }

        }

        private void BotonConsultarPrecio_Click(object sender, EventArgs e)
        {

            if (this.ListaDeProductos.SelectedItem != null)
            {
  
                Producto entrada = (Producto)this.ListaDeProductos.SelectedItem;

                int precio = entrada.Precio;

                MessageBox.Show("El precio es " + precio, "Ver Precio");

            }
            else
            {

                MessageBox.Show("No seleccionó ningun producto", "Ver Precio");

            }

        }

        private void BotonOmelletes_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> listadeomelletes = new List<Producto>();

            listadeomelletes = producto.CargarOmelettes();

            foreach (Producto omellete in listadeomelletes)
            {

                this.ListaDeProductos.Items.Add(omellete);

            }

        }

    }
}
