using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Distrito
    {
        public int idDistrito { get; set; }
        public string nombreDistrito { get; set; }

        public Distrito(int idDis, string nomDis)
        {
            idDistrito = idDis;
            nombreDistrito = nomDis;
        }

    }
}
