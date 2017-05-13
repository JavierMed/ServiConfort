using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class CliNaturalConfiguration : EntityTypeConfiguration<CliNatural>
    {
        public CliNaturalConfiguration()
        {
            ToTable("CliNatural");
            //HasKey(c => c.codAlmacen);
            Property(c => c.FechaNacimiento).HasColumnType("DateTime");
            Property(c => c.Edad).HasColumnType("int");
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
