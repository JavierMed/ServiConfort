using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Almacen
    {
        
        public int codAlmacen { get; set; }
        public int idProducto { get; set; }
        public string modelo { get; set; }
        public string capacidad { get; set; }
        public int cantidad { get; set; }
        public double precioCompra { get; set; }
        public double precioVenta { get; set; }
        public double descuento { get; set; }
        public Producto Producto { get; set; }

        public Almacen()
        {
            Producto = new Producto();
        }
    }
}
