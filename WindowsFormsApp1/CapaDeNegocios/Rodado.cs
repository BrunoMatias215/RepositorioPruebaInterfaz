using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class Rodado
    {

        private int idrodado;

        private string descripcion;

        private string patente;

        public Rodado(int pidrodado, string pdescripcion, string ppatente)
        {

            this.Idrodado = pidrodado;

            this.Descripcion = pdescripcion;

            this.Patente = ppatente;

        }

        public Rodado ()
        {



        }

        public int Idrodado { get => idrodado; set => idrodado = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public string Patente { get => patente; set => patente = value; }

    }

}
