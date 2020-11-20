using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class EstadoCategoria
    {

        private int idestadocategoria;

        private string descripcion;

        public EstadoCategoria ()
        {



        }

        public EstadoCategoria (int pidestadocategoria, string pdescripcion)
        {

            this.Idestadocategoria = pidestadocategoria;

            this.Descripcion = pdescripcion;

        }

        public int Idestadocategoria { get => idestadocategoria; set => idestadocategoria = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public List<EstadoCategoria> CargarEstadosCategoria()
        {

            CapaDeDatos.EstadoCategoria objetoestadocategoria = new CapaDeDatos.EstadoCategoria();

            DataTable tablaestadoscategoria = objetoestadocategoria.BuscarCategorias();

            List<EstadoCategoria> estadoscategoriasaagregar = new List<EstadoCategoria>();

            foreach (DataRow fila in tablaestadoscategoria.Rows)
            {

                int idestadocategoria;

                string descripcion;

                idestadocategoria = int.Parse(fila["idestadocategoria"].ToString());

                descripcion = fila["descripcion"].ToString();

                EstadoCategoria estadocategoria = new EstadoCategoria(idestadocategoria, descripcion);

                estadoscategoriasaagregar.Add(estadocategoria);

            }

            return estadoscategoriasaagregar;

        }

    }

}
