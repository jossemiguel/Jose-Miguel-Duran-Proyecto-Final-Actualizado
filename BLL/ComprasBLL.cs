using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Windows.Forms;


namespace BLL
{
    public class ComprasBLL
    {
        private static List<Compras> Lista;

        public static bool insertar(Compras compra)//algo
        {
            bool retorno = false;
            try
            {
                CompraventaDb db = new CompraventaDb();
                db.Compra.Add(compra);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return retorno;

        }

        public static Compras Buscar(int CompraId)
        {
            var db = new CompraventaDb();

            return db.Compra.Find(CompraId);

        }
        

        public static void Eliminar(int CompraId)
        {
            try
                
            {
                var db = new CompraventaDb();
                Compras compra = Buscar(CompraId);
                db.Entry(compra).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            } 

           


        }

        public static void Modificar(Compras compra)
        {
            var db = new CompraventaDb();
            db.Entry(compra).State = EntityState.Modified;
            db.SaveChanges();
            Lista =GetLista();
        }

        public static List<Compras> GetLista()
        {
            List <Compras> lista = new List<Compras>();

            var db = new CompraventaDb();

            lista = db.Compra.ToList();
            db.SaveChanges();

            return lista;

        }


    }
    //public static int get(int CompraId)
    //{
    //    int Precio = 0;
    //    using (var conexion = new CompraventaDb())
    //    {
    //        try
    //        {
    //            Compras p = conexion.Compra.Where(c => c.CompraId == CompraId).FirstOrDefault();
    //            Precio = p.Precio;
    //        }
    //        catch (Exception e)
    //        {
    //            MessageBox.Show(e.ToString());
    //            throw;
    //        }
    //        return Precio;
    //    }
    //}
}
