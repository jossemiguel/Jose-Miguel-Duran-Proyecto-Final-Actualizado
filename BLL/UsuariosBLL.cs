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
   public class UsuariosBLL
    {
        private static List<Usuarios> Lista;

        public static bool insertar(Usuarios usuario)
        {
            bool retorno = false;      
            try
            {
                CompraventaDb db = new CompraventaDb();
                db.Usuario.Add(usuario);
                db.SaveChanges();
                retorno = true;
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return retorno;

        }

        

        public static void Eliminar(int UsuarioId)
        {
            var db = new CompraventaDb();

            Usuarios usuario = Buscar(UsuarioId);
            db.Entry(usuario).State = EntityState.Deleted;
            db.SaveChanges();

            
        }

        
        

        public static void Modificar(Usuarios usuario)
        {
            var db = new CompraventaDb();
            db.Entry(usuario).State = EntityState.Modified;
            db.SaveChanges();

            Lista = UsuariosBLL.Getlista();
            Lista = Getlista();
       }

        public static Usuarios Buscar(int UsuarioId)
        {
            var db = new CompraventaDb();

            return db.Usuario.Find(UsuarioId);
          

        }
        public static List<Usuarios> BuscarNombre(string NombreUsuario)
        {
            List<Usuarios> lista = new List<Usuarios>();
            var db =new CompraventaDb();
          //lista = db.Usuario.Where(u => u.NombreUsuario == NombreUsuario ).ToList();
           
            return lista;

        }

        public static List<Usuarios> BusrcarPorFecha(DateTime FDesde, DateTime FHasta)
        {
            
                var lista = new List<Usuarios>();
                var db = new CompraventaDb();
                //lista = db.Usuario.Where(u => u.FechaRegistro >= FDesde && u.FechaRegistro <= FHasta).ToList();
           
            

           return lista;
        }
        public static List<Usuarios> Getlista()
        {
            List<Usuarios> list = new List<Usuarios>();

            var db = new CompraventaDb();

            list = db.Usuario.ToList();


            return list;

        }



        public static List<Usuarios> GetLista(int usuarioId)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new CompraventaDb();

           lista = db.Usuario.Where(p => p.UsuarioId == usuarioId).ToList();
            db.SaveChanges();
            return lista;

        }
        public static List<Usuarios> getlistaNombreUsuario(string Usuario)
        {
            List<Usuarios> lista = new List<Usuarios>();
            CompraventaDb db = new CompraventaDb();
            //lista = db.Usuario.Where(p => p.NombreUsuario == Usuario).ToList();
            return lista;
        }

        public static List<Usuarios> getlistacontrasena(string contrasena)
        {
            List<Usuarios> lista = new List<Usuarios>();
            CompraventaDb db = new CompraventaDb();
            lista = db.Usuario.Where(p => p.Contraseña == contrasena).ToList();
            return lista;
        }




    }


}
