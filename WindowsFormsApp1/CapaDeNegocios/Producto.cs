using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class Producto
    {

        private int idproducto;

        private string descripcion;

        private int precio;

        private int idcategoriaproducto; // Agregar despues el tipo de dato categoriaproducto

        public Producto(int pidproducto, string pdescripcion,
            int pprecio, int pidcategoriaproducto)
        {

            this.Idproducto = pidproducto;

            this.Descripcion = pdescripcion;

            this.Precio = pprecio;

            this.idcategoriaproducto = pidcategoriaproducto;

        }

        public Producto ()
        {



        }

        public int Idproducto { get => idproducto; set => idproducto = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public int Precio { get => precio; set => precio = value; }

        public int Idcategoriaproducto { get => idcategoriaproducto; set => idcategoriaproducto = value; }

        public List<Producto> CargarEntradas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEntradas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarOmelletes ()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarOmelletes();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarTortillas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarTortillas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarMilanesas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarMilanesas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarSupremas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarSupremas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarMatambre()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarMatambre();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarGuarnicion()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarGuarnicion();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarPollos()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPollos();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarParillas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarParillas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarPescados()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPescados();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarEnsaladas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEnsaladas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarEnsaladasEsp()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEnsaladasEsp();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarTradicionales()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarTradicionales();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarEspecialesI()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEspecialesI();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarEspecialesII()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEspecialesII();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarFugazzas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarFugazzas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarFugazzetas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarFugazzetas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarCalzones()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarCalzones();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarOtrasEspecialidades()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarOtrasEspecialidades();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarEmpanadas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarEmpanadas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarSandwiches()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarSandwiches();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarPastas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPastas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarBebidas()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarBebidas();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarPostres()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPostres();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarMenus()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarMenus();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

        public List<Producto> CargarPromos()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarPromos();

            List<Producto> productosacargar = new List<Producto>();

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

                Producto producto = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                productosacargar.Add(producto);

            }

            return productosacargar;

        }

    }

}
