using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{

    public class ClienteDAL
    {

        public DataTable BuscarClientes()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarClientes");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public void CrearCliente(string pnombre , string papellido, int ptelefono, string pdireccion)
        {

            SqlParameter[] parametros = new SqlParameter[4];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@nombre", pnombre.ToString());

            parametros[1] = objetoconexion.CrearParametro("@apellido", papellido.ToString());

            parametros[2] = objetoconexion.CrearParametro("@telefono", ptelefono.ToString());

            parametros[3] = objetoconexion.CrearParametro("@direccion", pdireccion.ToString());

            objetoconexion.EscribirPorStoreProcedure("SPCrearCliente", parametros);

            objetoconexion.Desconectar();

        }

        public void EliminarCliente (int pidcliente)
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            objetoconexion.EscrituraPorComando("DELETE FROM Cliente WHERE idcliente = "+pidcliente);

            objetoconexion.Desconectar();

        }

        public DataTable BuscarClientePorNombre (string pnombre)
        {

            SqlParameter[] parametros = new SqlParameter[1];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@nombre", pnombre.ToString());

            DataTable tablacliente = objetoconexion.LeerPorStoreProcedureConParametros("SPBuscarClientePorNombre", parametros);

            objetoconexion.Desconectar();

            return tablacliente;

        }

        public void ModificarCliente(int pidcliente, string pnombre, string papellido, int ptelefono, string pdireccion)
        {

            SqlParameter[] parametros = new SqlParameter[5];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idcliente", pidcliente.ToString());

            parametros[1] = objetoconexion.CrearParametro("@nombre", pnombre.ToString());

            parametros[2] = objetoconexion.CrearParametro("@apellido", papellido.ToString());

            parametros[3] = objetoconexion.CrearParametro("@telefono", ptelefono.ToString());

            parametros[4] = objetoconexion.CrearParametro("@direccion", pdireccion.ToString());

            objetoconexion.EscribirPorStoreProcedure("SPModificarCliente", parametros);

            objetoconexion.Desconectar();

        }

    }

}
