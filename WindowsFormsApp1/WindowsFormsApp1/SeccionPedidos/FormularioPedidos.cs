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

        private SubSeccionCrearPedidos subseccioncrearpedidos;

        private SubSeccionGestionDePedidos subsecciongestiondepedidos;

        public FormularioPedidos()
        {

            InitializeComponent();

            this.subseccioncrearpedidos = new SubSeccionCrearPedidos();

            this.subseccioncrearpedidos.TopLevel = false;

            this.panel2.Controls.Add(this.subseccioncrearpedidos);

            this.panel2.Tag = this.subseccioncrearpedidos;

            this.subseccioncrearpedidos.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.panel2.Contains(this.subsecciongestiondepedidos))
            {

                this.subsecciongestiondepedidos.Close();

                this.subseccioncrearpedidos = new SubSeccionCrearPedidos();

                this.subseccioncrearpedidos.TopLevel = false;

                this.panel2.Controls.Add(this.subseccioncrearpedidos);

                this.panel2.Tag = this.subseccioncrearpedidos;

                this.subseccioncrearpedidos.Show();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.panel2.Contains(this.subseccioncrearpedidos)) {

                this.subseccioncrearpedidos.Close();

                this.subsecciongestiondepedidos = new SubSeccionGestionDePedidos();

                this.subsecciongestiondepedidos.FormBorderStyle = FormBorderStyle.None;

                this.subsecciongestiondepedidos.TopLevel = false;

                this.panel2.Controls.Add(this.subsecciongestiondepedidos);

                this.panel2.Tag = this.subsecciongestiondepedidos;

                this.subsecciongestiondepedidos.Show();

            }
  
        }
        
    }
}
