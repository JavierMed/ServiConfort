using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class ComprobantePago
    {
        public int codComprobante { get; private set; }
        public string tipoComprobante { get; private set; }
        public int cantidad { get; private set; }
        public string descripcion { get; private set; }
        public double total { get; private set; }
        public DateTime fechaPago { get; private set; }

        public List<Cliente> Clientes;

        public ComprobantePago()
        {
            Clientes = new List<Cliente>();
        }
    }
}
