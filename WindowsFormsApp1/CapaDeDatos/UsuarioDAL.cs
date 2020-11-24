using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class UsuarioDAL
    {

        public DataTable BuscarUsuario()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarUsuario");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarUsuariosincontraseña()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarUsuariosSinContraseña");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }


        public void CrearUsuario(string pnombre,string papellido,int cuil  , int contraseña, int idcategoriausuario)
        {

          

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            objetoconexion.EscrituraPorComando("insert into Usuario(nombre, apellido, CUIL, contraseña, fechadecontratacion, idcategoriausuario)" +
                "values('"+ pnombre+"', '" + papellido + "', "+ cuil + ", "+ contraseña + ", CURRENT_TIMESTAMP,"+ idcategoriausuario + ")");


            objetoconexion.Desconectar();

        }


        public void ModificarUsuario(int pidusuario, string pnombre, string apellido, int CUIL, int contraseña, int idcategoria)
        {

            SqlParameter[] parametros = new SqlParameter[6];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idusuario", pidusuario.ToString());

            parametros[1] = objetoconexion.CrearParametro("@nombre", pnombre);

            parametros[2] = objetoconexion.CrearParametro("@apellido ", apellido);

            parametros[3] = objetoconexion.CrearParametro("@cuil", CUIL.ToString());
            parametros[4] = objetoconexion.CrearParametro("@contraseña", contraseña.ToString());
            parametros[5] = objetoconexion.CrearParametro("@idcategoriausuario", idcategoria.ToString());

            objetoconexion.EscribirPorStoreProcedure("SPModificarUsuario", parametros);

            objetoconexion.Desconectar();

        }


        public void EliminarUsuario(int pid)
        {

            SqlParameter[] parametros = new SqlParameter[1];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idusuario", pid.ToString());


            objetoconexion.EscribirPorStoreProcedure("SPEliminarUsuario", parametros);

            objetoconexion.Desconectar();

        }
    }
}

