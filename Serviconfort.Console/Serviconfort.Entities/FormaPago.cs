using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class FormaPago
    {
        public string idPago { get; private set; }
        public string tipoPago { get; private set; }

        public FormaPago(string idpago)
        {
            idPago = idpago;
        }

        public FormaPago(string tipopago)
        {
            tipoPago = tipopago;
        }
    }
}
