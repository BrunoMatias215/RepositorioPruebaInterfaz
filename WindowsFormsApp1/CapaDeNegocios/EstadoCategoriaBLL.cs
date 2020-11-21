using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class EstadoCategoriaBLL
    {

        private int idestadocategoria;

        private string descripcion;

        public EstadoCategoriaBLL ()
        {



        }

        public EstadoCategoriaBLL (int pidestadocategoria, string pdescripcion)
        {

            this.Idestadocategoria = pidestadocategoria;

            this.Descripcion = pdescripcion;

        }

        public int Idestadocategoria { get => idestadocategoria; set => idestadocategoria = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public List<EstadoCategoriaBLL> CargarEstadosCategoria()
        {

            CapaDeDatos.EstadoCategoriaDAL objetoestadocategoria = new CapaDeDatos.EstadoCategoriaDAL();

            DataTable tablaestadoscategoria = objetoestadocategoria.BuscarCategorias();

            List<EstadoCategoriaBLL> estadoscategoriasaagregar = new List<EstadoCategoriaBLL>();

            foreach (DataRow fila in tablaestadoscategoria.Rows)
            {

                int idestadocategoria;

                string descripcion;

                idestadocategoria = int.Parse(fila["idestadocategoria"].ToString());

                descripcion = fila["descripcion"].ToString();

                EstadoCategoriaBLL estadocategoria = new EstadoCategoriaBLL(idestadocategoria, descripcion);

                estadoscategoriasaagregar.Add(estadocategoria);

            }

            return estadoscategoriasaagregar;

        }

    }

}
