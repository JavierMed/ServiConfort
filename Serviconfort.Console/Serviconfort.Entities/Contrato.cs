using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    class Contrato
    {
        private string idCotizacion { get; set; }
        public DateTime fechaInicioContra { get; set; }
        public DateTime fechaCulminacionContra { get; set; }
        public DateTime fechaGarantiaExten { get; set; }
        public string idPago { get; set; }
    }
}
