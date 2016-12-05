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
    public class PersonasBLL
    {
        private static List<Personas> Lista;

        public static bool insertar(Personas nuevo)
        {
            bool retorno = false;
            try
            {
                CompraventaDb db = new CompraventaDb();
                db.Persona.Add(nuevo);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return retorno;

        }

        public static Personas Buscar(int PersonaId)
        {
            var db = new CompraventaDb();

            return db.Persona.Find(PersonaId);


        }

        public static void Eliminar(int PersonaId)
        {
            var db = new CompraventaDb();

            Personas p = Buscar(PersonaId);
            db.Entry(p).State = EntityState.Deleted;
            db.SaveChanges();


        }

        //public static Personas bucarPorCedula(string Cedula)
        //{
        //    List<Personas> listaPersonas = new List<Personas>();

        //    var db = new CompraventaDb();

        //    listaPersonas = db.Persona.Where(p => p.Cedula == Cedula).ToList();

        //    return listaPersonas;


        //}
        public static List<Personas> BuscarNombre(string cedula)
        {   
            List<Personas> lista = new List<Personas>();
            var db = new CompraventaDb();
            lista = db.Persona.Where(u => u.Cedula == cedula).ToList();

            return lista;

        }



        public static List<Personas> Getlista()
        {
            List<Personas> list = new List<Personas>();

            var db = new CompraventaDb();

            list = db.Persona.ToList();


            return list;

        }

        public static List<Personas> GetLista(string Cedula)
        {
            List<Personas> lista = new List<Personas>();

            var db = new CompraventaDb();

            lista = db.Persona.Where(p => p.Cedula == Cedula).ToList();
            db.SaveChanges();
            return lista;

        }

        public static void Modificar(Personas persona)
        {
            try
            {
                var db = new CompraventaDb();
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();

                Lista = PersonasBLL.Getlista();
                Lista = Getlista();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            
        }
    }
}
