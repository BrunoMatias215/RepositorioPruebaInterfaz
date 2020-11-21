using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;

namespace WindowsFormsApp1
{

    public partial class InterfazGeneral : Form
    {

        private InterfazInicioDeSesion interfaziniciodesesion;

        private FormularioPedidos formulariopedidos;

        private SeccionClientes.FormularioClientes formularioclientes;

        private SeccionCaja.FormularioCaja formulariocaja;

        private SeccionGestión.FormularioGestion formulariogestion;

        private UsuarioBLL usuario;

        public InterfazGeneral(UsuarioBLL pusuario, InterfazInicioDeSesion pinterfaziniciodesesion)
        {

            InitializeComponent();

            this.usuario = pusuario;

            this.interfaziniciodesesion = pinterfaziniciodesesion;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Che Miranda - Menú Principal";

            this.FormBorderStyle = FormBorderStyle.None;

            this.CenterToScreen();

            this.formulariopedidos = new FormularioPedidos();

            this.formulariopedidos.TopLevel = false;

            this.panel1.BackColor = Color.FromArgb(31, 49, 120);

            this.MenuOpciones.BackColor = Color.FromArgb(14, 15, 20);

            this.label1.ForeColor = Color.White;

            this.label1.Text = "Nombre " + this.usuario.Nombre;

            this.CentrarElemento(this.MenuOpciones, this.label1);

            this.label2.ForeColor = Color.White;

            this.label2.Text = "Legajo ";

            this.CentrarElemento(this.MenuOpciones, this.label2);

            this.BotonPedidos.ForeColor = Color.White;

            this.BotonPedidos.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 109, 149);

            this.CentrarElemento(this.MenuOpciones, this.BotonPedidos);

            this.BotonClientes.ForeColor = Color.White;

            this.BotonClientes.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 109, 149);

            this.CentrarElemento(this.MenuOpciones, this.BotonClientes);

            this.BotonCajas.ForeColor = Color.White;

            this.BotonCajas.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonCajas.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 109, 149);

            this.CentrarElemento(this.MenuOpciones, this.BotonCajas);

            this.BotonGestion.ForeColor = Color.White;

            this.BotonGestion.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonGestion.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 109, 149);

            this.CentrarElemento(this.MenuOpciones, this.BotonGestion);

            this.BotonCerrarSesion.ForeColor = Color.White;

            this.BotonCerrarSesion.BackColor = Color.FromArgb(219, 23, 9);

            this.BotonCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 71, 59);

            this.CentrarElemento(this.MenuOpciones, this.BotonCerrarSesion);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.interfaziniciodesesion.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        public void CentrarElemento(Control ppadre, Control phijo)
        {

            int posx;

            posx = (ppadre.Width / 2) - (phijo.Width / 2);

            phijo.Location = new System.Drawing.Point(posx, phijo.Location.Y);

        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {

            this.Close();

            this.interfaziniciodesesion.Visible = true;

        }

        private void PanelInterfaz_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
