using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class UsuarioBLL
    {

        private int legajo;

        private string nombre;

        private int contraseña;

        private string apellido;

        private int cuil;

        private int numerodecontacto;

        private List<DateTime> diastrabajados;

        private DateTime fechadecontratacion;

        private int idusuariocategoria;


        public UsuarioBLL (string pnombre, int pcontraseña)
        {

            this.nombre = pnombre;

            this.contraseña = pcontraseña;

        }

        public UsuarioBLL()
        {

            

        }

        public int Legajo { get => legajo; set => legajo = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public int Contraseña { get => contraseña; set => contraseña = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public int Cuil { get => cuil; set => cuil = value; }

        public int Numerodecontacto { get => numerodecontacto; set => numerodecontacto = value; }

        public List<DateTime> Diastrabajados { get => diastrabajados; set => diastrabajados = value; }

        public DateTime Fechadecontratacion { get => fechadecontratacion; set => fechadecontratacion = value; }

        
        public int Idusuariocategoria { get => idusuariocategoria; set => idusuariocategoria = value; }

        public UsuarioBLL(int pid, string pNombre, string pApellido, int pCuil, int pContraseña, DateTime pFechadeContratacion, int pidcategoriausuario)
        {


            this.legajo = pid;
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.cuil = pCuil;
            this.contraseña = pContraseña;
            this.fechadecontratacion = pFechadeContratacion;
            this.idusuariocategoria = pidcategoriausuario;



        }

        public List<UsuarioBLL> CargarUsuarios()
        {

            CapaDeDatos.UsuarioDAL usuario = new CapaDeDatos.UsuarioDAL();

            DataTable tablausuario = usuario.BuscarUsuario();

            List<UsuarioBLL> listausuarios = new List<UsuarioBLL>();

            foreach (DataRow fila in tablausuario.Rows)
            {
                int idusuario;
                string Nombre;

                string Apellido;

                int Cuil;
                int Contraseña;
                DateTime Fechacontratacion;
                int Idcategoriausuario;


                idusuario = int.Parse(fila["idusuario"].ToString());

                Nombre = fila["nombre"].ToString();
                Apellido = fila["apellido"].ToString();
                Cuil = int.Parse(fila["CUIL"].ToString());
                Contraseña = int.Parse(fila["contraseña"].ToString());
                Fechacontratacion = DateTime.Parse(fila["fechadecontratacion"].ToString());
                Idcategoriausuario = int.Parse(fila["idcategoriausuario"].ToString());

                UsuarioBLL nuevousuario = new UsuarioBLL(idusuario, Nombre, Apellido, Cuil, Contraseña, Fechacontratacion, Idcategoriausuario );

                listausuarios.Add(nuevousuario);

            }

            return listausuarios;

        }
    }

}
