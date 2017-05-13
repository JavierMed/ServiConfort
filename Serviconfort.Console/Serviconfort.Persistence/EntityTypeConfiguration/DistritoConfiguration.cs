using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class DistritoConfiguration : EntityTypeConfiguration<Distrito>
    {
        public DistritoConfiguration()
        {
            ToTable("Distrito");
            HasKey(c => c.idDistrito);
            Property(c => c.nombreDistrito).HasMaxLength(30);
        }
    }
}
