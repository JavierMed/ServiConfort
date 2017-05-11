using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class CliNatural : Cliente
    {
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }

        public void Identificarse()
        {
            Console.WriteLine("Soy un cliente Natural, " + "mi codigo es " + this.CodCli);
        }

        public CliNatural()
        {

        }

        public CliNatural(int codCli) : base(codCli)
        {

        }
    }
}
