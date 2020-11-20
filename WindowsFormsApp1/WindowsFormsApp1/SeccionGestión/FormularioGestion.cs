using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.SeccionGestión
{

    public partial class FormularioGestion : Form
    {

        public FormularioGestion()
        {

            InitializeComponent();

        }

        private void FormularioGestion_Load(object sender, EventArgs e)
        {

            this.CentrarElemento(this, this.panel2);

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.BotonInformes.ForeColor = Color.White;

            this.BotonInformes.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonProductos.ForeColor = Color.White;

            this.BotonProductos.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonPersonal.ForeColor = Color.White;

            this.BotonPersonal.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonVerPedidos.ForeColor = Color.White;

            this.BotonVerPedidos.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonGenerarReporte.ForeColor = Color.White;

            this.BotonGenerarReporte.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonVerProductos.ForeColor = Color.White;

            this.BotonVerProductos.BackColor = Color.FromArgb(98, 104, 140);

            this.radioButtonMensual.ForeColor = Color.White;

            this.radioButtonDiario.ForeColor = Color.White;

            this.radioButton2.ForeColor = Color.White;

            this.radioButton1.ForeColor = Color.White;

            this.label1.ForeColor = Color.White;

            this.label2.ForeColor = Color.White;

            this.label3.ForeColor = Color.White;

            this.label4.ForeColor = Color.White;

            this.label5.ForeColor = Color.White;

            this.label6.ForeColor = Color.White;

            this.label7.ForeColor = Color.White;

            this.dataGridView1.BackgroundColor = Color.Lavender;

            this.dataGridView2.BackgroundColor = Color.Lavender;

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
