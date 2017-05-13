using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class UbigeoConfiguration : EntityTypeConfiguration<Ubigeo>
    {
        public UbigeoConfiguration()
        {
            ToTable("Ubigeo");
            HasKey(c => c.idUbigeo);
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
