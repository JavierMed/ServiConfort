using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class ComprobantePago
    {
        public int codComprobante { get; set; }
        public string tipoComprobante { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public double total { get; set; }
        public DateTime fechaPago { get; set; }
        public int codCliente { get; set; }
        public Cliente Clientes { get; set; }

        public ComprobantePago()
        {
            Clientes = new Cliente();
        }
    }
}
