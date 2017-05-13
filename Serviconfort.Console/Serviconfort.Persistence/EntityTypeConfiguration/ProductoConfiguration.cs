using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class ProductoConfiguration:EntityTypeConfiguration<Producto>
    {
        public ProductoConfiguration()
        {
            ToTable("Producto");
            HasKey(c => c.idProducto);
            Property(c => c.nombreProducto).HasMaxLength(100);
        }        
    }
}
