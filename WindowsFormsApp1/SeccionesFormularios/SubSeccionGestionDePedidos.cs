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

        private int idusuario;

        public SubSeccionGestionDePedidos(int pidusuario)
        {

            InitializeComponent();

            this.idusuario = pidusuario;

        }

        private void SubSeccionGestionDePedidos_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.CentrarElemento(this, this.panel1);

            this.comboBoxEstadoPedido.DisplayMember = "descripcion";

            this.comboBoxCadete.DisplayMember = "nombre";

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

            this.dataGridView1.DataSource = pedido.CargarPedidosActivos(this.idusuario);

            // Estados de Categorias

            CapaDeNegocios.EstadoCategoriaBLL estadocategoria = new CapaDeNegocios.EstadoCategoriaBLL();

            List<EstadoCategoriaBLL> estadoscategoriasaagregar = new List<EstadoCategoriaBLL>();

            estadoscategoriasaagregar = estadocategoria.CargarEstadosCategoria();

            foreach (EstadoCategoriaBLL lineaestadocategoria in estadoscategoriasaagregar)
            {

                this.comboBoxEstadoPedido.Items.Add(lineaestadocategoria);

            }

            // Cadetes

            CadeteBLL cadete = new CadeteBLL();

            List<CadeteBLL> cadetesaagregar = new List<CadeteBLL>();

            cadetesaagregar = cadete.CargarCadetes();

            foreach (CadeteBLL lineacadete in cadetesaagregar)
            {

                this.comboBoxCadete.Items.Add(lineacadete);

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

            this.dataGridView1.ReadOnly = true;

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

            if (this.dataGridView1.SelectedRows.Count > 0 && this.comboBoxEstadoPedido.SelectedIndex >= 0)
            {

                if (this.comboBoxEstadoPedido.SelectedItem != null && this.comboBoxEstadoPedido.Text == "Inicializado")
                {

                    if (this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Inicializado")
                    {

                        MessageBox.Show("El pedido ya se encuentra inicializado", "Modificar Pedido");

                        this.comboBoxEstadoPedido.SelectedItem = null;

                        this.comboBoxEstadoPedido.Text = "";

                    }
                    else
                    {

                        PedidoBLL pedido = new PedidoBLL();

                        int idpedido = int.Parse(this.dataGridView1.SelectedRows[this.dataGridView1.SelectedRows.Count - 1].Cells[0].Value.ToString());

                        int idestadocategoria = ((EstadoCategoriaBLL)this.comboBoxEstadoPedido.SelectedItem).Idestadocategoria;

                        pedido.ModificarEstadoPedido(idpedido, idestadocategoria);

                        this.dataGridView1.DataSource = pedido.CargarPedidosActivos(this.idusuario);

                    }

                }
                else if (this.comboBoxEstadoPedido.SelectedItem != null && this.comboBoxEstadoPedido.Text == "Cancelado")
                {



                }else
                {



                }

            }
            else
            {

                if (this.dataGridView1.SelectedRows.Count <= 0)
                {

                    MessageBox.Show("Debe seleccionar un pedido", "Modificar Pedido");

                }
                else
                {

                    MessageBox.Show("Debe seleccionar un estado para el pedido", "Modificar Pedido");

                }

            }

        }

        private void BotonAsignarCadete_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0 && this.comboBoxCadete.SelectedItem != null && this.comboBoxCadete.Text != "")
            {

                int idpedido = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                int idcadete = ((CadeteBLL)this.comboBoxCadete.SelectedItem).Idcadete;

                CadeteBLL cadete = new CadeteBLL();

                cadete.AsignarCadete(idpedido, idcadete);

                PedidoBLL pedido = new PedidoBLL();

                this.dataGridView1.DataSource = pedido.CargarPedidosActivos(this.idusuario);

            }
            else
            {

                MessageBox.Show("Debe seleccionar un cadete", "Asignar Cadete");

            }

        }

    }

}
