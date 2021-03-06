﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{

    public class PedidoDAL
    {

        public int CrearPedido(int pidformadepago, int pidcliente, int pidusuario, 
            string pobservaciones, int pidcadete, int pidestadocategoria, int ptotal)
        {
  
            int Filasafectadas = 1;

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            objetoconexion.EscrituraPorComando("INSERT INTO Pedido (idformadepago, idcliente, idusuario, fechayhora, observaciones, idcadete, idestadocategoria, total) VALUES (" +
                pidformadepago + "," + pidcliente + "," + pidusuario + ", CURRENT_TIMESTAMP ,'" + pobservaciones + "'," + pidcadete + ", "+ pidestadocategoria + "," + ptotal+ ")");

            objetoconexion.Desconectar();

            return Filasafectadas;

        }

        public DataTable BuscarPedidosActivos()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarPedidosActivos");

            objetoconexion.Desconectar();   

            return objetotabla;

        }

        public void ModificarEstadoPedido(int pidpedido, int pidestadocategoria)
        {

            SqlParameter[] parametros = new SqlParameter[2];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idpedido", pidpedido.ToString());

            parametros[1] = objetoconexion.CrearParametro("@idestadocategoria", pidestadocategoria.ToString());

            objetoconexion.EscribirPorStoreProcedure("SPModificarEstadoPedido", parametros);

            objetoconexion.Desconectar();

        }

        public DataTable BuscarPedidosSegunCliente(int pidcliente)
        {

            SqlParameter[] parametros = new SqlParameter[1];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idcliente", pidcliente.ToString());

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedureConParametros("SPBuscarPedidosSegunCliente", parametros);

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarPedidosdeldia()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarPedidopordia");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarPedidosSegunMesAño(int mes, int año)
        {

            SqlParameter[] parametros = new SqlParameter[2];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@mes", mes.ToString());
            parametros[1] = objetoconexion.CrearParametro("@año", año.ToString());

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedureConParametros("BuscarPedidoporMesAño", parametros);

            objetoconexion.Desconectar();

            return objetotabla;

        }

    }

}
