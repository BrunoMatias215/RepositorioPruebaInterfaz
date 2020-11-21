using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class FormaDePagoBLL
    {

        private int idformadepago;

        private string descripcion;

        public FormaDePagoBLL (int pidformadepago, string pdescripcion)
        {

            this.idformadepago = pidformadepago;

            this.descripcion = pdescripcion;

        }

        public FormaDePagoBLL ()
        {



        }

        public int Idformadepago { get => idformadepago; set => idformadepago = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public List<FormaDePagoBLL> CargarFormasDePago()
        {

            CapaDeDatos.FormaDePagoDAL formadepagodal = new CapaDeDatos.FormaDePagoDAL();

            DataTable tablaformasdepago = formadepagodal.BuscarFormasDePago();

            List<FormaDePagoBLL> formasdepagoaagregar = new List<FormaDePagoBLL>();

            foreach (DataRow fila in tablaformasdepago.Rows)
            {

                int idformadepago;

                string descripcion;

                idformadepago = int.Parse(fila["idformadepago"].ToString());

                descripcion = fila["descripcion"].ToString();

                FormaDePagoBLL formadepago = new FormaDePagoBLL(idformadepago, descripcion);

                formasdepagoaagregar.Add(formadepago);

            }

            return formasdepagoaagregar;

        }

    }

}
