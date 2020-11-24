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



        public void CrearCadete(string pnombre, string papellido, int ptelefono, int plicencia)
        {

            SqlParameter[] parametros = new SqlParameter[4];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@nombre", pnombre.ToString());

            parametros[1] = objetoconexion.CrearParametro("@apellido", papellido.ToString());

            parametros[2] = objetoconexion.CrearParametro("@tel", ptelefono.ToString());

            parametros[3] = objetoconexion.CrearParametro("@licencia", plicencia.ToString());

            objetoconexion.EscribirPorStoreProcedure("SPCrearCadete", parametros);

            objetoconexion.Desconectar();



        }


        public DataTable BuscarCadetesReales()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarCadetesReales");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;


        }


        public void ModificarCadete(int idcadete, string pnombre, string apellido, int tel, int licencia)
        {

            SqlParameter[] parametros = new SqlParameter[5];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idcadete", idcadete.ToString());

            parametros[1] = objetoconexion.CrearParametro("@nombre", pnombre);

            parametros[2] = objetoconexion.CrearParametro("@apellido ", apellido);

            parametros[3] = objetoconexion.CrearParametro("@telefono", tel.ToString());
            parametros[4] = objetoconexion.CrearParametro("@licencia", licencia.ToString());


            objetoconexion.EscribirPorStoreProcedure("SPModificarCadete", parametros);

            objetoconexion.Desconectar();

        }


        public void EliminarCadete(int pid)
        {

            SqlParameter[] parametros = new SqlParameter[1];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idcadete", pid.ToString());


            objetoconexion.EscribirPorStoreProcedure("SPEliminarCadete", parametros);

            objetoconexion.Desconectar();

        }

    }
}   
