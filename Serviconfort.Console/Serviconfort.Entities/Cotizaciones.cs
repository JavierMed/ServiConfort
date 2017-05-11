using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Cotizaciones
    {
        public int IdCotizaciones { get; set; }
        public DateTime FechaVisita { get; set; }
        public string Componente { get; set; }
        public string Caracteristica { get; set; }
        public double Costo { get; set; }
        public List<Servicio> TipoServicio { get; set; }

        public int CodTrabajador { get; set; }
        public Trabajador Trabajador { get; set; }

        public int CodCliente { get; set; }
        public Cliente Cliente { get; set; }

        public Cotizaciones()
        {
            TipoServicio = new List<Servicio>();
        }
    }
}
