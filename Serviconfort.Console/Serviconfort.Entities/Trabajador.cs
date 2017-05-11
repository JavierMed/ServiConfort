using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    class Trabajador
    {
        public int CodTrabajador { get; set; }
        public double sueldo { get; set; }
        public double bonos { get; set; }
        public int IdCargo { get; set; }

        public List<Servicio> TipoServicio { get; set; }
        
        public Trabajador()
        {
            TipoServicio = new List<Servicio>();
        }
    }
}
