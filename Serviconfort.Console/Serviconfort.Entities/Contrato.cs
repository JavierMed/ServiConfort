using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class Contrato
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

        public Contrato()
        {

        }
        //los demas metodos
        public Contrato(string idcotiz)
        {
            idCotizacion = idcotiz;
        }

        public Contrato(DateTime fecIniContra)
        {
            fechaInicioContra = fecIniContra;
        }

        public  Contrato(DateTime fecCulmContra)
        {
            fechaCulminacionContra = fecCulmContra;
        }

        public Contrato(DateTime fecGarExt)
        {
            fechaGarantiaExtern = fecGarExt;
        }


        //metodos donde se operan
        
        public Contrato(string idpago)
        {
            idPago = idpago;
        }


    }
}
