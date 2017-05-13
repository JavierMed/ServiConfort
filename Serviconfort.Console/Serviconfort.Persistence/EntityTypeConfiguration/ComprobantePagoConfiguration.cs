using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class ComprobantePagoConfiguration : EntityTypeConfiguration<ComprobantePago>
    {
        public ComprobantePagoConfiguration()
        {
            ToTable("ComprobantePago");
            HasKey(c => c.codComprobante);
            Property(c => c.tipoComprobante).HasMaxLength(100);
            Property(c => c.cantidad).HasColumnType("int");
            Property(c => c.descripcion).HasMaxLength(150);
            Property(c => c.total).HasColumnType("double");
            Property(c => c.fechaPago).HasColumnType("DateTime");
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
