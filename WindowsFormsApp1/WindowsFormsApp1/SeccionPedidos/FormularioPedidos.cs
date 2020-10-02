using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeccionesFormularios;

namespace WindowsFormsApp1
{
    public partial class FormularioPedidos : Form
    {
        public FormularioPedidos()
        {

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            SubSeccionCrearPedidos subseccionpedidos = new SubSeccionCrearPedidos();

            subseccionpedidos.TopLevel = false;

            this.panel2.Controls.Add(subseccionpedidos);

            this.panel2.Tag = subseccionpedidos;

            subseccionpedidos.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

    }
}
