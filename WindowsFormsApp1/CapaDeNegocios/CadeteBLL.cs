﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocios
{

    public class CadeteBLL
    {

        private int idcadete;

        private string nombre;

        private string apellido;

        private int telefono;

        public CadeteBLL(int pidcadete, string pnombre, string papellido, int ptelefono)
        {

            this.Idcadete = pidcadete;

            this.Nombre = pnombre;

            this.Apellido = papellido;

            this.Telefono = ptelefono;

        }

        public CadeteBLL ()
        {



        }

        public int Idcadete { get => idcadete; set => idcadete = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public int Telefono { get => telefono; set => telefono = value; }

        public List<CadeteBLL> CargarCadeteYRodado()
        {

            CapaDeDatos.CadeteDAL cadetedal = new CapaDeDatos.CadeteDAL();

            DataTable tablacadeteyrodado = cadetedal.BuscarCadeteYRodado();

            List<CadeteBLL> cadeteyrodadoacargar = new List<CadeteBLL>();

            foreach (DataRow fila in tablacadeteyrodado.Rows)
            {

                int idcadete;

                string nombre;

                string apellido;

                int telefono;

                idcadete = int.Parse(fila["idcadete"].ToString());

                nombre = fila["nombre"].ToString();

                apellido = fila["apellido"].ToString();

                telefono = int.Parse(fila["telefono"].ToString());

                int idrodado;

                string descripcion;

                string patente;

                idrodado = int.Parse(fila["idrodado"].ToString());

                descripcion = fila["descripcion"].ToString();

                patente = fila["patente"].ToString();

                RodadoBLL rodado = new RodadoBLL(idrodado, descripcion, patente);

                CadeteBLL cadete = new CadeteBLL(idcadete, nombre, apellido, telefono);

                cadeteyrodadoacargar.Add(cadete);

            }

            return cadeteyrodadoacargar;

        }

        public List<CadeteBLL> CargarCadetes()
        {

            CapaDeDatos.CadeteDAL cadetedal = new CapaDeDatos.CadeteDAL();

            DataTable tabladecadetes = cadetedal.BuscarCadetes();

            List<CadeteBLL> cadetesaagregar = new List<CadeteBLL>();

            foreach (DataRow fila in tabladecadetes.Rows)
            {

                int idcadete;

                string nombre;

                string apellido;

                int telefono;

                idcadete = int.Parse(fila["idcadete"].ToString());

                nombre = fila["nombre"].ToString();

                apellido = fila["apellido"].ToString();

                telefono = int.Parse(fila["telefono"].ToString());

                CadeteBLL cadete = new CadeteBLL(idcadete, nombre, apellido, telefono);

                cadetesaagregar.Add(cadete);

            }

            return cadetesaagregar;

        }

        public void AsignarCadete (int pidpedido, int pidcadete)
        {

            CadeteDAL cadete = new CadeteDAL();

            cadete.AsignarCadete(pidpedido, pidcadete);

        }


        public DataTable CargartablaCadetes()
        {

            CapaDeDatos.CadeteDAL cadete = new CadeteDAL();

            DataTable tablacadete = cadete.BuscarCadetesReales();



            return tablacadete;

        }

        public void CrearCadete(string pnombre, string papellido, int ptelefono, int licencia)
        {

            CapaDeDatos.CadeteDAL cadete = new CapaDeDatos.CadeteDAL();

            cadete.CrearCadete(pnombre, papellido, ptelefono, licencia);

        }



        public void ModificarCadete(int pidusuario, string pnombre, string apellido, int tel, int licencia)
        {

            CadeteDAL cadete = new CadeteDAL();

            cadete.ModificarCadete(pidusuario, pnombre, apellido, tel, licencia);


        }

        public void EliminarCadete(int pid)
        {

            CadeteDAL cadete = new CadeteDAL();

            cadete.EliminarCadete(pid);

        }

    }

}
