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

            // Caja

            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridView1.AllowUserToAddRows = false;

            this.dataGridView1.AllowUserToDeleteRows = false;

            this.dataGridView1.AllowUserToResizeRows = false;

            this.dataGridView1.AllowUserToOrderColumns = false;

            this.dataGridView1.AllowUserToResizeColumns = false;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.BackgroundColor = Color.Lavender;

            this.comboUsuarios.DisplayMember = "Nombre";

            UsuarioBLL usuario = new UsuarioBLL();

            foreach (UsuarioBLL usuarioelemento in usuario.CargarUsuarios())
            {

                this.comboUsuarios.Items.Add(usuarioelemento);

            }

            CajaBLL caja = new CajaBLL();

            dataGridView1.DataSource = caja.CargarCajasActivas();

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

        private void BotonCrearCaja_Click(object sender, EventArgs e)
        {

            if (this.comboUsuarios.SelectedIndex >= 0 && this.textBoxCajaEfectivoInicial.Text != "")
            {

                int idusuario = ((UsuarioBLL)comboUsuarios.SelectedItem).Legajo;

                int efectivoencaja = int.Parse(textBoxCajaEfectivoInicial.Text);

                int posnet = 0;

                int efectivoinicialencaja = int.Parse(textBoxCajaEfectivoInicial.Text);

                DateTime fechayhora = DateTime.Now;

                int estado = 1;

                CajaBLL nuevacaja = new CajaBLL();

                nuevacaja.CrearCaja(idusuario, efectivoencaja, posnet, fechayhora, efectivoinicialencaja, estado);

                dataGridView1.DataSource = nuevacaja.CargarCajasActivas();

            }
            else
            {

                if (this.comboUsuarios.SelectedIndex < 0)
                {

                    MessageBox.Show("No has seleccionado un usuario", "Crear Caja");

                }
                else
                {

                    MessageBox.Show("No se ha establecido el efectivo inicial", "Crear Caja");

                }

            }

        }

    }

}
