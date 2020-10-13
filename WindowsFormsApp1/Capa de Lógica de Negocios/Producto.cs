using System;
using System.Collections.Generic;
using System.Text;
using CapaDeDatos;

namespace CapaDeLógicaDeNegocios
{

    public class Producto
    {

        private int idproducto;

        private string descripcion;

        private int precio;

        private CategoriaProducto categoriaproducto;

        public Producto (int pidproducto, string pdescripcion, 
            int pprecio, CategoriaProducto pcategoriaproducto)
        {

            this.Idproducto = pidproducto;

            this.Descripcion = pdescripcion;

            this.Precio = pprecio;

            this.Categoriaproducto = pcategoriaproducto;

        }

        public int Idproducto { get => idproducto; set => idproducto = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public int Precio { get => precio; set => precio = value; }

        public CategoriaProducto Categoriaproducto { get => categoriaproducto; set => categoriaproducto = value; }

        public void CargarEntradas ()
        {

            CapaDeDatos.Producto productodal = new CapaDeDatos.Producto();

            DataTable tablaproducto = productodal.BuscarCategoriaEntrada();

            


        }

    }

}
