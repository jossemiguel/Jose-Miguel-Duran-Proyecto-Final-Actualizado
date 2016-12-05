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
    public class VentasBLL
    {

        private static List<Ventas> Lista;

        public static bool insertar(Ventas nuevo)
        {
            bool retorno = false;
            try
            {
                CompraventaDb db = new CompraventaDb();
                db.Venta.Add(nuevo);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return retorno;

        }

        public static Ventas Buscar(int FacturaId )
        {
            var db = new CompraventaDb();

            return db.Venta.Find(FacturaId);


        }

        public static void Eliminar(int FacturaId)
        {
            var db = new CompraventaDb();

           Ventas v= Buscar(FacturaId);
            db.Entry(v).State = EntityState.Deleted;
            db.SaveChanges();


        }

        public static List<Ventas> BuscarNombre(string Nombre)
        {
            List<Ventas> lista = new List<Ventas>();
            var db = new CompraventaDb();
            lista = db.Venta.Where(u => u.Nombre== Nombre).ToList();

            return lista;

        }

        public static void Modificar(Ventas ventas)
        {
            try
            {
                var db = new CompraventaDb();
                db.Entry(ventas).State = EntityState.Modified;
                db.SaveChanges();

                Lista = VentasBLL.Getlista();
                Lista = Getlista();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }

        public static List<Ventas> Getlista()
        {
            List<Ventas> list = new List<Ventas>();

            var db = new CompraventaDb();

            list = db.Venta.ToList();


            return list;

        }

        public static List<Ventas> GetLista(string Nombre)
        {
            List<Ventas> lista = new List<Ventas>();

            var db = new CompraventaDb();

            lista = db.Venta.Where(p => p.Nombre == Nombre).ToList();
            db.SaveChanges();
            return lista;

        }

    }
}
