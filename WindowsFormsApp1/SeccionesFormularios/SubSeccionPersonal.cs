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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubSeccionPersonal_Load(object sender, EventArgs e)
        {
            comboCategoria.DisplayMember = "descripcion";
            UsuarioBLL usuario = new UsuarioBLL();
            GridPersonal.DataSource = usuario.CargarUsuariossincontraseña();

            UsuarioCategoriaBLL categoria = new UsuarioCategoriaBLL();
            foreach (UsuarioCategoriaBLL cate in categoria.CargarUsuarioCategoria())
            {

                comboCategoria.Items.Add(cate);


            }

        }
    }
}
