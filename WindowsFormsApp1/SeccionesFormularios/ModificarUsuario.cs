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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario(int pid, string pnombre, string papellido, int pCUIl )
        {


            InitializeComponent();
            string nombre = pnombre;
            string apellido = papellido;
            int CUIL = pCUIl;

            labelid.Text = pid.ToString();
            textNombre.Text = nombre;
            textApellido.Text = apellido;
            textCUIL.Text = CUIL.ToString();

            comboCategoria.DisplayMember = "descripcion";
        

         
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            UsuarioCategoriaBLL categoria = new UsuarioCategoriaBLL();
            foreach (UsuarioCategoriaBLL cate in categoria.CargarUsuarioCategoria())
            {

                comboCategoria.Items.Add(cate);


            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" || textApellido.Text == "" || textcontraseña.Text == "" || textcontraseña2.Text == "" || textCUIL.Text == "" || comboCategoria.SelectedItem == null)
            {


                MessageBox.Show("Complete todos los datos");
            }

            else if (textcontraseña.Text != textcontraseña2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {


            




                int id = int.Parse(labelid.Text);
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            int cuil = int.Parse(textCUIL.Text);
            int contraseña = int.Parse(textcontraseña.Text);
            int idcategoria = ((UsuarioCategoriaBLL)comboCategoria.SelectedItem).Idcategoria;

            UsuarioBLL usuario = new UsuarioBLL();
            usuario.ModificarUsuario(id, nombre, apellido, cuil, contraseña, idcategoria);
            MessageBox.Show("Usuario modificado. Actualize la tabla para visualizar los cambios");
            Close();

            }

        }









        }





 }
    

