using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class CategoriaProductoBLL
    {

        private int idcategoriaproducto;

        private string nombre;

        public CategoriaProductoBLL(int pidcategoriaproducto, string pnombre)
        {

            this.Idcategoriaproducto = pidcategoriaproducto;

            this.Nombre = pnombre;

        }

        public int Idcategoriaproducto { get => idcategoriaproducto; set => idcategoriaproducto = value; }

        public string Nombre { get => nombre; set => nombre = value; }

    }

}
