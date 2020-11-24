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
namespace SeccionesFormularios
{
    public partial class ModificarCadete : Form
    {
        public ModificarCadete(int id, string nombre, string apellido, int telefono, int licencia)
        {
            InitializeComponent();
            labelid.Text = id.ToString();
            textNombre.Text = nombre;
            textApellido.Text = apellido;
            texttelefono.Text = (telefono).ToString();
            textlicencia.Text = (licencia).ToString();


        }

        private void ModificarCadete_Load(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" || textApellido.Text == "" || texttelefono.Text == "" || textlicencia.Text == "" )
            {


                MessageBox.Show("Complete todos los datos");
            }

           else
            {




                int id = int.Parse(labelid.Text);
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                int telefono = int.Parse(texttelefono.Text);
                int licencia = int.Parse(textlicencia.Text);
               
                CadeteBLL cadete = new CadeteBLL();
                cadete.ModificarCadete(id, nombre, apellido, telefono, licencia);
                MessageBox.Show("Cadete modificado. Actualize la tabla para visualizar los cambios");




                Close();
        }
    }

    }
}
