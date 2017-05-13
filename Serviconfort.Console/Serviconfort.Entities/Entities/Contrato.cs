using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Contrato
    {
        public int CodContrato { get; set; }
        public int idCotizacion { get; set; }
        public Cotizaciones Cotizacion;
        public DateTime fechaInicioContra { get; set; }
        public DateTime fechaCulminacionContra { get; set; }
        public DateTime fechaGarantiaExtern { get; set; }
        public int idPago { get; set; }
        public int codAlmacen { get; set; }
        public Almacen Almacen { get; set; }

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
