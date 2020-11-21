using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CajaBLL
    {


        int idcaja;
        int idusuario;
        int efectivocaja;
        int posnetcaja;
        DateTime fechahora;
        int efectivoinicial;
        int estado;

        public CajaBLL()
        {
        }

        public CajaBLL(int idcaja, int idusuario, int efectivocaja, int posnetcaja, DateTime fechahora, int efectivoinicial, int estado)
        {
            this.idcaja = idcaja;
            this.idusuario = idusuario;
            this.efectivocaja = efectivocaja;
            this.posnetcaja = posnetcaja;
            this.fechahora = fechahora;
            this.efectivoinicial = efectivoinicial;
            this.estado = estado;
        }

        public int Idcaja { get => idcaja; set => idcaja = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public int Efectivocaja { get => efectivocaja; set => efectivocaja = value; }
        public int Posnetcaja { get => posnetcaja; set => posnetcaja = value; }
        public DateTime Fechahora { get => fechahora; set => fechahora = value; }
        public int Efectivoinicial { get => efectivoinicial; set => efectivoinicial = value; }
        public int Estado { get => estado; set => estado = value; }



        public DataTable CargarCajasActivas()
        {

            CapaDeDatos.CajaDAL cajadal = new CapaDeDatos.CajaDAL();

            DataTable tablaCajasActivas = cajadal.BuscarCaja();

            return tablaCajasActivas;

        }


        public void CrearCaja(int Idusuario , int Efectivocaja, int Posnetcaja, DateTime Fechahora, int Efectivoinicial, int Estado)
        {

            

            CapaDeDatos.CajaDAL caja = new CapaDeDatos.CajaDAL();

            caja.CrearCaja(Idusuario , Efectivocaja, Posnetcaja, Fechahora, Efectivoinicial, Estado);

            

        }


    }
}
