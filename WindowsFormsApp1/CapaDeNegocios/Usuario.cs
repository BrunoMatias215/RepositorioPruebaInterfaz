using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public class Usuario
    {

        private int legajo;

        private string nombre;

        private string contraseña;

        private string apellido;

        private int cuil;

        private int numerodecontacto;

        private List<DateTime> diastrabajados;

        private DateTime fechadecontratacion;

        private UsuarioCategoria usuariocategoria;

        public Usuario (string pnombre, string pcontraseña)
        {

            this.nombre = pnombre;

            this.contraseña = pcontraseña;

        }

        public int Legajo { get => legajo; set => legajo = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Contraseña { get => contraseña; set => contraseña = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public int Cuil { get => cuil; set => cuil = value; }

        public int Numerodecontacto { get => numerodecontacto; set => numerodecontacto = value; }

        public List<DateTime> Diastrabajados { get => diastrabajados; set => diastrabajados = value; }

        public DateTime Fechadecontratacion { get => fechadecontratacion; set => fechadecontratacion = value; }

        public UsuarioCategoria Usuariocategoria { get => usuariocategoria; set => usuariocategoria = value; }
        
    }

}
