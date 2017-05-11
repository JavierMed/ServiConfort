﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class FormaPago
    {
        public int idPago { get; private set; }
        public string tipoPago { get; private set; }

        public FormaPago(int idpago,string tipoPago)
        {
            idPago = idpago;
            this.tipoPago = tipoPago;
        }
    }
}
