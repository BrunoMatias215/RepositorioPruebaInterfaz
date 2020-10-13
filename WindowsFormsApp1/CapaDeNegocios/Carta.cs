using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class Carta
    {

        private List<Producto> productos = new List<Producto>();

        public List<Producto> Productos { get => productos; set => productos = value; }

    }

}
