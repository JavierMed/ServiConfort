using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class Cliente
    {
        public int CodCli { get; set;  }

        public Cliente()
        {

        }

        public Cliente (int codCli)
        {
            CodCli = codCli;
        }
    }
}
