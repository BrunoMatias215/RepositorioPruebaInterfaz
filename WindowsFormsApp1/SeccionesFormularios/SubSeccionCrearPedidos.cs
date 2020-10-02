using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string item = "Muzarella";

            int precio = 200;

            int cantidad = 1;

            for (int i = 1; i < 21; i++)
            {

                this.listBox1.Items.Add(" "+item+" "+"("+cantidad+") "+precio);

            }

        }

    }
}
