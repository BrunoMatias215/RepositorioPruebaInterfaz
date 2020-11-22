using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{

    public class CadeteDAL
    {

        public DataTable BuscarCadetes()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarCadeteS");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarCadeteYRodado()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarCadeteS");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public void AsignarCadete(int pidpedido, int pidcadete)
        {

            SqlParameter[] parametros = new SqlParameter[2];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idpedido", pidpedido.ToString());

            parametros[1] = objetoconexion.CrearParametro("@idcadete", pidcadete.ToString());

            objetoconexion.EscribirPorStoreProcedure("SPAsignarCadete", parametros);

            objetoconexion.Desconectar();

        }

    }

}
