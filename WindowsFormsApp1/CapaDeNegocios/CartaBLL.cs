using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class CartaBLL
    {

        private List<ProductoBLL> productos = new List<ProductoBLL>();

        public List<ProductoBLL> Productos { get => productos; set => productos = value; }

    }

}
