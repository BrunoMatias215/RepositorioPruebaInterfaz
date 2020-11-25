using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

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

        public DataTable CargarTodolosproductos()
        {

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

            DataTable tablaproductos = productodal.BuscarTodo();

            return tablaproductos;

        }

        public DataTable FIltroProductos(string pfiltro)
        {

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

            DataTable tablaproductos = productodal.FiltroProductos(pfiltro);

            return tablaproductos;

        }


        public void CrearProducto(string pdescripcion, int idproductocategoria, int pprecio)
        {

            CapaDeDatos.ProductoDAL producto = new CapaDeDatos.ProductoDAL();

            producto.CrearProducto(pdescripcion, idproductocategoria, pprecio );

        }


        public void ModificarProducto (int pidproducto, string pnombre, int idcategoria, int precio)
        {

            ProductoDAL producto = new ProductoDAL();

            producto.ModificarProducto(pidproducto, pnombre, idcategoria, precio);

        }

        public void EliminarProducto(int pidproducto)
        {

            ProductoDAL producto = new ProductoDAL();

            producto.EliminarProducto(pidproducto);

        }

        public DataTable CargarProductoMasVendidoDia()
        {

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

            DataTable tablaproductos = productodal.BuscarProductoMasVendidodia();

            return tablaproductos;

        }

        public DataTable CargarProductoMasVendidoMesAño(int mes, int año)
        {

            CapaDeDatos.ProductoDAL productodal = new CapaDeDatos.ProductoDAL();

            DataTable tablaproductos = productodal.BuscarProductoMasVendidoMesAño(mes, año);

            return tablaproductos;

        }

    }




}
