using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class Proveedor
    {
        public string idProveedor { get; private set; }
        public string nombreProveedor { get; private set; }
        public string direccion { get; private set; }
        public string telefono { get; private set; }
        
        public Proveedor(string idprov)
        {
            idProveedor = idprov;
        }

        public Proveedor(string nomprov)
        {
            nombreProveedor = nomprov;
        }

        public Proveedor(string dir)
        {
            direccion = dir;
        }

        public Proveedor(string tel)
        {
            telefono = tel;
        }
    }
    
}
