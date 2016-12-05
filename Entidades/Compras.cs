using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compras
    {
        //public List<Compras> lista;

        [Key]
        public int CompraId { get; set; }
        public string Codigo { get; set; }
        public string NombreArticulo { get; set; }
        public int Precio { get; set; }
        public int CantidadArticulo { get; set; }
        public int Importe { get; set; }
        public string Condicion { get; set; }
       
        
        public int PrecioCompra { get; set; }
        
        public int Total { get; set; }
        
       // public int Ganancia { get; set; }

        public string Fecha { get; set; }

        public string Observaciones { get; set; }

        public virtual List<Ventas> Ven { get; set; }
        

        public Compras()
        {
            
            this.Ven = new List<Ventas>();
        }

        public Compras(int comprasid, string codigo,string nombrearticulo,string condicion,int cantidadarticulo
            ,int precio,int importe)
        {
            this.CompraId = comprasid;
            this.NombreArticulo = nombrearticulo;
            this.Condicion = condicion;
            this.Codigo = codigo;
            this.CantidadArticulo = cantidadarticulo;
            this.Precio = precio;
            this.Importe = importe;
            this.Ven = new List<Ventas>();



        }

        public Compras(string Codigo, string Nombre, int Cantidad, int Precio, int Importe)
        {
            this.Codigo = Codigo;
            this.NombreArticulo = Nombre;
            this.CantidadArticulo = Cantidad;
            this.Precio = Precio;
            this.Importe = Cantidad * Precio;
            this.Total = Importe ;


            this.Ven = new List<Ventas>();
        }


    }
}
