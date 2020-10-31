using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class DetallePedido
    {

        private int iddetallepedido;

        private int idproducto;

        private int idpedido;

        private int cantidad;

        private int precioventa;

        private DateTime fechayhora;

        private string informacion;

        public DetallePedido (int pidproducto, int pcantidad, int pprecioventa, 
            DateTime pfechayhora, string pinformacion)
        {

            this.idproducto = pidproducto;

            this.cantidad = pcantidad;

            this.precioventa = pprecioventa;

            this.fechayhora = pfechayhora;

            this.Informacion = pinformacion;

        }

        public DetallePedido ()
        {



        }

        public int Iddetallepedido { get => iddetallepedido; set => iddetallepedido = value; }

        public int Idproducto { get => idproducto; set => idproducto = value; }

        public int Idpedido { get => idpedido; set => idpedido = value; }

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public int Precioventa { get => precioventa; set => precioventa = value; }

        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }

        public string Informacion { get => informacion; set => informacion = value; }

    }

}
