using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class InterfazGeneral : Form
    {

        public InterfazGeneral()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.CenterToScreen();

            FormularioPedidos formulariopedidos = new FormularioPedidos();

            formulariopedidos.TopLevel = false;

            this.PanelInterfaz.Controls.Add(formulariopedidos);

            this.PanelInterfaz.Tag = formulariopedidos;

            formulariopedidos.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

    }

}
