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
    public partial class SubSeccionPersonal : Form
    {
        public SubSeccionPersonal()
        {
            InitializeComponent();
        }

      

        private void SubSeccionPersonal_Load(object sender, EventArgs e)
        {
            this.GridPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GridPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboCategoria.DisplayMember = "descripcion";
            UsuarioBLL usuario = new UsuarioBLL();
            GridPersonal.DataSource = usuario.CargarUsuariossincontraseña();

            UsuarioCategoriaBLL categoria = new UsuarioCategoriaBLL();
            foreach (UsuarioCategoriaBLL cate in categoria.CargarUsuarioCategoria())
            {

                comboCategoria.Items.Add(cate);


            }

        }

        private void botonactulizar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuario = new UsuarioBLL();
            GridPersonal.DataSource = usuario.CargarUsuariossincontraseña();
        }

        private void BotonCrearUsuario_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" || textApellido.Text=="" || textcontraseña.Text=="" || textcontraseña2.Text=="" || textCUIL.Text =="" || comboCategoria.SelectedItem== null )

            {
                MessageBox.Show("Falta completar datos");

            }
            else if (textcontraseña.Text != textcontraseña2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                int cuil = int.Parse(textCUIL.Text);
                int contraseña = int.Parse(textcontraseña.Text);
                int idcategoria = int.Parse(((UsuarioCategoriaBLL)comboCategoria.SelectedItem).Idcategoria.ToString());
                UsuarioBLL usuario = new UsuarioBLL();
                usuario.CrearUsuario(nombre, apellido, cuil, contraseña, idcategoria);
                GridPersonal.DataSource = usuario.CargarUsuariossincontraseña();
                MessageBox.Show("El usuario se creo de forma correcta");
            }

    }

        private void botonModificarUsuario_Click(object sender, EventArgs e)
        {
            int idusuario = int.Parse(GridPersonal.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = (GridPersonal.SelectedRows[0].Cells[1].Value.ToString());
            string apellido = (GridPersonal.SelectedRows[0].Cells[2].Value.ToString());
            int CUIL = int.Parse(GridPersonal.SelectedRows[0].Cells[3].Value.ToString());




            ModificarUsuario modi = new ModificarUsuario(idusuario, nombre, apellido, CUIL);

            modi.ShowDialog();


        }

        private void botonEliminarUsuario_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(GridPersonal.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = (GridPersonal.SelectedRows[0].Cells[1].Value.ToString());
            UsuarioBLL usuario = new UsuarioBLL();

            if (GridPersonal.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Realmente quiere eliminar el usuario " + nombre + "?", "Eliminar usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    usuario.EliminarUsuario(id);


                    MessageBox.Show("El usuario ha sido eliminado");


                    GridPersonal.DataSource = usuario.CargarUsuariossincontraseña();
                }



            }
            else
            {
                MessageBox.Show("No se selecciono nigun producto");
            }
        }
    }
}