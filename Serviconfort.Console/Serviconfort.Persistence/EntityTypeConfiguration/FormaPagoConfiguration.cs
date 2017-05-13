using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class FormaPagoConfiguration : EntityTypeConfiguration<FormaPago>
    {
        public FormaPagoConfiguration()
        {
            ToTable("FormaPago");
            HasKey(c => c.idPago);
            Property(c => c.tipoPago).HasMaxLength(20);
        }
    }
}
