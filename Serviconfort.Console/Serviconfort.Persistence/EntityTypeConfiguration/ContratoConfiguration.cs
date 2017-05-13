using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class ContratoConfiguration : EntityTypeConfiguration<Contrato>
    {
        public ContratoConfiguration()
        {
            ToTable("Contrato");
            HasKey(c => c.CodContrato);
            Property(c => c.fechaInicioContra).HasColumnType("DateTime");
            Property(c => c.fechaCulminacionContra).HasColumnType("DateTime");
            Property(c => c.fechaGarantiaExtern).HasColumnType("DateTime");
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
