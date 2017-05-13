using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Ubigeo
    {
        List<Departamento> Departamento;
        List<Distrito> Distrito;
        List<Provincia> Provincia;

        public Ubigeo()
        {
            Departamento = new List<Departamento>();
            Distrito = new List<Distrito>();
            Provincia = new List<Provincia>();
        }

        //public Departamento Departamento { get { return nombreDepartamento; } }
        public void ingresarDepartamento(int id,string nom)
        {
            Departamento.Add(new Departamento());

        }
        public void ingresarDistrito(int id, string nom)
        {
            Distrito.Add(new Distrito());
        }
        public void ingresarProvincia(int id,string nom)
        {
            Provincia.Add(new Provincia());
        }
    }
}
