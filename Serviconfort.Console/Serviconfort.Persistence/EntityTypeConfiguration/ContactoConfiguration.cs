using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class ContactoConfiguration : EntityTypeConfiguration<Contacto>
    {
        public ContactoConfiguration()
        {
            ToTable("Contacto");
            HasKey(c => c.idTipoContacto);
            Property(c => c.contacto).HasMaxLength(100);
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
