using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
namespace CapaDeNegocios
{

    public class CategoriaProductoBLL
    {

        private int idcategoriaproducto;

        private string nombre;

        public CategoriaProductoBLL(int pidcategoriaproducto, string pnombre)
        {

            this.Idcategoriaproducto = pidcategoriaproducto;

            this.Nombre = pnombre;

        }
        public CategoriaProductoBLL()
        {

         

        }

        public int Idcategoriaproducto { get => idcategoriaproducto; set => idcategoriaproducto = value; }

        public string Nombre { get => nombre; set => nombre = value; }



        public List<CategoriaProductoBLL> CargarProductoCategoria()
        {

            CapaDeDatos.CategoriaProductoDAL productocategoriadal = new CapaDeDatos.CategoriaProductoDAL();

            DataTable tablacategoriaproductos = productocategoriadal.BuscarCategoriaProducto();

            List<CategoriaProductoBLL> categoriaproductosacargar = new List<CategoriaProductoBLL>();

            foreach (DataRow fila in tablacategoriaproductos.Rows)
            {

                int idcategoriaproducto;

                string descripcion;



                idcategoriaproducto = int.Parse(fila["ID del Producto"].ToString());

                descripcion = fila["Nombre del producto"].ToString();

                

                CategoriaProductoBLL categoriaproduc = new CategoriaProductoBLL(idcategoriaproducto, descripcion);

                categoriaproductosacargar.Add(categoriaproduc);

            }

            return categoriaproductosacargar;

        }



    }

}
