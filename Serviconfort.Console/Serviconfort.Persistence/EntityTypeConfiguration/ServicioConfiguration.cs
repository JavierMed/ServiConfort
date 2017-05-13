using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class ServicioConfiguration : EntityTypeConfiguration<Servicio>
    {
        public ServicioConfiguration()
        {
            ToTable("Servicio");
            HasKey(c => c.CodServicio);
            Property(c => c.FechaInicio).HasColumnType("DateTime");
            Property(c => c.FechaFin).HasColumnType("DateTime");
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
