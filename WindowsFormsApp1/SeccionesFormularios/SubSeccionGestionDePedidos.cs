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

    public partial class SubSeccionGestionDePedidos : Form
    {

        public SubSeccionGestionDePedidos()
        {

            InitializeComponent();

        }

        private void SubSeccionGestionDePedidos_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.CentrarElemento(this, this.panel1);

            this.comboBox1.DisplayMember = "descripcion";

            this.comboBox2.DisplayMember = "nombre";

            this.label1.ForeColor = Color.White;

            this.label2.ForeColor = Color.White;

            this.BotonModificarEstado.ForeColor = Color.White;

            this.BotonModificarEstado.BackColor = Color.FromArgb(98, 104, 140);

            this.label3.ForeColor = Color.White;

            this.BotonAsignarCadete.ForeColor = Color.White;

            this.BotonAsignarCadete.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonVerDetallePedido.ForeColor = Color.White;

            this.BotonVerDetallePedido.BackColor = Color.FromArgb(98, 104, 140);

            // Pedidos

            CapaDeNegocios.PedidoBLL pedido = new CapaDeNegocios.PedidoBLL();

            this.dataGridView1.DataSource = pedido.CargarPedidosActivos();

            // Estados de Categorias

            CapaDeNegocios.EstadoCategoriaBLL estadocategoria = new CapaDeNegocios.EstadoCategoriaBLL();

            List<EstadoCategoriaBLL> estadoscategoriasaagregar = new List<EstadoCategoriaBLL>();

            estadoscategoriasaagregar = estadocategoria.CargarEstadosCategoria();

            foreach (EstadoCategoriaBLL lineaestadocategoria in estadoscategoriasaagregar)
            {

                this.comboBox1.Items.Add(lineaestadocategoria);

            }

            // Cadetes

            CadeteBLL cadete = new CadeteBLL();

            List<CadeteBLL> cadetesaagregar = new List<CadeteBLL>();

            cadetesaagregar = cadete.CargarCadetes();

            foreach (CadeteBLL lineacadete in cadetesaagregar)
            {

                this.comboBox2.Items.Add(lineacadete);

            }

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

        private void BotonModificarEstado_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0 && this.comboBox1.SelectedIndex >= 0)
            {

                PedidoBLL pedido = new PedidoBLL();

                int idpedido = int.Parse(this.dataGridView1.SelectedRows[this.dataGridView1.SelectedRows.Count - 1].Cells[0].Value.ToString());

                int idestadocategoria = ((EstadoCategoriaBLL)this.comboBox1.SelectedItem).Idestadocategoria;

                pedido.ModificarEstadoPedido(idpedido, idestadocategoria);

                this.dataGridView1.DataSource = pedido.CargarPedidosActivos();

            }
            else
            {

                MessageBox.Show("Debe seleccionar un pedido y un estado para el mismo", "Modificar Estado");

            }

        }

    }

}
