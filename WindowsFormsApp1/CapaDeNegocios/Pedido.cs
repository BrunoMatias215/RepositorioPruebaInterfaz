using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocios
{

    public class Pedido
    {

        private int idformadepago;

        private int idcliente;

        private int idusuario;

        private string observaciones;

        private int idcadete;

        private int idestadocategoria;

        public Pedido()
        {



        }

        public int Idformadepago { get => idformadepago; set => idformadepago = value; }

        public int Idcliente { get => idcliente; set => idcliente = value; }

        public int Idusuario { get => idusuario; set => idusuario = value; }

        public string Observaciones { get => observaciones; set => observaciones = value; }

        public int Idcadete { get => idcadete; set => idcadete = value; }

        public int Idestadocategoria { get => idestadocategoria; set => idestadocategoria = value; }

        public int CrearPedido()
        {

            int cantidaddefilarafectadas = 0;

            CapaDeDatos.PedidoDAL pedido = new CapaDeDatos.PedidoDAL();

            cantidaddefilarafectadas = pedido.CrearPedido(this.Idformadepago, this.Idcliente, this.Idusuario, this.Observaciones, this.Idcadete, this.Idestadocategoria);

            return cantidaddefilarafectadas;

        }

    }

}
