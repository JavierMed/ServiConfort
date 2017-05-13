using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class CliEmpresaConfiguration : EntityTypeConfiguration<CliEmpresa>
    {
        public CliEmpresaConfiguration()
        {
            ToTable("CliEmpresa");
            //HasKey(c => c.codAlmacen);
            Property(c => c.RazonSocial).HasMaxLength(100);
            Property(c => c.PersonaContacto).HasMaxLength(100);
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
