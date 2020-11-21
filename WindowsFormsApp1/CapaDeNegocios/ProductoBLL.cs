using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class ProductoBLL
    {

        private int idproducto;

        private string descripcion;

        private int precio;

        private int idcategoriaproducto; // Agregar despues el tipo de dato categoriaproducto

        public ProductoBLL(int pidproducto, string pdescripcion,
            int pprecio, int pidcategoriaproducto)
        {

            this.Idproducto = pidproducto;

            this.Descripcion = pdescripcion;

            this.Precio = pprecio;

            this.idcategoriaproducto = pidcategoriaproducto;

        }

        public ProductoBLL ()
        {



        }

        public int Idproducto { get => idproducto; set => idproducto = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public int Precio { get => precio; set => precio = value; }

        public int Idcategoriaproducto { get => idcategoriaproducto; set => idcategoriaproducto = value; }

        public List<ProductoBLL> CargarEntradas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEntradas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarOmelletes ()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarOmelletes();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarTortillas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarTortillas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarMilanesas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarMilanesas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarSupremas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarSupremas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarMatambre()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarMatambre();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarGuarnicion()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarGuarnicion();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarPollos()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPollos();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarParillas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarParillas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarPescados()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPescados();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarEnsaladas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEnsaladas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarEnsaladasEsp()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEnsaladasEsp();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarTradicionales()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarTradicionales();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarEspecialesI()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEspecialesI();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarEspecialesII()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEspecialesII();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarFugazzas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarFugazzas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarFugazzetas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarFugazzetas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarCalzones()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarCalzones();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarOtrasEspecialidades()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarOtrasEspecialidades();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarEmpanadas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEmpanadas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarSandwiches()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarSandwiches();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarPastas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPastas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarBebidas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarBebidas();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarPostres()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPostres();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarMenus()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarMenus();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<ProductoBLL> CargarPromos()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPromos();

            List<ProductoBLL> productosacargar = new List<ProductoBLL>();

            foreach (DataRow fila in tablaproductos.Rows)
            {

                int idproducto;

                string descripcion;

                int precio;

                int idcategoriaproducto;

                idproducto = int.Parse(fila["idproducto"].ToString());

                descripcion = fila["descripcion"].ToString();

                precio = int.Parse(fila["precio"].ToString());

                idcategoriaproducto = int.Parse(fila["idproductocategoria"].ToString());

                ProductoBLL producto = new ProductoBLL(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

    }

}
