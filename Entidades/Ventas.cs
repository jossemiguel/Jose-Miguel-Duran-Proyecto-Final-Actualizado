using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        [Key]
        public int FacturaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Articulos { get; set; }
        public DateTime Fecha { get; set; }
        public int Total { get; set; }
        public int Cantidad { get; set; }

        public virtual List<Compras> Com { get; set; }
        

        public Ventas()
        {
            
            this.Com = new List<Compras>();
        }
    }
}
