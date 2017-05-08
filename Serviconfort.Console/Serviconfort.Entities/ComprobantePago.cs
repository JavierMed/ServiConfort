﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    class ComprobantePago
    {
        public string tipoComprobante { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public double total { get; set; }
        public DateTime fechaPago { get; set; }
    }
}
