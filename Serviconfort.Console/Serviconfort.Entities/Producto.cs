using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        private List<Almacen> _Almacen;
        public Producto()
        {
            _Almacen = new List<Almacen>();
        }
    }
}
