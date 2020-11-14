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

    public partial class InterfazInicioDeSesion : Form
    {

        public InterfazInicioDeSesion()
        {

            InitializeComponent();

        }

        private void InterfazInicioDeSesion_Load(object sender, EventArgs e)
        {

            this.Text = "Che Miranda - Iniciar Sesión";

            this.MaximizeBox = false;

            this.CenterToScreen();

            this.label1.Text = "Nombre de Usuario";

            this.label2.Text = "Contraseña";

            this.textBox2.PasswordChar = '*';

            this.BotonIniciarSesion.Text = "Iniciar Sesión";

        }

        private void BotonIniciarSesion_Click(object sender, EventArgs e)
        {

            string nombredeusuario;

            string contraseña;

            nombredeusuario = this.textBox1.Text;

            contraseña = this.textBox2.Text;

            if (nombredeusuario == ""  || contraseña == "")
            {

                MessageBox.Show("El nombre de usuario o la contraseña deben estar completos", "Iniciar Sesión");

            }
            else
            {

                if (nombredeusuario == "admin" && contraseña == "admin")
                {

                    InterfazGeneral interfazgeneral = new InterfazGeneral();

                    this.Visible = false;

                    interfazgeneral.Show();

                }
                else
                {

                    MessageBox.Show("Nombre de usuario o contraseña incorrecta", "Iniciar Sesión");

                    this.textBox1.Text = "";

                    this.textBox2.Text = "";

                }

            }

        }

    }

}
