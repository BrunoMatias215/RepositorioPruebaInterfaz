using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.SeccionClientes
{

    public partial class FormularioClientes : Form
    {

        public FormularioClientes()
        {

            InitializeComponent();

        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.CentrarElemento(this, this.panel1);

            this.labelBúsquedaClientes.ForeColor = Color.White;

            this.textBox1.BackColor = Color.FromArgb(20, 34, 56);

            this.BotonNuevoCliente.ForeColor = Color.White;

            this.BotonNuevoCliente.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonModificarCliente.ForeColor = Color.White;

            this.BotonModificarCliente.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonEliminarCliente.ForeColor = Color.White;

            this.BotonEliminarCliente.BackColor = Color.FromArgb(98, 104, 140);

            this.labelPedido.ForeColor = Color.White;

            this.labelDetallePedido.ForeColor = Color.White;

            this.dataGridView1.BackgroundColor = Color.Lavender;

            this.dataGridView2.BackgroundColor = Color.Lavender;

            this.dataGridView3.BackgroundColor = Color.Lavender;

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
