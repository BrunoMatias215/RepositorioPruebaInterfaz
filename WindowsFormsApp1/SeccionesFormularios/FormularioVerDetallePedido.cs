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

    public partial class FormularioVerDetallePedido : Form
    {

        private List<DetallePedidoBLL> listadetallespedidos;

        public FormularioVerDetallePedido(List<DetallePedidoBLL> plistadetallespedidos)
        {

            InitializeComponent();

            this.listadetallespedidos = plistadetallespedidos;

        }

        public List<DetallePedidoBLL> Listadetallespedidos { get => listadetallespedidos; set => listadetallespedidos = value; }

        private void FormularioVerDetallePedido_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.label1.ForeColor = Color.White;

            this.BotonAceptar.ForeColor = Color.White;

            this.BotonAceptar.BackColor = Color.FromArgb(98, 104, 140);

            foreach (DetallePedidoBLL detallepedido in this.listadetallespedidos)
            {

                this.Height = this.Height + 65;

            }

            foreach (DetallePedidoBLL detallepedido in this.listadetallespedidos)
            {

                this.label1.Text = this.label1.Text + "ID Detalle Pedido: " + detallepedido.Iddetallepedido + "\nProducto: " +
                    detallepedido.Producto + "\nCantidad: " + detallepedido.Cantidad + "\nPrecio Venta: " + detallepedido.Precioventa+"\n"+Environment.NewLine;

            }

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

    }

}
