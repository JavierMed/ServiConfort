﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Contacto
    {
        public int TipoContacto { get; set; }
        public string contacto { get; set; }
        public Contacto()
        {
        }
        public Contacto(int TipoCon,string conta)
        {
            TipoContacto = TipoCon;
            contacto = conta;
        }
    }
}
