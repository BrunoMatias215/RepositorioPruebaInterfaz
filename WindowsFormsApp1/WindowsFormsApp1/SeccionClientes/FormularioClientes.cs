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

    public partial class FormularioClientes : Form
    {

        public FormularioClientes()
        {

            InitializeComponent();

        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.CentrarElemento(this, this.panel1);

            this.labelBúsquedaClientes.ForeColor = Color.White;

            this.textBox1.BackColor = Color.FromArgb(20, 34, 56);

            this.BotonNuevoCliente.ForeColor = Color.White;

            this.BotonNuevoCliente.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonModificarCliente.ForeColor = Color.White;

            this.BotonModificarCliente.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonEliminarCliente.ForeColor = Color.White;

            this.BotonEliminarCliente.BackColor = Color.FromArgb(98, 104, 140);

            this.labelPedido.ForeColor = Color.White;

            this.labelDetallePedido.ForeColor = Color.White;

            // Clientes

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

            ClienteBLL cliente = new ClienteBLL();

            this.dataGridView1.DataSource = cliente.CargarClientesDataTable();

            // Pedidos

            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridView2.AllowUserToAddRows = false;

            this.dataGridView2.AllowUserToDeleteRows = false;

            this.dataGridView2.AllowUserToResizeRows = false;

            this.dataGridView2.AllowUserToOrderColumns = false;

            this.dataGridView2.AllowUserToResizeColumns = false;

            this.dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView2.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView2.BackgroundColor = Color.Lavender;

            // Productos

            this.dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridView3.AllowUserToAddRows = false;

            this.dataGridView3.AllowUserToDeleteRows = false;

            this.dataGridView3.AllowUserToResizeRows = false;

            this.dataGridView3.AllowUserToOrderColumns = false;

            this.dataGridView3.AllowUserToResizeColumns = false;

            this.dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView3.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView3.BackgroundColor = Color.Lavender;

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

        private void BotonNuevoCliente_Click(object sender, EventArgs e)
        {

            FormularioCrearCliente formulariocrearcliente = new FormularioCrearCliente();

            formulariocrearcliente.ShowDialog();

            ClienteBLL cliente = new ClienteBLL();

            this.dataGridView1.DataSource = cliente.CargarClientesDataTable();

        }

        private void BotonEliminarCliente_Click(object sender, EventArgs e)
        {

            ClienteBLL cliente = new ClienteBLL();

            if (this.dataGridView1.SelectedRows.Count > 0)
            {

                int idcliente = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                cliente.EliminarCliente(idcliente);

                this.dataGridView1.DataSource = cliente.CargarClientesDataTable();

            }
            else
            {

                MessageBox.Show("Debe seleccionar un cliente para eliminarlo", "Eliminar Cliente");

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ClienteBLL cliente = new ClienteBLL();

            if (this.textBox1.Text.Length != 0)
            {

                this.dataGridView1.DataSource = cliente.BuscarClientePorNombre(this.textBox1.Text);

            }
            else
            {

                this.dataGridView1.DataSource = cliente.CargarClientesDataTable();

            }

        }

        private void BotonModificarCliente_Click(object sender, EventArgs e)
        {

            int idcliente, telefono;

            string nombre, apellido, direccion;

            idcliente = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            telefono = int.Parse(this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            nombre = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            apellido = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            direccion = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            ClienteBLL cliente = new ClienteBLL(idcliente, nombre, apellido, telefono, direccion);

            FormularioModificarCliente formulariomodificarcliente = new FormularioModificarCliente(cliente);

            formulariomodificarcliente.ShowDialog();

            this.dataGridView1.DataSource = cliente.CargarClientesDataTable();

        }

    }

}
