using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{

    public class FormaDePagoDAL
    {

        public DataTable BuscarFormasDePago()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPBuscarFormasDePago");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }

    }

}
