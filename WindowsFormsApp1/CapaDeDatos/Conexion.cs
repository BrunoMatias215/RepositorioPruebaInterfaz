using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class Conexion
    {

        private SqlConnection objetoconexion;

        private string connectionstring = "";

        public Conexion()
        {



        }

        public SqlConnection Objetoconexion { get => objetoconexion; set => objetoconexion = value; }

        public string Connectionstring { get => connectionstring; set => connectionstring = value; }

        public void Conectar()
        {

            this.connectionstring = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = Che Miranda; Data Source =.\\SQLEXPRESS";
                                  
            this.objetoconexion = new SqlConnection();

            this.objetoconexion.ConnectionString = Connectionstring;

            this.objetoconexion.Open();

        }

        public void Desconectar()
        {

            this.objetoconexion.Close();

            this.objetoconexion.Dispose();

        }

        public void EscrituraPorComando(string pcomando)
        {

            SqlCommand objComando = new SqlCommand();

            try
            {

                objComando.CommandText = pcomando;

                objComando.CommandType = CommandType.Text;

                objComando.Connection = this.objetoconexion;

                objComando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;

            }

        }

        public DataTable LecturaPorComando(string pcomando)
        {

            DataTable objetotabla = new DataTable();

            SqlCommand objetocomando = new SqlCommand();

            try
            {

                objetocomando.CommandType = CommandType.Text;

                objetocomando.Connection = this.objetoconexion;

                objetocomando.CommandText = pcomando;

                SqlDataAdapter objAdaptador = new SqlDataAdapter(objetocomando);

                objAdaptador.Fill(objetotabla);

            }
            catch
            {

                objetotabla = null;

                throw;

            }

            return objetotabla;

        }

        public DataTable LeerPorStoreProcedure(string pNombreStoreProcedure)
        {

            //Instancio un objeto del tipo DataTable
            DataTable unaTabla = new DataTable();

            //Instancio un objeto del tipo SqlCommand
            SqlCommand objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {
                objComando.CommandText = pNombreStoreProcedure;

                objComando.CommandType = CommandType.StoredProcedure;

                objComando.Connection = this.objetoconexion;

                //Instancio un adaptador con el parametro SqlCommand
                SqlDataAdapter objAdaptador = new SqlDataAdapter(objComando);

                //Lleno la tabla, el objeto unaTabla con el adaptador
                objAdaptador.Fill(unaTabla);

            }
            catch (Exception)
            {
                //Como hay error... por el motivo que sea asigno el resultado a null
                unaTabla = null;

                throw;

            }
            finally
            {

                //Pase lo que pase me desconecto
                this.Desconectar();
            }


            return unaTabla;

        }

        public SqlParameter CrearParametro(string pNombre, string pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;

            objParametro.Value = pValor;

            objParametro.DbType = DbType.String;

            return objParametro;

        }

        public int EscribirPorStoreProcedure(string pTexto, SqlParameter[] pParametrosSql)
        {

            //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
            int filasAfectadas = 0;

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {

                objComando.CommandText = pTexto;

                objComando.CommandType = CommandType.StoredProcedure;

                objComando.Connection = this.objetoconexion;

                if (pParametrosSql.Length > 0)
                {

                    objComando.Parameters.AddRange(pParametrosSql);
                    //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                    filasAfectadas = objComando.ExecuteNonQuery();

                }
                else
                {
                    //retorno -1 porque la lista de parametros Sql tiene 0 ítems...
                    filasAfectadas = -1;

                }

            }
            catch (Exception)
            {
                filasAfectadas = -1;

                throw;

            }
            finally
            {

                //Me desconecto
                this.Desconectar();

            }

            return filasAfectadas;

        }

    }
}
