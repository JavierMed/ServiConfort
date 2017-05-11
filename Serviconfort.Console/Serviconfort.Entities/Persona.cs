using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Persona
    {
        public int CodPersona { get; set; }
        public string nombres { get; set; }
        public string direccion { get; set; }
        public int IdTipocontac { get; set; }
        public int IdDocumento { get; set; }
        public int IdDistrito { get; set; }
        public int IdUbigeo { get; set; }

        public Persona()
        {

        }
    }
}
