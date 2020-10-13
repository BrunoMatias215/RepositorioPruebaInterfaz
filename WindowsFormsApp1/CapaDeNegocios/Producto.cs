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

            DataTable tablaproductos = productodal.BuscarCategoriaEntrada();

            List<Producto> listadeentradas = new List<Producto>();

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

                Producto entrada = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                listadeentradas.Add(entrada);

            }

            return listadeentradas;

        }

        public List<Producto> CargarOmelettes ()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproductos = productodal.BuscarCategoriaOmelette();

            List<Producto> listadeomelettes = new List<Producto>();

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

                Producto omelette = new Producto(idproducto, descripcion, precio, idcategoriaproducto);

                listadeomelettes.Add(omelette);

            }

            return listadeomelettes;

        }
   

    }


}
