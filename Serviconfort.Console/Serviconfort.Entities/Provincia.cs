using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Provincia
    {
        public int idProvincia { get; set; }
        public string nombreProvincia { get; set; }

        public Provincia(int idPro, string nomPro)
        {
            idProvincia = idPro;
            nombreProvincia = nomPro;
        }

    }
}
