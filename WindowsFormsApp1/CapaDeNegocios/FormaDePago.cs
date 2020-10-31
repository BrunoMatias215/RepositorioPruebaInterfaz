using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class FormaDePago
    {

        private int idformadepago;

        private string descripcion;

        public FormaDePago (int pidformadepago, string pdescripcion)
        {

            this.idformadepago = pidformadepago;

            this.descripcion = pdescripcion;

        }

        public FormaDePago ()
        {



        }

        public int Idformadepago { get => idformadepago; set => idformadepago = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public List<FormaDePago> CargarFormasDePago()
        {

            CapaDeDatos.FormaDePago formadepagodal = new CapaDeDatos.FormaDePago();

            DataTable tablaformasdepago = formadepagodal.BuscarFormasDePago();

            List<FormaDePago> formasdepagoaagregar = new List<FormaDePago>();

            foreach (DataRow fila in tablaformasdepago.Rows)
            {

                int idformadepago;

                string descripcion;

                idformadepago = int.Parse(fila["idformadepago"].ToString());

                descripcion = fila["descripcion"].ToString();

                FormaDePago formadepago = new FormaDePago(idformadepago, descripcion);

                formasdepagoaagregar.Add(formadepago);

            }

            return formasdepagoaagregar;

        }

    }

}
