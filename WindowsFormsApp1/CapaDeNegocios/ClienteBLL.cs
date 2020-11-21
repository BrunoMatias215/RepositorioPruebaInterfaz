using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class ClienteBLL
    {

        private int idcliente;

        private string nombre;

        private string apellido;

        private int telefono;

        private string direccion;

        public ClienteBLL (int pidcliente, string pnombre, string papellido, int ptelefono, string pdireccion)
        {

            this.Idcliente = pidcliente;

            this.nombre = pnombre;

            this.Apellido = papellido;

            this.Telefono = ptelefono;

            this.Direccion = pdireccion;

        }

        public ClienteBLL ()
        {



        }

        public int Idcliente { get => idcliente; set => idcliente = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public int Telefono { get => telefono; set => telefono = value; }

        public string Direccion { get => direccion; set => direccion = value; }

        public List<ClienteBLL> CargarClientes()
        {

            CapaDeDatos.Cliente clientedal = new CapaDeDatos.Cliente();

            DataTable tablaclientes= clientedal.BuscarClientes();

            List<ClienteBLL> clientesacargar = new List<ClienteBLL>();

            foreach (DataRow fila in tablaclientes.Rows)
            {

                int idcliente;

                string nombre;

                string apellido;

                int telefono;

                string direccion;

                idcliente = int.Parse(fila["idcliente"].ToString());

                nombre = fila["nombre"].ToString();

                apellido = fila["apellido"].ToString();

                telefono = int.Parse(fila["telefono"].ToString());

                direccion = fila["direccion"].ToString();

                ClienteBLL cliente = new ClienteBLL(idcliente, nombre, apellido, telefono, direccion);

                clientesacargar.Add(cliente);

            }

            return clientesacargar;

        }

    }

}
