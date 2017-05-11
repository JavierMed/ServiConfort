using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    class CliEmpresa : Cliente
    {
        public string RazonSocial { get; set; }
        public string PersonaContacto { get; set; }

        public void Identificarse()
        {
            Console.WriteLine("Soy un Cliente Empresa, " + "mi código es " + this.CodCli);
        }

        public CliEmpresa()
        {

        }

        public CliEmpresa(int codCli) : base(codCli)
        {

        }
    }
}
