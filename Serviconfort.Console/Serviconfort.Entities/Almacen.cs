using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class Almacen
    {
        private double _idProducto;

        public int codAlmacen { get; private set; }
        public string modelo { get; private set; }
        public string capacidad { get; private set; }
        public string cantidad { get; private set; }
        public string precioCompra { get; private set; }
        public string precioVenta { get; private set; }
        public string descuento { get; private set; }
        
        public double IdProducto
        {
            get
            {
                return _idProducto;
            }
            set
            {
                if (value > 0)
                    _idProducto = value;
            }
        }

        public Almacen (double idProducto)
        {
            IdProducto = idProducto;
        }

        public Almacen(int codAlma)
        {
            codAlmacen = codAlma;
        }

        public Almacen(string mod)
        {
            modelo = mod;
        }

        public Almacen(string capa )
        {
            capacidad = capa;
        }

        public Almacen(string cant)
        {
            cantidad = cant;
        }

    }

    
}
