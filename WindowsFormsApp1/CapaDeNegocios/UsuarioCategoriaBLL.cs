using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
namespace CapaDeNegocios
{

    public class UsuarioCategoriaBLL
    {


        private int idcategoria;

        private string descripcion;

        public UsuarioCategoriaBLL()
        {



        }

        public UsuarioCategoriaBLL(int pidcategoria, string pdescripcion)
        {

            this.Idcategoria = pidcategoria;

            this.Descripcion = pdescripcion;

        }

        public int Idcategoria { get => idcategoria; set => idcategoria = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public List<UsuarioCategoriaBLL> CargarUsuarioCategoria()
        {
            
            UsuarioCategoriaDAL categoria = new UsuarioCategoriaDAL();

            DataTable tablaUsuariocategoria = categoria.BuscarUsuarioCategorias();

            List<UsuarioCategoriaBLL> categoriasaagregar = new List<UsuarioCategoriaBLL>();

            foreach (DataRow fila in tablaUsuariocategoria.Rows)
            {

                int idcategoria;

                string descripcion;

                idcategoria = int.Parse(fila["idcategoriausuario"].ToString());

                descripcion = fila["descripcion"].ToString();

                UsuarioCategoriaBLL Usuariocategoria = new UsuarioCategoriaBLL(idcategoria, descripcion);

              categoriasaagregar.Add(Usuariocategoria);

            }

            return categoriasaagregar;

        }


    }

}
