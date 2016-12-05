using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Windows.Forms;
using System.Data.Entity;

namespace BLL
{
   public  class EmpleadosBLL
    {
        private static List<Empleados> Lista;

        public static bool insertar(Empleados nuevo)
        {
            bool retorno = false;
            try
            {
                CompraventaDb db = new CompraventaDb();
                db.Empledo.Add(nuevo);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return retorno;

        }

        public static Empleados Buscar(int EmpleadoId)
        {
            var db = new CompraventaDb();

            return db.Empledo.Find(EmpleadoId);


        }

        public static void Eliminar(int EmpleadoId)
        {
            var db = new CompraventaDb();
            Empleados e = Buscar(EmpleadoId);
            db.Entry(e).State = EntityState.Deleted;
            db.SaveChanges();


        }

        //public static Personas bucarPorCedula(string Cedula)
        //{
        //    List<Personas> listaPersonas = new List<Personas>();

        //    var db = new CompraventaDb();

        //    listaPersonas = db.Persona.Where(p => p.Cedula == Cedula).ToList();

        //    return listaPersonas;


        //}
        public static List<Empleados> BuscarNombre(string cedula)
        {
            List<Empleados> lista = new List<Empleados>();
            var db = new CompraventaDb();
            lista = db.Empledo.Where(u => u.Cedula == cedula).ToList();

            return lista;

        }



        public static List<Empleados> Getlista()
        {
            List<Empleados> list = new List<Empleados>();

            var db = new CompraventaDb();

            list = db.Empledo.ToList();


            return list;

        }

        public static List<Empleados> GetLista(string Cedula)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new CompraventaDb();

            lista = db.Empledo.Where(p => p.Cedula == Cedula).ToList();
            db.SaveChanges();
            return lista;

        }

        public static void Modificar(Empleados emplado)
        {
            try
            {
                var db = new CompraventaDb();
                db.Entry(emplado).State = EntityState.Modified;
                db.SaveChanges();

                Lista = EmpleadosBLL.Getlista();
                Lista = Getlista();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }
    }
}
