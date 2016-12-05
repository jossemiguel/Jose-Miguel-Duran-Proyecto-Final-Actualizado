using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
namespace BLL
{
   public class ComprasVentasBLL
    {
        public static bool Guardar(ComprasVentas lista)
        {
            bool retorno = false;
            try
            {
                using (var db = new CompraventaDb())
                {
                    db.cv.Add(lista);
                    db.SaveChanges();
                }
                retorno = true;

            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

    }
}
