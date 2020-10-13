using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeLógicaDeNegocios
{

    public class CategoriaProducto
    {

        private int idcategoriaproducto;

        private string nombre;

        public CategoriaProducto (int pidcategoriaproducto, string pnombre)
        {

            this.Idcategoriaproducto = pidcategoriaproducto;

            this.Nombre = pnombre;

        }

        public int Idcategoriaproducto { get => idcategoriaproducto; set => idcategoriaproducto = value; }

        public string Nombre { get => nombre; set => nombre = value; }

    }

}
