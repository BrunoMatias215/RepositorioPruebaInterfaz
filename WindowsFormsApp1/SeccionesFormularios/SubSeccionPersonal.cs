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



            ////Cadete


            this.gridcadete.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridcadete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CadeteBLL cadete = new CadeteBLL();

            gridcadete.DataSource = cadete.CargartablaCadetes ();

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.label2.ForeColor = Color.White;

            this.label3.ForeColor = Color.White;

            this.label4.ForeColor = Color.White;

            this.label6.ForeColor = Color.White;

            this.label7.ForeColor = Color.White;

            this.label8.ForeColor = Color.White;

            this.BotonCrearUsuario.ForeColor = Color.White;

            this.BotonCrearUsuario.BackColor = Color.FromArgb(98, 104, 140);

            this.botonactulizar.ForeColor = Color.White;

            this.botonactulizar.BackColor = Color.FromArgb(98, 104, 140);

            this.botonModificarUsuario.ForeColor = Color.White;

            this.botonModificarUsuario.BackColor = Color.FromArgb(98, 104, 140);

            this.botonEliminarUsuario.ForeColor = Color.White;

            this.botonEliminarUsuario.BackColor = Color.FromArgb(98, 104, 140);

            this.label12.ForeColor = Color.White;

            this.label11.ForeColor = Color.White;

            this.label10.ForeColor = Color.White;

            this.label9.ForeColor = Color.White;

            this.button4.ForeColor = Color.White;

            this.button4.BackColor = Color.FromArgb(98, 104, 140);

            this.actulizarcadete.ForeColor = Color.White;

            this.actulizarcadete.BackColor = Color.FromArgb(98, 104, 140);

            this.motonmodicadete.ForeColor = Color.White;

            this.motonmodicadete.BackColor = Color.FromArgb(98, 104, 140);

            this.botoneliminarcadete.ForeColor = Color.White;

            this.botoneliminarcadete.BackColor = Color.FromArgb(98, 104, 140);

            // Personal

            this.GridPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.GridPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.GridPersonal.AllowUserToAddRows = false;

            this.GridPersonal.AllowUserToDeleteRows = false;

            this.GridPersonal.AllowUserToResizeRows = false;

            this.GridPersonal.AllowUserToOrderColumns = false;

            this.GridPersonal.AllowUserToResizeColumns = false;

            this.GridPersonal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.GridPersonal.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.GridPersonal.ReadOnly = true;

            this.GridPersonal.BackgroundColor = Color.Lavender;

            // Cadete

            this.gridcadete.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.gridcadete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.gridcadete.AllowUserToAddRows = false;

            this.gridcadete.AllowUserToDeleteRows = false;

            this.gridcadete.AllowUserToResizeRows = false;

            this.gridcadete.AllowUserToOrderColumns = false;

            this.gridcadete.AllowUserToResizeColumns = false;

            this.gridcadete.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.gridcadete.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.gridcadete.ReadOnly = true;

            this.gridcadete.BackgroundColor = Color.Lavender;

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
                MessageBox.Show("No se selecciono ningun usuario");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textnom.Text == "" || textape.Text == "" || texttel.Text == "" || textlicencia.Text == "" )

            {
                MessageBox.Show("Falta completar datos");

            }
          
            else
            {
                string nombre = textnom.Text;
                string apellido = textape.Text;
                int tel = int.Parse(texttel.Text);
                int licencia = int.Parse(textlicencia.Text);
               
                CadeteBLL cadete = new CadeteBLL();
                cadete.CrearCadete(nombre, apellido, tel, licencia);
                gridcadete.DataSource = cadete.CargarCadetes();
                MessageBox.Show("El Cadete se creo de forma correcta");
            }

        }

        private void actulizarcadete_Click(object sender, EventArgs e)
        {
            CadeteBLL cadete = new CadeteBLL();

            gridcadete.DataSource = cadete.CargartablaCadetes();
        }

        private void motonmodicadete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridcadete.SelectedRows[0].Cells[0].Value.ToString());
            string nombre =  (gridcadete.SelectedRows[0].Cells[1].Value.ToString());
            string apellido = (gridcadete.SelectedRows[0].Cells[2].Value.ToString());
            int telefono = int.Parse(gridcadete.SelectedRows[0].Cells[3].Value.ToString());
            int licencia = int.Parse(gridcadete.SelectedRows[0].Cells[4].Value.ToString());



            ModificarCadete cadete = new ModificarCadete(id, nombre, apellido, telefono, licencia);

                cadete.ShowDialog();

        }

        private void botoneliminarcadete_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(gridcadete.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = (gridcadete.SelectedRows[0].Cells[1].Value.ToString());
            CadeteBLL cadete = new CadeteBLL();

            if (gridcadete.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Realmente quiere eliminar el cadete " + nombre + "?", "Eliminar cadete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    cadete.EliminarCadete(id);


                    MessageBox.Show("El cadete ha sido eliminado");


                    gridcadete.DataSource = cadete.CargartablaCadetes();
                }



            }
            else
            {
                MessageBox.Show("No se selecciono ningun cadete");
            }
        }
    }
}