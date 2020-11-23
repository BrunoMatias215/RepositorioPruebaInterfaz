using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocios
{

    public class DetallePedidoBLL
    {

        private int iddetallepedido;

        private int idproducto;

        private int idpedido;

        private string producto;

        private int cantidad;

        private int precioventa;

        private string informacion;

        private DataTable referenciaIdPedido;

        public DetallePedidoBLL()
        {



        }

        public DetallePedidoBLL (int pidproducto, int pcantidad, int pprecioventa, string pinformacion)
        {

            this.idproducto = pidproducto;

            this.cantidad = pcantidad;

            this.precioventa = pprecioventa;

            this.informacion = pinformacion;

        }

        public DetallePedidoBLL (int piddetallepedido, int pidpedido, string pproducto, int pcantidad, int pprecioventa)
        {

            this.iddetallepedido = piddetallepedido;

            this.idpedido = pidpedido;

            this.producto = pproducto;

            this.cantidad = pcantidad;

            this.precioventa = pprecioventa;

        }

        public int Iddetallepedido { get => iddetallepedido; set => iddetallepedido = value; }

        public int Idproducto { get => idproducto; set => idproducto = value; }

        public int Idpedido { get => idpedido; set => idpedido = value; }

        public string Producto { get => producto; set => producto = value; }

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public int Precioventa { get => precioventa; set => precioventa = value; }

        public string Informacion { get => informacion; set => informacion = value; }

        public DataTable ReferenciaIdPedido { get => referenciaIdPedido; set => referenciaIdPedido = value; }
        
        public int CrearDetallePedido()
        {

            int cantidaddefilarafectadas = 0;

            CapaDeDatos.DetallePedidoDAL detallepedido = new CapaDeDatos.DetallePedidoDAL();

            detallepedido.CrearDetallePedido(this.idproducto, this.idpedido, this.cantidad, this.precioventa);

            return cantidaddefilarafectadas;

        }

        public DataTable getReferenciaIdPedido ()
        {

            CapaDeDatos.DetallePedidoDAL detallepedido = new CapaDeDatos.DetallePedidoDAL();

            this.referenciaIdPedido = detallepedido.getReferenciaIdPedido();

            return this.referenciaIdPedido;

        }

        public List<DetallePedidoBLL> CargarDetallePedidoSegunPedido (int pidpedido)
        {

            DetallePedidoDAL detallepedidodal = new DetallePedidoDAL();

            DataTable tabladetallepedidos = detallepedidodal.BuscarDetallePedidoSegunPedido(pidpedido);

            List<DetallePedidoBLL> detallespedidosaagregar = new List<DetallePedidoBLL>();

            foreach (DataRow fila in tabladetallepedidos.Rows)
            {

                int iddetallepedido = int.Parse(fila["ID Detalle Pedido"].ToString());

                int idpedido = int.Parse(fila["ID Pedido"].ToString());

                string producto = fila["Producto"].ToString();

                int cantidad = int.Parse(fila["Cantidad"].ToString());

                int precioventa = int.Parse(fila["Precio Venta"].ToString());

                DetallePedidoBLL detallepedido = new DetallePedidoBLL(iddetallepedido, idpedido, producto, cantidad, precioventa);

                detallespedidosaagregar.Add(detallepedido);

            }

            return detallespedidosaagregar;

        }

        public DataTable CargarTablaDetallePedidoSegunPedido (int pidpedido)
        {

            DetallePedidoDAL detallepedidodal = new DetallePedidoDAL();

            DataTable tabladetallepedidos = detallepedidodal.BuscarDetallePedidoSegunPedido(pidpedido);

            return tabladetallepedidos;

        }
 
    }

}
