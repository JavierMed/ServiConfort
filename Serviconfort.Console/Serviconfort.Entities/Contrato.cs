using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Contrato
    {
        public string idCotizacion { get; private set; }
        public DateTime fechaInicioContra { get; private set; }
        public DateTime fechaCulminacionContra { get; private set; }
        public DateTime fechaGarantiaExtern { get; private set; }
        public string idPago { get; private set; }

        //llamando la clase FormaPago
        public FormaPago FormaPago { get; set; }

        //metodo de la clase FormaPago
        public Contrato(FormaPago formapago)
        {
            FormaPago = formapago;
        }
        //los demas metodos
        public Contrato(string idcoti,DateTime fechaIni,DateTime fechaCulmin,DateTime fechaGaran)
        {
            idCotizacion = idcoti;
            fechaInicioContra = fechaIni;
            fechaCulminacionContra = fechaCulmin;
            fechaGarantiaExtern = fechaGaran;
        }
    }
}
