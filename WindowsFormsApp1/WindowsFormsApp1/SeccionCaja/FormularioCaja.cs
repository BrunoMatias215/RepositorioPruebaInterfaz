using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.SeccionCaja
{

    public partial class FormularioCaja : Form
    {

        public FormularioCaja()
        {

            InitializeComponent();

        }

        private void FormularioCaja_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.CentrarElemento(this, this.panel1);

            this.label1.ForeColor = Color.White;

            this.label2.ForeColor = Color.White;

            this.label3.ForeColor = Color.White;

            this.BotonCrearCaja.ForeColor = Color.White;

            this.BotonCrearCaja.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonCerrarCaja.ForeColor = Color.White;

            this.BotonCerrarCaja.BackColor = Color.FromArgb(98, 104, 140);

            this.dataGridView1.BackgroundColor = Color.Lavender;

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
