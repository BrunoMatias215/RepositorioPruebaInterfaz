using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeLógicaDeNegocios
{

    public class Carta
    {

        private List<Producto> productos = new List<Producto>();

        public List<Producto> Productos { get => productos; set => productos = value; }

    }

}
