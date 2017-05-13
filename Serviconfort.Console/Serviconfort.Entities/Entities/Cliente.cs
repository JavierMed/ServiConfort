using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Cliente
    {
        public int CodCli { get; set; }

        public ICollection<ComprobantePago> Comprobantes { get; set; }

        public Cliente()
        {
            Comprobantes = new HashSet<ComprobantePago>();
        }

        public Cliente(int codCli)
        {
            CodCli = codCli;
        }
    }
}
