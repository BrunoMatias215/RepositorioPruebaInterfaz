using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class Cadete
    {

        private int idcadete;

        private string nombre;

        private string apellido;

        private int telefono;

        private Rodado rodado;

        public Cadete(int pidcadete, string pnombre, string papellido, int ptelefono, Rodado prodado)
        {

            this.Idcadete = pidcadete;

            this.Nombre = pnombre;

            this.Apellido = papellido;

            this.Telefono = ptelefono;

            this.Rodado = prodado;

        }

        public Cadete ()
        {



        }

        public int Idcadete { get => idcadete; set => idcadete = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public int Telefono { get => telefono; set => telefono = value; }

        public Rodado Rodado { get => rodado; set => rodado = value; }

        public List<Cadete> CargarCadeteYRodado()
        {

            CapaDeDatos.Cadete cadetedal = new CapaDeDatos.Cadete();

            DataTable tablacadeteyrodado = cadetedal.BuscarCadeteYRodado();

            List<Cadete> cadeteyrodadoacargar = new List<Cadete>();

            foreach (DataRow fila in tablacadeteyrodado.Rows)
            {

                int idcadete;

                string nombre;

                string apellido;

                int telefono;

                idcadete = int.Parse(fila["idcadete"].ToString());

                nombre = fila["nombre"].ToString();

                apellido = fila["apellido"].ToString();

                telefono = int.Parse(fila["telefono"].ToString());

                int idrodado;

                string descripcion;

                string patente;

                idrodado = int.Parse(fila["idrodado"].ToString());

                descripcion = fila["descripcion"].ToString();

                patente = fila["patente"].ToString();

                Rodado rodado = new Rodado(idrodado, descripcion, patente);

                Cadete cadete = new Cadete(idcadete, nombre, apellido, telefono, rodado);

                cadeteyrodadoacargar.Add(cadete);

            }

            return cadeteyrodadoacargar;

        }


    }

}
