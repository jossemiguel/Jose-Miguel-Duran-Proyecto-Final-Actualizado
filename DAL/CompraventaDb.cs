using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class CompraventaDb : DbContext
    {

        public CompraventaDb() : base("name=ConStr")
        {

        }


        public virtual DbSet<Usuarios> Usuario  { get; set; }
        public virtual DbSet <Compras> Compra   { get; set; }
        public virtual DbSet <Personas> Persona { get; set; }
        public  virtual DbSet<Empleados> Empledo{ get; set; }
        public virtual DbSet<Ventas> Venta      { get; set; }
        public virtual DbSet<ComprasVentas> cv  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ventas>()
                .HasMany<Compras>(c => c.Com)
                .WithMany(v => v.Ven)
                .Map(vc =>
                {
                    vc.MapLeftKey("FacturaId");
                    vc.MapRightKey("CompraId");
                    vc.ToTable("ComprasVentas");
                });
        }


      


    }
    

   

    

    
}
