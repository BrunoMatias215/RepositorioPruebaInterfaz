using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocios
{

    public class PedidoBLL
    {

        private int idformadepago;

        private int idcliente;

        private int idusuario;

        private string observaciones;

        private int idcadete;

        private int idestadocategoria;

        public PedidoBLL()
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

            CapaDeDatos.PedidosDAL pedido = new CapaDeDatos.PedidosDAL();

            cantidaddefilarafectadas = pedido.CrearPedido(this.Idformadepago, this.Idcliente, this.Idusuario, this.Observaciones, this.Idcadete, this.Idestadocategoria);

            return cantidaddefilarafectadas;

        }

        public DataTable CargarPedidosActivos()
        {

            CapaDeDatos.PedidosDAL pedidodal = new CapaDeDatos.PedidosDAL();

            DataTable tablapedidosactivos = pedidodal.BuscarPedidosActivos();

            return tablapedidosactivos;

        }

        public void ModificarEstadoPedido (int idpedido, int idestadocategoria)
        {

            PedidosDAL pedido = new PedidosDAL();

            pedido.ModificarEstadoPedido(idpedido, idestadocategoria);

        }

    }

}
