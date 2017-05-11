using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Contrato
    {
        public Cotizaciones Cotizacion;
        public DateTime fechaInicioContra { get; private set; }
        public DateTime fechaCulminacionContra { get; private set; }
        public DateTime fechaGarantiaExtern { get; private set; }

        //llamando la clase FormaPago
        public FormaPago FormaPago;

        //metodo de la clase FormaPago
        public Contrato()
        {
            Cotizacion = new Cotizaciones();
            FormaPago = new FormaPago();
        }
    }
}
