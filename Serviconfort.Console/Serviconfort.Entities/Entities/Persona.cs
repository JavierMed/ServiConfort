using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Persona
    {
        public int CodPersona { get; set; }
        public string nombres { get; set; }
        public string direccion { get; set; }
        public int idTipocontac { get; set; }
        public int idDocumento { get; set; }
        public int idUbigeo { get; set; }
        public string numDocumento { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public List<Contacto> Contactos { get; set; }
        public Documento Documento { get; set; }

        public Persona()
        {
            Ubigeo = new Ubigeo();
            Contactos = new List<Contacto>();
            Documento = new Documento();
        }
    }
}
