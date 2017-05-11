using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class ComprobantePago
    {
        public int codComprobante { get; private set; }
        public string tipoComprobante { get; private set; }
        public string cantidad { get; private set; }
        public string descripcion { get; private set; }
        public string total { get; private set; }
        public DateTime fechaPago { get; private set; }

        public ComprobantePago(int codComp)
        {
            codComprobante = codComp;
        }

        public ComprobantePago(string tipoComp)
        {
            tipoComprobante = tipoComp;
        }

        public ComprobantePago(string cant)
        {
            cantidad = cant;
        }

        public ComprobantePago(string descrip)
        {
            descripcion = descrip;
        }

        public ComprobantePago(string tot)
        {
            total = tot;
        }

        public ComprobantePago(DateTime fecPag)
        {
            fechaPago = fecPag;
        }
    }
}
