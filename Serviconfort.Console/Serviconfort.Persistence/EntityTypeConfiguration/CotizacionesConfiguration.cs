using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class CotizacionesConfiguration : EntityTypeConfiguration<Cotizaciones>
    {
        public CotizacionesConfiguration()
        {
            ToTable("Cotizaciones");
            HasKey(c => c.IdCotizaciones);
            Property(c => c.FechaVisita).HasColumnType("DateTime");
            Property(c => c.Componente).HasMaxLength(150);
            Property(c => c.Caracteristica).HasMaxLength(200);
            Property(c => c.Costo).HasColumnType("double");
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
