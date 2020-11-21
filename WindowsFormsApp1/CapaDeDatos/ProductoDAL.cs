using System;
using System.Collections.Generic;
using System.Data;
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

    }

}
