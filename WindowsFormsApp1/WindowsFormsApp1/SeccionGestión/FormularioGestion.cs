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

namespace WindowsFormsApp1.SeccionGestión
{

    public partial class FormularioGestion : Form
    {

        private SubSeccionInformes subseccioninformes;

        private SubSeccionProductos subseccionproductos;

        private SubSeccionPersonal subseccionpersonal;

        public FormularioGestion()
        {

            InitializeComponent();

            this.subseccioninformes = new SubSeccionInformes();

            this.subseccioninformes.TopLevel = false;

            this.panel2.Controls.Add(this.subseccioninformes);

            this.panel2.Tag = this.subseccioninformes;

            this.subseccioninformes.Show();

        }

        private void FormularioGestion_Load(object sender, EventArgs e)
        {

            

        }

        private void BotonInformes_Click(object sender, EventArgs e)
        {

            if (!(this.panel2.Contains(this.subseccioninformes)))
            {

                this.panel2.Controls.Clear();

                this.subseccioninformes = new SubSeccionInformes();

                this.subseccioninformes.TopLevel = false;

                this.panel2.Controls.Add(this.subseccioninformes);

                this.panel2.Tag = this.subseccioninformes;

                this.subseccioninformes.Show();

            }

        }

        private void BotonProductos_Click(object sender, EventArgs e)
        {

            if (!(this.panel2.Contains(this.subseccionproductos)))
            {

                this.panel2.Controls.Clear();

                this.subseccionproductos = new SubSeccionProductos();

                this.subseccionproductos.TopLevel = false;

                this.panel2.Controls.Add(this.subseccionproductos);

                this.panel2.Tag = this.subseccionproductos;

                this.subseccionproductos.Show();

            }

        }

        private void BotonPersonal_Click(object sender, EventArgs e)
        {

            if (!(this.panel2.Contains(this.subseccionpersonal)))
            {

                this.panel2.Controls.Clear();

                this.subseccionpersonal = new SubSeccionPersonal();

                this.subseccionpersonal.TopLevel = false;

                this.panel2.Controls.Add(this.subseccionpersonal);

                this.panel2.Tag = this.subseccionpersonal;

                this.subseccionpersonal.Show();

            }

        }

    }

}
