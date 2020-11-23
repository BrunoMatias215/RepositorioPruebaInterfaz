using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{

    public class ProductoDAL
    {

        public DataTable BuscarEntradas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarEntradas");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarOmelletes ()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarOmelletes");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarTortillas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarTortillas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarMilanesas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarMilanesas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarSupremas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarSupremas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarMatambre()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarMatambre");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarGuarnicion()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarGuarnicion");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarPollos()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarPollos");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarParillas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarParillas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarPescados()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarPescados");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarEnsaladas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarEnsaladas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarEnsaladasEsp()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarEnsaladasEsp");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarTradicionales()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarTradicionales");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarEspecialesI()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarEspecialesI");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarEspecialesII()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarEspecialesII");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarFugazzas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarFugazzas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarFugazzetas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarFugazzetas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarCalzones()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarCalzones");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarOtrasEspecialidades()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarOtrasEspecialidades");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarEmpanadas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarEmpanadas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarSandwiches()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarSandwiches");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarPastas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarPastas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarBebidas()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarBebidas");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarPostres()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarPostres");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarMenus()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarMenus");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable BuscarPromos()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarPromos");

            objetoconexion.Desconectar();

            return objetotabla;

        }
        public DataTable BuscarTodo()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscartodoslosproductos");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        public DataTable FiltroProductos(string pfiltro)
        {

            SqlParameter[] parametros = new SqlParameter[1];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@filtro", pfiltro);

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedureConParametros("SPFiltroProductoPorNombreYCategoria", parametros);

            objetoconexion.Desconectar();

            return objetotabla;

        }
        public void CrearProducto(string pdescripcion, int idproductocategoria, int pprecio)
        {

            SqlParameter[] parametros = new SqlParameter[3];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@descripcion", pdescripcion.ToString());

            parametros[1] = objetoconexion.CrearParametro("@idproductocategoria", idproductocategoria.ToString());

            parametros[2] = objetoconexion.CrearParametro("@precio", pprecio.ToString());

          

            objetoconexion.EscribirPorStoreProcedure("SPCrearProducto", parametros);

            objetoconexion.Desconectar();

        }

        public void ModificarProducto(int pidproducto, string pnombre, int categoria, int precio)
        {

            SqlParameter[] parametros = new SqlParameter[4];

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            parametros[0] = objetoconexion.CrearParametro("@idproducto", pidproducto.ToString());

            parametros[1] = objetoconexion.CrearParametro("@nombre", pnombre);

            parametros[2] = objetoconexion.CrearParametro("@idproductocategoria ", categoria.ToString());

            parametros[3] = objetoconexion.CrearParametro("@precio", precio.ToString());

            objetoconexion.EscribirPorStoreProcedure("SPModificarProducto", parametros);

            objetoconexion.Desconectar();

        }

    }

}
