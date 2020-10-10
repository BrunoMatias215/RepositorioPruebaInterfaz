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

    }
}
