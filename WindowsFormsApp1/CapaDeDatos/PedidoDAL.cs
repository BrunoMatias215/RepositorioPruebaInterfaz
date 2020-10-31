using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{

    public class PedidoDAL
    {

        public int CrearPedido(int pidformadepago, int pidcliente, int pidusuario, 
            string pobservaciones, int pidcadete, int pidestadocategoria)
        {
  
            int Filasafectadas = 1;

            Conexion objetoconexion = new Conexion();

            objetoconexion.Conectar();

            objetoconexion.EscrituraPorComando("INSERT INTO Pedido (idformadepago, idcliente, idusuario, fechayhora, observaciones, idcadete, idestadocategoria) VALUES (" +
                pidformadepago + "," + pidcliente + "," + pidusuario + ", CURRENT_TIMESTAMP ,'" + pobservaciones + "'," + pidcadete + "," + pidestadocategoria + ")");

            objetoconexion.Desconectar();

            return Filasafectadas;

        }

    }

}
