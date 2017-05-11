using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Proveedor
    {
        public string idProveedor { get; private set; }
        public string nombreProveedor { get; private set; }
        public string direccion { get; private set; }
        public string telefono { get; private set; }

        public Proveedor()
        {
            
        }
    }
}
