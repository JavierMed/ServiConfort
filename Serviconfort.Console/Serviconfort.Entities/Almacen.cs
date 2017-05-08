using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class Almacen
    {
        private double _codAlmacen;

        public double CodAlmacen
        {
            get
            {
                return _codAlmacen;
            }
            set
            {
                if (value > 0)
                    _codAlmacen = value;
            }
        }

        public Almacen (double codAlmacen)
        {
            CodAlmacen = codAlmacen;
        }
    }
}
