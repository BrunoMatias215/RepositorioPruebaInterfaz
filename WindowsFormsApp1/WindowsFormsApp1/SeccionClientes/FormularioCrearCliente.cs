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

namespace WindowsFormsApp1.SeccionClientes
{

    public partial class FormularioCrearCliente : Form
    {

        public FormularioCrearCliente()
        {

            InitializeComponent();

        }

        private void FormularioCrearCliente_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.label1.ForeColor = Color.White;

            this.textBox1.BackColor = Color.FromArgb(20, 34, 56);

            this.label2.ForeColor = Color.White;

            this.textBox2.BackColor = Color.FromArgb(20, 34, 56);

            this.label3.ForeColor = Color.White;

            this.textBox3.BackColor = Color.FromArgb(20, 34, 56);

            this.label4.ForeColor = Color.White;

            this.textBox4.BackColor = Color.FromArgb(20, 34, 56);

            this.BotonGuardarCambios.ForeColor = Color.White;

            this.BotonGuardarCambios.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonCancelar.ForeColor = Color.White;

            this.BotonCancelar.BackColor = Color.FromArgb(98, 104, 140);

        }

        private void BotonGuardarCambios_Click(object sender, EventArgs e)
        {

            string nombre, apellido, telefono, direccion;

            nombre = this.textBox1.Text;

            apellido = this.textBox2.Text;

            telefono = this.textBox3.Text;

            direccion = this.textBox4.Text;

            int variable = 1;

            if (nombre != "" && apellido != "" && telefono != "" && direccion != "")
            {

                if (int.TryParse(telefono, out variable))
                {

                    int telefononumero = int.Parse(telefono);

                    ClienteBLL cliente = new ClienteBLL();

                    cliente.CrearCliente(nombre, apellido, telefononumero, direccion);

                    this.Close();

                }
                else
                {

                    MessageBox.Show("El teléfono debe ser un número", "Registrar Cliente");

                }

            }
            else
            {

                MessageBox.Show("Debe completar todos los campos", "Registrar Cliente");

            }
  
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

    }
}
