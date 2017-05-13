﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Trabajador
    {
        public int CodTrabajador { get; set; }
        public double sueldo { get; set; }
        public double bonos { get; set; }
        public int IdCargo { get; set; }
        public int idServicio { get; set; }
        public Cargo Cargo { get; set; }
        public Servicio TipoServicio { get; set; }

        public Trabajador()
        {
            Cargo = new Cargo();
            TipoServicio = new Servicio();
        }
    }
}
