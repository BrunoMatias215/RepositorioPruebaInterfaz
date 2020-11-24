using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;

namespace SeccionesFormularios
{
    public partial class SubSeccionCrearPedidos : Form
    {

        private int idusuario;

        public SubSeccionCrearPedidos(int pidusuario)
        {

            InitializeComponent();

            this.idusuario = pidusuario;

        }

        public int Idusuario { get => idusuario; set => idusuario = value; }

        private void SubSeccionPedidos_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;

            this.BackColor = Color.FromArgb(20, 34, 56);

            this.panel1.BackColor = Color.FromArgb(48, 58, 105);

            this.label1.ForeColor = Color.White;

            this.label2.ForeColor = Color.White;

            this.BotonConsultarPrecio.ForeColor = Color.White;

            this.BotonConsultarPrecio.BackColor = Color.FromArgb(98, 104, 140);

            this.BotonAgregarProducto.ForeColor = Color.White;

            this.BotonAgregarProducto.BackColor = Color.FromArgb(98, 104, 140);

            this.label3.ForeColor = Color.White;

            this.label4.ForeColor = Color.White;

            this.label5.ForeColor = Color.White;

            this.label6.ForeColor = Color.White;

            this.label7.ForeColor = Color.White;

            this.BotonCrearPedido.ForeColor = Color.White;

            this.BotonCrearPedido.BackColor = Color.FromArgb(98, 104, 140);

            this.Total.ForeColor = Color.White;

            this.BotonBorrarProducto.BackColor = Color.Red;

            this.ListaDeProductos.DisplayMember = "descripcion";

            this.comboBoxClientes.DisplayMember = "apellido";

            this.comboBoxFormasDePago.DisplayMember = "descripcion";

            this.ListaDeDetallesPedidos.DisplayMember = "informacion";

            this.comboBoxCantidad.Text = "";

            this.labelImporte.ForeColor = Color.White;

            this.Total.ForeColor = Color.White;

            for (int i = 1; i <= 10; i++)
            {

                this.comboBoxCantidad.Items.Add(i);

            }

            // Clientes

            CapaDeNegocios.ClienteBLL cliente = new CapaDeNegocios.ClienteBLL();

            List<ClienteBLL> clientesacargar = new List<ClienteBLL>();

            clientesacargar = cliente.CargarClientes();

            foreach (ClienteBLL lineacliente in clientesacargar)
            {

                this.comboBoxClientes.Items.Add(lineacliente);

            }
   
            // Formas de Pago

            CapaDeNegocios.FormaDePagoBLL formadepago = new CapaDeNegocios.FormaDePagoBLL();

            List<FormaDePagoBLL> formasdepagoaaagregar = new List<FormaDePagoBLL>();

            formasdepagoaaagregar = formadepago.CargarFormasDePago();

            foreach (FormaDePagoBLL lineaformadepago in formasdepagoaaagregar)
            {

                this.comboBoxFormasDePago.Items.Add(lineaformadepago);

            }

        }

        private void BotonEntradas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarEntradas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonConsultarPrecio_Click(object sender, EventArgs e)
        {

            if (this.ListaDeProductos.SelectedItem != null)
            {
  
                ProductoBLL entrada = (ProductoBLL)this.ListaDeProductos.SelectedItem;

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

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarOmelletes();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonTortillas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarTortillas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonMilanesas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarMilanesas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }


        }

        private void BotonSupremas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarSupremas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonMatambre_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarMatambre();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonGuarnicion_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarGuarnicion();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPollos_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarPollos();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonParillas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarParillas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPescados_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarPescados();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEnsaladas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarEnsaladas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEnsaladasEsp_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarEnsaladasEsp();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonTradicionales_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarTradicionales();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEspecialesI_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarEspecialesI();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEspecialesII_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarEspecialesII();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEspecialesEnFugazza_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarFugazzas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEspecialesEnFugazzeta_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarFugazzetas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonCalzones_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarCalzones();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonOtrasEspeciales_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarOtrasEspecialidades();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonEmpanadas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarEmpanadas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonSandwiches_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarSandwiches();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPastas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarPastas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonBebidas_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarBebidas();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPostres_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarPostres();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonMenus_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarMenus();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonPromos_Click(object sender, EventArgs e)
        {

            this.ListaDeProductos.Items.Clear();

            CapaDeNegocios.ProductoBLL producto = new ProductoBLL();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            productosacargar = producto.CargarPromos();

            foreach (ProductoBLL lineaproducto in productosacargar)
            {

                this.ListaDeProductos.Items.Add(lineaproducto);

            }

        }

        private void BotonAgregarProducto_Click(object sender, EventArgs e)
        {

            if (this.comboBoxCantidad.SelectedItem != null && this.ListaDeProductos.SelectedItem != null)
            {

                int idproducto = ((ProductoBLL)this.ListaDeProductos.SelectedItem).Idproducto;

                string descripcion = ((ProductoBLL)this.ListaDeProductos.SelectedItem).Descripcion;

                int cantidad = int.Parse(this.comboBoxCantidad.Text);

                int precioventa = ((ProductoBLL)this.ListaDeProductos.SelectedItem).Precio * cantidad;

                string informacion = descripcion + " " + "(" + cantidad + ")" + "  " + precioventa;

                DetallePedidoBLL detallepedido = new DetallePedidoBLL(idproducto, cantidad, precioventa, informacion);

                this.ListaDeDetallesPedidos.Items.Add(detallepedido);

                this.comboBoxCantidad.SelectedItem = this.comboBoxCantidad.Items[0];

                this.ListaDeProductos.ClearSelected();

                int acumuladorprecio = 0;

                foreach (DetallePedidoBLL detallepedidolocal in this.ListaDeDetallesPedidos.Items)
                {

                    int preciodetallepedido = detallepedidolocal.Precioventa;

                    acumuladorprecio += preciodetallepedido;

                }

                this.Total.Text = acumuladorprecio.ToString();

                this.comboBoxCantidad.SelectedItem = null;

                this.comboBoxCantidad.Text = "";

            }
            else
            {

                if (this.comboBoxCantidad.SelectedItem == null)
                {

                    MessageBox.Show("No se ha especificado la cantidad del producto", "Agregar Producto");

                }
                else
                {

                    MessageBox.Show("No se ha seleccionado un producto para agregar al pedido", "Agregar Producto");

                }

            }

        }

        private void BotonBorrarProducto_Click(object sender, EventArgs e)
        {

            int acumuladorprecio = 0;

            if (this.ListaDeDetallesPedidos.SelectedItem != null && this.ListaDeDetallesPedidos.Items.Count > 0)
            {

                this.ListaDeDetallesPedidos.Items.Remove(this.ListaDeDetallesPedidos.SelectedItem);

                foreach (DetallePedidoBLL detallepedidolocal in this.ListaDeDetallesPedidos.Items)
                {

                    int preciodetallepedido = detallepedidolocal.Precioventa;

                    acumuladorprecio += preciodetallepedido;

                }

                this.Total.Text = acumuladorprecio.ToString();

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
                else if (this.comboBoxFormasDePago.SelectedItem == null)
                {

                    MessageBox.Show("No se especificó la forma de pago del pedido", "Error");

                }
                else
                {

                    // Pedido

                    CapaDeNegocios.PedidoBLL pedido = new CapaDeNegocios.PedidoBLL();

                    pedido.Idcliente = ((ClienteBLL)this.comboBoxClientes.SelectedItem).Idcliente;

                    pedido.Idformadepago = ((FormaDePagoBLL)this.comboBoxFormasDePago.SelectedItem).Idformadepago;

                    pedido.Idusuario = this.idusuario;

                    pedido.Observaciones = this.Observaciones.Text;

                    pedido.Idcadete = 1;

                    pedido.Idestadocategoria = 1;

                    pedido.Total = int.Parse(this.Total.Text);

                    int valorcrearpedido = pedido.CrearPedido();

                    // Detalle Pedido

                    foreach (DetallePedidoBLL detallepedidolocal in this.ListaDeDetallesPedidos.Items)
                    {

                        CapaDeNegocios.DetallePedidoBLL detallepedido = new CapaDeNegocios.DetallePedidoBLL();

                        detallepedido.Idproducto = detallepedidolocal.Idproducto;

                        detallepedido.Idpedido = int.Parse(detallepedido.getReferenciaIdPedido().Rows[0][0].ToString());

                        detallepedido.Cantidad = detallepedidolocal.Cantidad;

                        detallepedido.Precioventa = detallepedidolocal.Precioventa;

                        int valordetallepedido = detallepedido.CrearDetallePedido();

                    }

                    this.comboBoxCantidad.SelectedItem = null;

                    this.comboBoxCantidad.Text = "";

                    this.ListaDeProductos.SelectedItem = null;

                    this.ListaDeProductos.Items.Clear();

                    this.ListaDeDetallesPedidos.Items.Clear();

                    this.comboBoxClientes.SelectedItem = null;

                    this.comboBoxClientes.Text = "";

                    this.comboBoxFormasDePago.SelectedItem = null;

                    this.comboBoxClientes.Text = "";

                    this.Observaciones.Text = "";

                    this.Total.Text = "0";

                    //this.ConfigurarComanda();



                    MessageBox.Show("Se ha creado el pedido", "Crear Pedido");

                }

            }
            else
            {

                MessageBox.Show("No se agregaron productos para crear el pedido", "Error");

            }

            this.ConfigurarDocumento();

        }

        private void ConfigurarDocumento()
        {

            Comanda = new System.Drawing.Printing.PrintDocument();

            PrinterSettings printersettings = new PrinterSettings();

            Comanda.PrinterSettings = printersettings;

            Comanda.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 100, 100);

            Comanda.PrintPage += Imprimir;

            Comanda.Print();

        }

        private void Imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Fuentes

            Font primerfuente = new Font("Bell MT", 16, FontStyle.Bold);

            Font segundafuente = new Font("Arial", 30, FontStyle.Regular);

            Font tercerafuente = new Font("Arial", 18, FontStyle.Regular);

            e.Graphics.DrawString("Comandas - Guilerova Solutions", primerfuente, Brushes.CadetBlue, new PointF(0, 0));

            e.Graphics.DrawString("Che Miranda", segundafuente, Brushes.Black, new PointF(0, 50));

            e.Graphics.DrawString("Comanda", tercerafuente, Brushes.Black, new PointF(0, 120));

            e.Graphics.DrawString("______________________________", primerfuente, Brushes.Black, new PointF(0, 120));

        }

    }
    }





