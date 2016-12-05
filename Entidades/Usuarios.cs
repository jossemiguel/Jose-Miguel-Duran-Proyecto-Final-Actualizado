using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public List<Usuarios> List;

        [Key]

        public int UsuarioId { get; set; }

        

        public string TipoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

       

        public string FechaRegistro{ get; set; }

       

       
    }
}
