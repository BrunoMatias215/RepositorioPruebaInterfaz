using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{

    public class DetallePedidoDAL
    {

        public void CrearDetallePedido(int pidproducto, int pidpedido, int pcantidad, int pprecioventa)
        {

            SqlParameter[] parametros = new SqlParameter[4];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idproducto", pidproducto.ToString());

            parametros[1] = objetoconexion.CrearParametro("@idpedido", pidpedido.ToString());

            parametros[2] = objetoconexion.CrearParametro("@cantidad", pcantidad.ToString());

            parametros[3] = objetoconexion.CrearParametro("@precioventa", pprecioventa.ToString());
   
            objetoconexion.EscribirPorStoreProcedure("SPCrearDetallePedido", parametros);

            objetoconexion.Desconectar();

        }

        public DataTable getReferenciaIdPedido()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LecturaPorComando("select top 1 idpedido as MayorID from pedido order by idpedido desc");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarDetallePedidoSegunPedido(int pidpedido)
        {

            SqlParameter[] parametros = new SqlParameter[1];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idpedido", pidpedido.ToString());

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedureConParametros("SPBuscarDetallePedidoSegunPedido", parametros);

            objetoconexion.Desconectar();

            return objetotabla;

        }

    }

}
