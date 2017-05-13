using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Servicio
    {
        public int CodServicio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public int IdCotizacion { get; set; }
        public Cotizaciones Cotizaciones { get; set; }

        public int CodTrabajador { get; set; }
        public Trabajador Trabajador { get; set; }
    }
}
