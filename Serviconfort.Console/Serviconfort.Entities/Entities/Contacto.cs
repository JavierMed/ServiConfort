using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Contacto
    {
        public int idTipoContacto { get; set; }
        public string contacto { get; set; }
        public int idPersona { get; set; }
        public Persona Persona { get; set; }

        public Contacto()
        {
            Persona = new Persona();
        }
    }
}
