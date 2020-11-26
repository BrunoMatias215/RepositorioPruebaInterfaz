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

    public partial class SubSeccionInformes : Form
    {
        
        public SubSeccionInformes()
        {

            InitializeComponent();

        }

        private void SubSeccionInformes_Load(object sender, EventArgs e)
        {

            List<string> mes = new List<string>();
            mes.Add("Enero");
            mes.Add("Febrero");
            mes.Add ("Marzo");
            mes.Add ("Abril");
            mes.Add ("Mayo");
            mes.Add ("Junio");
            mes.Add ("Julio");
            mes.Add ("Agosto");
            mes.Add ("Septiembre");
            mes.Add ("Octubre");
            mes.Add ("Noviembre");
            mes.Add ("Diciembre");
            comboBoxAño.Items.Add(2020);
            comboBoxAño.Items.Add(2021);
            comboBoxAño2.Items.Add(2020);
            comboBoxAño2.Items.Add(2021);

            foreach (string m in mes)
            {
                comboBoxMes.Items.Add(m);
                comboBoxMes2.Items.Add(m);

            }

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.CentrarElemento(this, this.panel2);

            this.label1.ForeColor = Color.White;

            this.BotonVerPedidos.ForeColor = Color.White;

            this.BotonVerPedidos.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonVerProductos.ForeColor = Color.White;

            this.BotonVerProductos.BackColor = Color.FromArgb(98, 104, 140);

            this.label1.ForeColor = Color.White;

            this.radioButtonDiario.ForeColor = Color.White;

            this.radioButtonMensual.ForeColor = Color.White;

            this.label2.ForeColor = Color.White;

            this.label3.ForeColor = Color.White;

            this.label4.ForeColor = Color.White;

            this.labeltotal.ForeColor = Color.White;

            this.label5.ForeColor = Color.White;

            this.radioDiaro2.ForeColor = Color.White;

            this.radioMensual2.ForeColor = Color.White;

            this.label6.ForeColor = Color.White;

            this.label7.ForeColor = Color.White;

            // Pedidos

            this.gridPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.gridPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.gridPedidos.AllowUserToAddRows = false;

            this.gridPedidos.AllowUserToDeleteRows = false;

            this.gridPedidos.AllowUserToResizeRows = false;

            this.gridPedidos.AllowUserToOrderColumns = false;

            this.gridPedidos.AllowUserToResizeColumns = false;

            this.gridPedidos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.gridPedidos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.gridPedidos.ReadOnly = true;

            this.gridPedidos.BackgroundColor = Color.Lavender;

            // Productos

            this.gridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.gridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.gridProductos.AllowUserToAddRows = false;

            this.gridProductos.AllowUserToDeleteRows = false;

            this.gridProductos.AllowUserToResizeRows = false;

            this.gridProductos.AllowUserToOrderColumns = false;

            this.gridProductos.AllowUserToResizeColumns = false;

            this.gridProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.gridProductos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.gridProductos.ReadOnly = true;

            this.gridProductos.BackgroundColor = Color.Lavender;

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

        private void radioButtonDiario_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMes.Enabled = false;
            comboBoxAño.Enabled = false;

        }

        private void radioButtonMensual_CheckedChanged(object sender, EventArgs e)
        {


            comboBoxMes.Enabled = true;
            comboBoxAño.Enabled = true;
        }

        private void radioDiaro2_CheckedChanged(object sender, EventArgs e)
        {


            comboBoxMes2.Enabled = false;
            comboBoxAño2.Enabled = false;
        }

        private void BotonVerPedidos_Click(object sender, EventArgs e)
        {
            //Diario
            if (radioButtonDiario.Checked)
            {

                PedidoBLL pedido = new PedidoBLL();
                gridPedidos.DataSource = pedido.CargarPedidosdeldia();

                int total = 0;
                foreach (DataGridViewRow fila in gridPedidos.Rows)
                {



                    total = total + int.Parse(fila.Cells[8].Value.ToString());
                }
                labeltotal.Text = total.ToString();



            }
            //Mensual

            if (radioButtonMensual.Checked )
            {
                if (comboBoxMes.SelectedItem==null || comboBoxAño.SelectedItem==null)
                {

                    MessageBox.Show("Seleccione una fecha correcta");

                }
                else
                {
                    int mes = comboBoxMes.SelectedIndex + 1;
                    int año = int.Parse(comboBoxAño.SelectedItem.ToString());
                    


                    PedidoBLL pedido = new PedidoBLL();

                    gridPedidos.DataSource = pedido.CargarPedidosporMesAño(mes, año);

                    int total = 0;
                    foreach (DataGridViewRow fila in gridPedidos.Rows)
                    {

                       

                        total = total + int.Parse(fila.Cells[8].Value.ToString());
                    }
                    labeltotal.Text = total.ToString();

                }

            }
        }

        private void BotonVerProductos_Click(object sender, EventArgs e)
        {
            //Diario
            if (radioDiaro2.Checked)
            {

                ProductoBLL producto = new ProductoBLL();
                gridProductos.DataSource = producto.CargarProductoMasVendidoDia();

               



            }
            //Mensual

            if (radioMensual2.Checked)
            {
                if (comboBoxMes2.SelectedItem == null || comboBoxAño2.SelectedItem == null)
                {

                    MessageBox.Show("Seleccione una fecha correcta");

                }
                else
                {
                    int mes = comboBoxMes2.SelectedIndex + 1;
                    int año = int.Parse(comboBoxAño2.SelectedItem.ToString());



                    ProductoBLL producto = new ProductoBLL();

                    gridProductos.DataSource = producto.CargarProductoMasVendidoMesAño(mes, año);

                    int total = 0;
                    foreach (DataGridViewRow fila in gridPedidos.Rows)
                    {



                        total = total + int.Parse(fila.Cells[8].Value.ToString());
                    }
                    labeltotal.Text = total.ToString();

                }
            }
    }

        private void radioMensual2_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMes2.Enabled = true;
            comboBoxAño2.Enabled = true;
        }
    }
}
