using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class DocumentoConfiguration : EntityTypeConfiguration<Documento>
    {
        public DocumentoConfiguration()
        {
            ToTable("Documento");
            HasKey(c => c.idDocumento);
            Property(c => c.tipoDocumento).HasMaxLength(20);
        }
    }
}
