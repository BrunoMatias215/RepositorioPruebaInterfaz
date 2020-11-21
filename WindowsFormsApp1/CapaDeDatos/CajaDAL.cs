using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CajaDAL
    {

        public DataTable BuscarCaja()
        {

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            DataTable objetotabla = objetoconexion.LeerPorStoreProcedure("SPCargarCajas");

            //DataTable objetotabla = objetoconexion.LecturaPorComando("SELECT * FROM Producto WHERE idproductocategoria = 1");

            objetoconexion.Desconectar();

            return objetotabla;

        }

        //public void CrearCaja(int pidusuario, int efectivocaja, int posnetcaja, DateTime fechayhora, int efectivoinicial, int estado)
        //{
        //    int fecha = 101010;
        //    SqlParameter[] parametros = new SqlParameter[6 ];

        //    Conexion objetoconexion = new Conexion();

        //    objetoconexion.Conectar();

        //    parametros[0] = objetoconexion.CrearParametro("@idusuario", pidusuario.ToString());

        //    parametros[1] = objetoconexion.CrearParametro("@efectivocaja", efectivocaja.ToString());
        //    parametros[2] = objetoconexion.CrearParametro("@posnetcaja", posnetcaja.ToString());
        //    parametros[3] = objetoconexion.CrearParametro("@fechayhora", "CURRENT_TIMESTAMP");
        //    parametros[4] = objetoconexion.CrearParametro("@efectivoinicial", efectivoinicial.ToString());
        //    parametros[5] = objetoconexion.CrearParametro("@estado", estado.ToString());

        //    objetoconexion.EscribirPorStoreProcedure("SPCrearCaja", parametros);    

        //    objetoconexion.Desconectar();

        //}

        public void CrearCaja(int pidusuario, int efectivocaja, int posnetcaja, DateTime fechayhora, int efectivoinicial, int estado)
        {
           
            

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();



            objetoconexion.EscrituraPorComando("insert into caja  values("+pidusuario+", "+ efectivocaja + ", "+posnetcaja+", CURRENT_TIMESTAMP, "+ efectivoinicial+", "+estado+")");

            objetoconexion.Desconectar();

        }




    }



}
