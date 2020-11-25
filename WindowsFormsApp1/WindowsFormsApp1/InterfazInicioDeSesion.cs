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

    public partial class InterfazInicioDeSesion : Form
    {

        private List<UsuarioBLL> listadeusuarios;

        public List<UsuarioBLL> Listadeusuarios { get => listadeusuarios; set => listadeusuarios = value; }

        public InterfazInicioDeSesion()
        {

            InitializeComponent();

        }

        private void InterfazInicioDeSesion_Load(object sender, EventArgs e)
        {

            this.Text = "Che Miranda - Iniciar Sesión";

            this.FormBorderStyle = FormBorderStyle.None;

            this.MaximizeBox = false;

            this.CenterToScreen();

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.panel1.BackColor = Color.FromArgb(73, 85, 117);

            this.panel2.BackColor = Color.FromArgb(73, 85, 117);

            this.CentrarElemento(this, this.panel2);

            this.label1.Text = "Che Miranda";

            this.CentrarElemento(this, this.label1);

            this.label1.ForeColor = Color.White;

            this.label2.Text = "Nombre de Usuario";

            this.label2.ForeColor = Color.White;

            this.textBox1.BackColor = Color.FromArgb(73, 85, 117);

            this.label3.Text = "Contraseña";

            this.label3.ForeColor = Color.White;

            this.textBox2.PasswordChar = '*';

            this.textBox2.BackColor = Color.FromArgb(73, 85, 117);

            this.BotonIniciarSesion.Text = "Iniciar Sesión";

            this.BotonIniciarSesion.ForeColor = Color.White;

            this.BotonIniciarSesion.BackColor = Color.FromArgb(53, 64, 97);

            this.BotonIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 109, 149);

            this.BotonIniciarSesion.TabStop = false;

            this.label4.Text = "Guilerova Solutions - Versión 1.0";

            this.CentrarElemento(this, this.label4);

            this.label4.ForeColor = Color.White;
            
        }

        private void BotonIniciarSesion_Click(object sender, EventArgs e)
        {

            // Cargar Usuarios

            UsuarioBLL usuariobll = new UsuarioBLL();

            this.listadeusuarios = usuariobll.CargarUsuarios();

            string nombredeusuario;

            string contraseña;

            nombredeusuario = this.textBox1.Text;

            contraseña = this.textBox2.Text;

            if (nombredeusuario == ""  || contraseña == "")
            {

                MessageBox.Show("Debe ingresar el nombre de usuario o la contraseña", "Iniciar Sesión");

            }
            else
            {

                UsuarioBLL usuario = null;

                int contadorusuarios = 0;

                foreach (UsuarioBLL usuarioelemento in this.listadeusuarios)
                {

                    contadorusuarios++;

                    if ((nombredeusuario == usuarioelemento.Nombre) && (contraseña == usuarioelemento.Contraseña.ToString()))
                    {

                        usuario = usuarioelemento;

                        break;

                    }
      
                }

                if (usuario == null)
                {

                    MessageBox.Show("Usuario no registrado", "Iniciar Sesión");

                    this.textBox1.Text = "";

                    this.textBox2.Text = "";

                }
                else
                {

                    InterfazGeneral interfazgeneral = new InterfazGeneral(usuario, this);

                    interfazgeneral.Show();

                    this.Visible = false;

                    this.textBox1.Text = "";

                    this.textBox2.Text = "";

                }
  
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        public void CentrarElemento(Control ppadre, Control phijo)
        {

            int posx;

            posx = (ppadre.Width / 2) - (phijo.Width / 2);

            phijo.Location = new System.Drawing.Point(posx, phijo.Location.Y);

        }

    }

}
