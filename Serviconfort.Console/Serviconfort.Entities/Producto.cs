using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class Producto
    {
        private List<Almacen> _Almacen;
        public Producto(int idProducto)
        {
            _Almacen = new List<Almacen>(idProducto);
        }
    }
}
