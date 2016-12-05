using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados
    {
        public List<Empleados> List;
        [Key]

        public int EmpleadoId { get; set; }
        public  string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos  { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Nacionalidad { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        public string  FechaEntrada { get; set; }
    }
}
