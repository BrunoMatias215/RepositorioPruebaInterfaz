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
    public partial class SubSeccionCrearPedidos : Form
    {

        private String informacion;

        public SubSeccionCrearPedidos()
        {

            InitializeComponent();

        }

        private void SubSeccionPedidos_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.ListaDeProductos.DisplayMember = "descripcion";

            this.comboBoxClientes.DisplayMember = "apellido";

            this.comboBoxCadetes.DisplayMember = "nombre";

            this.comboBoxFormasDePago.DisplayMember = "descripcion";

            this.ListaDeDetallesPedidos.DisplayMember = "informacion";

            this.comboBoxCantidad.Text = "1";

            for (int i = 1; i <= 10; i++)
            {

                this.comboBoxCantidad.Items.Add(i);

            }

            // Clientes

            CapaDeNegocios.Cliente cliente = new CapaDeNegocios.Cliente();

            List<Cliente> clientesacargar = new List<Cliente>();

            clientesacargar = cliente.CargarClientes();

            foreach (Cliente lineacliente in clientesacargar)
            {

                this.comboBoxClientes.Items.Add(lineacliente);

            }

            // Cadetes

            CapaDeNegocios.Cadete cadete = new CapaDeNegocios.Cadete();

            List<Cadete> cadetesacargar = new List<Cadete>();

            cadetesacargar = cadete.CargarCadeteYRodado();

            foreach (Cadete lineacadete in cadetesacargar)
            {

                this.comboBoxCadetes.Items.Add(lineacadete);

            }

            // Formas de Pago

            CapaDeNegocios.FormaDePago formadepago = new CapaDeNegocios.FormaDePago();

            List<FormaDePago> formasdepagoaaagregar = new List<FormaDePago>();

            formasdepagoaaagregar = formadepago.CargarFormasDePago();

            foreach (FormaDePago lineaformadepago in formasdepagoaaagregar)
            {

                this.comboBoxFormasDePago.Items.Add(lineaformadepago);

            }

        }

        private void BotonEntradas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarEntradas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonConsultarPrecio_Click(object sender, EventArgs e)
        {

            if (this.ListaDeProductos.SelectedItem != null)
            {
  
                Producto entrada = (Producto)this.ListaDeProductos.SelectedItem;

                int precio = entrada.Precio;

                MessageBox.Show("El precio es " + precio, "Ver Precio");

            }
            else
            {

                MessageBox.Show("No seleccionó ningun producto", "Ver Precio");

            }

        }

        private void BotonOmelletes_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarOmelletes();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonTortillas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarTortillas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonMilanesas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarMilanesas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }


        }

        private void BotonSupremas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarSupremas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonMatambre_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarMatambre();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonGuarnicion_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarGuarnicion();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPollos_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarPollos();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonParillas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarParillas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPescados_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarPescados();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEnsaladas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarEnsaladas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEnsaladasEsp_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarEnsaladasEsp();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonTradicionales_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarTradicionales();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEspecialesI_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarEspecialesI();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEspecialesII_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarEspecialesII();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEspecialesEnFugazza_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarFugazzas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEspecialesEnFugazzeta_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarFugazzetas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonCalzones_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarCalzones();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonOtrasEspeciales_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarOtrasEspecialidades();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEmpanadas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarEmpanadas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonSandwiches_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarSandwiches();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPastas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarPastas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonBebidas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarBebidas();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPostres_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarPostres();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonMenus_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarMenus();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPromos_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.Producto producto = new Producto();

            List<Producto> productosacargar = new List<Producto>();

            productosacargar = producto.CargarPromos();

            foreach (Producto lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonAgregarProducto_Click(object sender, EventArgs e)
        {

            if (this.comboBoxCantidad.SelectedItem == null || this.ListaDeProductos.SelectedItem == null)
            {

                MessageBox.Show("Faltan datos por completar.", "Agregar Producto");

            }
            else
            {

                int idproducto = ((Producto)this.ListaDeProductos.SelectedItem).Idproducto;
            
                string descripcion = ((Producto)this.ListaDeProductos.SelectedItem).Descripcion;

                int cantidad = int.Parse(this.comboBoxCantidad.Text);

                int precioventa = ((Producto)this.ListaDeProductos.SelectedItem).Precio * cantidad;

                String fechayhorastring = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                DateTime fechayhora = DateTime.Parse(fechayhorastring);

                string informacion = descripcion + " " + "(" + cantidad + ")" + "  " + precioventa;

                DetallePedido detallepedido = new DetallePedido(idproducto, cantidad, precioventa, fechayhora, informacion);

                this.ListaDeDetallesPedidos.Items.Add(detallepedido);

                this.comboBoxCantidad.SelectedItem = this.comboBoxCantidad.Items[0];

                this.ListaDeProductos.ClearSelected();

                int acumuladorprecio = 0;

                foreach (DetallePedido detallepedidolocal in this.ListaDeDetallesPedidos.Items)
                {

                    int preciodetallepedido = detallepedidolocal.Precioventa;

                    acumuladorprecio += preciodetallepedido;

                }

                this.Total.Text = "Total: " + acumuladorprecio.ToString();

                this.comboBoxCantidad.Text = "1";

            }

        }

        private void BotonBorrarProducto_Click(object sender, EventArgs e)
        {

            int acumuladorprecio = 0;

            if (this.ListaDeDetallesPedidos.SelectedItem != null && this.ListaDeDetallesPedidos.Items.Count > 0)
            {

                this.ListaDeDetallesPedidos.Items.Remove(this.ListaDeDetallesPedidos.SelectedItem);

                foreach (DetallePedido detallepedidolocal in this.ListaDeDetallesPedidos.Items)
                {

                    int preciodetallepedido = detallepedidolocal.Precioventa;

                    acumuladorprecio += preciodetallepedido;

                }

                this.Total.Text = "Total: " + acumuladorprecio.ToString();

            }
            else
            {

                MessageBox.Show("No ha seleccionado un detalle pedido o bien no hay items en la lista", "Error");

            }

        }

        private void BotonCrearPedido_Click(object sender, EventArgs e)
        {

            if (this.ListaDeDetallesPedidos.Items.Count > 0)
            {

                if (this.comboBoxClientes.SelectedItem == null)
                {

                    MessageBox.Show("No se especificó el cliente del pedido", "Error");

                }
                else if (this.comboBoxCadetes.SelectedItem == null)
                {

                    MessageBox.Show("No se especificó el cadete del pedido", "Error");

                }
                else if (this.comboBoxFormasDePago.SelectedItem == null)
                {

                    MessageBox.Show("No se especificó la forma de pago del pedido", "Error");

                }
                else
                {

                    // Pedido

                    CapaDeNegocios.Pedido pedido = new CapaDeNegocios.Pedido();

                    pedido.Idformadepago = ((FormaDePago)this.comboBoxFormasDePago.SelectedItem).Idformadepago;

                    pedido.Idcliente = ((Cliente)this.comboBoxClientes.SelectedItem).Idcliente;

                    pedido.Idusuario = 1;

                    pedido.Observaciones = this.Observaciones.Text;

                    pedido.Idcadete = ((Cadete)this.comboBoxCadetes.SelectedItem).Idcadete;

                    pedido.Idestadocategoria = 1;

                    int valorcrearpedido = pedido.CrearPedido();

                    // Detalle Pedido

                    foreach (DetallePedido detallepedidolocal in this.ListaDeDetallesPedidos.Items)
                    {

                        CapaDeNegocios.DetallePedido detallepedido = new CapaDeNegocios.DetallePedido();

                        detallepedido.Idproducto = detallepedidolocal.Idproducto;

                        detallepedido.Idpedido = int.Parse(detallepedido.getReferenciaIdPedido().Rows[0][0].ToString());

                        detallepedido.Cantidad = detallepedidolocal.Cantidad;

                        detallepedido.Precioventa = detallepedidolocal.Precioventa;

                        int valordetallepedido = detallepedido.CrearDetallePedido();

                        MessageBox.Show("Detalle pedido creado");

                    }
                    
                }

            }
            else
            {

                MessageBox.Show("No hay items para crear el pedido", "Error");

            }

        }

    }
}
