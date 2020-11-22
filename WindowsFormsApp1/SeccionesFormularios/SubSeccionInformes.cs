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

    public partial class SubSeccionInformes : Form
    {

        public SubSeccionInformes()
        {

            InitializeComponent();

        }

        private void SubSeccionInformes_Load(object sender, EventArgs e)
        {

            this.CentrarElemento(this, this.panel2);

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
