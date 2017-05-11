using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class ContactoXPersona
    {
        public Contacto Contacto;
        
        public ContactoXPersona()
        {
            //Contacto = new Contacto();
        }

        public Contacto Contacto { get { return TipoContacto; } }
    }
}
