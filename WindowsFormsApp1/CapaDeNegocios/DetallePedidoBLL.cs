using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class DetallePedidoBLL
    {

        private int iddetallepedido;

        private int idproducto;

        private int idpedido;

        private int cantidad;

        private int precioventa;

        private DateTime fechayhora;

        private string informacion;

        private DataTable referenciaIdPedido;

        public DetallePedidoBLL(int pidproducto, int pcantidad, int pprecioventa,
            DateTime pfechayhora, string pinformacion)
        {

            this.idproducto = pidproducto;

            this.cantidad = pcantidad;

            this.precioventa = pprecioventa;

            this.fechayhora = pfechayhora;

            this.Informacion = pinformacion;

        }

        public DetallePedidoBLL()
        {



        }

        public int Iddetallepedido { get => iddetallepedido; set => iddetallepedido = value; }

        public int Idproducto { get => idproducto; set => idproducto = value; }

        public int Idpedido { get => idpedido; set => idpedido = value; }

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public int Precioventa { get => precioventa; set => precioventa = value; }

        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }

        public string Informacion { get => informacion; set => informacion = value; }

        public DataTable ReferenciaIdPedido { get => referenciaIdPedido; set => referenciaIdPedido = value; }

        public int CrearDetallePedido()
        {

            int cantidaddefilarafectadas = 0;

            CapaDeDatos.DetallePedido detallepedido = new CapaDeDatos.DetallePedido();

            detallepedido.CrearDetallePedido(this.idproducto, this.idpedido, this.cantidad, this.precioventa);

            return cantidaddefilarafectadas;

        }

        public DataTable getReferenciaIdPedido ()
        {

            CapaDeDatos.DetallePedido detallepedido = new CapaDeDatos.DetallePedido();

            this.referenciaIdPedido = detallepedido.getReferenciaIdPedido();

            return this.referenciaIdPedido;

        }
 
    }

}
