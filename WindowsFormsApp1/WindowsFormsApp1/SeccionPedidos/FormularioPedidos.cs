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

        private int idusuario;

        public FormularioPedidos(int pidusuario)
        {

            InitializeComponent();

            this.idusuario = pidusuario;

            this.BarraHerramientas.BackColor = Color.FromArgb(20, 34, 56);

            this.BotonCrearPedido.ForeColor = Color.White;

            this.BotonCrearPedido.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonCrearPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 109, 149);

            this.BotonGestionDePedido.ForeColor = Color.White;

            this.BotonGestionDePedido.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonGestionDePedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 109, 149);

            this.subseccioncrearpedidos = new SubSeccionCrearPedidos(this.idusuario);

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

                this.subseccioncrearpedidos = new SubSeccionCrearPedidos(this.idusuario);

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
