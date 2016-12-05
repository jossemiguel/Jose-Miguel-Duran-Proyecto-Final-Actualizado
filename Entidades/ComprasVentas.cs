using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ComprasVentas
    {
        [Key]

        public int Id { get; set; }
        public int CompraId { get; set; }
        public int FacturaId { get; set; }

    }
}
