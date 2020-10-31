using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class Cliente
    {

        private int idcliente;

        private string nombre;

        private string apellido;

        private int telefono;

        private string direccion;

        public Cliente (int pidcliente, string pnombre, string papellido, int ptelefono, string pdireccion)
        {

            this.Idcliente = pidcliente;

            this.nombre = pnombre;

            this.Apellido = papellido;

            this.Telefono = ptelefono;

            this.Direccion = pdireccion;

        }

        public Cliente ()
        {



        }

        public int Idcliente { get => idcliente; set => idcliente = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public int Telefono { get => telefono; set => telefono = value; }

        public string Direccion { get => direccion; set => direccion = value; }

        public List<Cliente> CargarClientes()
        {

            CapaDeDatos.Cliente clientedal = new CapaDeDatos.Cliente();

            DataTable tablaclientes= clientedal.BuscarClientes();

            List<Cliente> clientesacargar = new List<Cliente>();

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

                Cliente cliente = new Cliente(idcliente, nombre, apellido, telefono, direccion);

                clientesacargar.Add(cliente);

            }

            return clientesacargar;

        }

    }

}
