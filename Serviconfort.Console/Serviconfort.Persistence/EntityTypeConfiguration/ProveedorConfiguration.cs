using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class ProveedorConfiguration : EntityTypeConfiguration<Proveedor>
    {
        public ProveedorConfiguration()
        {
            ToTable("Proveedor");
            HasKey(c => c.idProveedor);
            Property(c => c.nombreProveedor).HasMaxLength(80);
            Property(c => c.direccion).HasMaxLength(150);
            Property(c => c.telefono).HasMaxLength(10);
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
