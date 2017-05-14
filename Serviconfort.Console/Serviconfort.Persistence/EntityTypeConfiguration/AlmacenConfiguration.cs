using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class AlmacenConfiguration:EntityTypeConfiguration<Almacen>
    {
        public AlmacenConfiguration()
        {
            ToTable("Almacen");
            HasKey(c => c.codAlmacen);
            Property(c => c.modelo).HasMaxLength(100);
            Property(c => c.capacidad).HasMaxLength(100);
            Property(c => c.cantidad).HasColumnType("int");
            Property(c => c.precioCompra).HasColumnType("double");
            Property(c => c.precioVenta).HasColumnType("double");
            Property(c => c.descuento).HasColumnType("double");
            //HasRequired(c => c.Producto).WithMany(g => g.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
