﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Departamento
    {
        public int idDepartamento { get; set; }
        public string nombreDepartamento { get; set; }
        public Departamento()
        {

        }
        public Departamento(int idDep, string nomDep)
        {
            idDepartamento = idDep;
            nombreDepartamento = nomDep;
        }

    }
}
