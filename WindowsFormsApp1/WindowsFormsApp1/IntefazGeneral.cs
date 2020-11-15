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

        FormularioPedidos formulariopedidos;

        SeccionClientes.FormularioClientes formularioclientes;

        SeccionCaja.FormularioCaja formulariocaja;

        SeccionGestión.FormularioGestion formulariogestion;

        public InterfazGeneral()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Che Miranda - Menú Principal";

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.CenterToScreen();

            this.formulariopedidos = new FormularioPedidos();

            this.formulariopedidos.TopLevel = false;

            this.PanelInterfaz.Controls.Add(formulariopedidos);

            this.PanelInterfaz.Tag = formulariopedidos;

            this.formulariopedidos.Show();

        }

        private void BotonPedidos_Click(object sender, EventArgs e)
        {

            this.PanelInterfaz.Controls.Remove(this.PanelInterfaz.Controls[0]);

            this.formulariopedidos = new FormularioPedidos();

            this.formulariopedidos.TopLevel = false;

            this.PanelInterfaz.Controls.Add(formulariopedidos);

            this.PanelInterfaz.Tag = formulariopedidos;

            this.formulariopedidos.Show();

        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {

            this.PanelInterfaz.Controls.Remove(this.PanelInterfaz.Controls[0]);

            this.formularioclientes = new SeccionClientes.FormularioClientes();

            this.formularioclientes.TopLevel = false;

            this.PanelInterfaz.Controls.Add(this.formularioclientes);

            this.PanelInterfaz.Tag = this.formularioclientes;

            this.formularioclientes.Dock = DockStyle.Fill;

            this.formularioclientes.Show();

        }

        private void BotonCajas_Click(object sender, EventArgs e)
        {

            this.PanelInterfaz.Controls.Remove(this.PanelInterfaz.Controls[0]);

            this.formulariocaja = new SeccionCaja.FormularioCaja();

            this.formulariocaja.TopLevel = false;

            this.PanelInterfaz.Controls.Add(this.formulariocaja);

            this.PanelInterfaz.Tag = this.formulariocaja;

            this.formulariocaja.Show();

        }

        private void BotonGestion_Click(object sender, EventArgs e)
        {

            this.PanelInterfaz.Controls.Remove(this.PanelInterfaz.Controls[0]);

            this.formulariogestion = new SeccionGestión.FormularioGestion();

            this.formulariogestion.TopLevel = false;

            this.PanelInterfaz.Controls.Add(this.formulariogestion);

            this.PanelInterfaz.Tag = this.formulariogestion;

            this.formulariogestion.Show();

        }

    }

}
