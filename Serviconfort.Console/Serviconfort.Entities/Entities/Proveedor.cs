using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Proveedor
    {
        public string idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public Proveedor()
        {
            
        }
    }
}
