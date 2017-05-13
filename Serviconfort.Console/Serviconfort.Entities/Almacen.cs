using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Almacen
    {
        
        public int codAlmacen { get; private set; }
        public string modelo { get; private set; }
        public string capacidad { get; private set; }
        public int cantidad { get; private set; }
        public double precioCompra { get; private set; }
        public double precioVenta { get; private set; }
        public double descuento { get; private set; }
        public Producto Producto;

        public Almacen()
        {
            Producto = new Producto();
        }
    }
}
