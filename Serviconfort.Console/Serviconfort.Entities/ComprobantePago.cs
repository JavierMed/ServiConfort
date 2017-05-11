using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class ComprobantePago
    {
        public int codComprobante { get; private set; }
        public string tipoComprobante { get; private set; }
        public int cantidad { get; private set; }
        public string descripcion { get; private set; }
        public double total { get; private set; }
        public DateTime fechaPago { get; private set; }

        public ComprobantePago(int codComp,string tipoComp,int cant,string descr,double total,DateTime fechaPago)
        {
            codComprobante = codComp;
            tipoComprobante = tipoComp;
            cantidad = cant;
            descripcion = descr;
            this.total = total;
            this.fechaPago = fechaPago;
        }
    }
}
