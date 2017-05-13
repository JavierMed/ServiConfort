using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class PersonaConfiguration : EntityTypeConfiguration<Persona>
    {
        public PersonaConfiguration()
        {
            ToTable("Persona");
            HasKey(c => c.CodPersona);
            Property(c => c.nombres).HasMaxLength(80);
            Property(c => c.direccion).HasMaxLength(100);
            Property(c => c.numDocumento).HasMaxLength(20);
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
