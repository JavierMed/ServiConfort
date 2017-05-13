using Serviconfort.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.EntityTypeConfiguration
{
    public class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            ToTable("Pedido");
            HasKey(c => c.codCompra);
            Property(c => c.cantidad).HasColumnType("int");
            Property(c => c.precioCompra).HasColumnType("double");
            Property(c => c.descuento).HasColumnType("double");
            //HasRequired(c => c.Producto).WithMany(c => c.Almacen).HasForeignKey(c=>c.idProducto);
        }
    }
}
