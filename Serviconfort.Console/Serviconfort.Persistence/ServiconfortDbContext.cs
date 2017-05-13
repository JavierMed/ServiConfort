using Serviconfort.entities;
using Serviconfort.Persistence.EntityTypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence
{
    public class ServiconfortDbContext : DbContext
    {
        public DbSet<Almacen> Almacen { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<CliEmpresa> CliEmpresa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CliNatural> CliNatural { get; set; }
        public DbSet<ComprobantePago> ComprobantePago { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<Cotizaciones> Cotizaciones { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        public DbSet<Documento> Documento { get; set; }
        public DbSet<FormaPago> FormaPago { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Ubigeo> Ubigeo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new ContratoConfiguration());

            base.OnModelCreating(modelBuilder);
        }


    }
}
