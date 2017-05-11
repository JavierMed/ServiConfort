using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Almacen
    {
        private double _idProducto;

        public int codAlmacen { get; private set; }
        public string modelo { get; private set; }
        public string capacidad { get; private set; }
        public int cantidad { get; private set; }
        public double precioCompra { get; private set; }
        public double precioVenta { get; private set; }
        public double descuento { get; private set; }
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

        public Almacen(int codAlmacen,string modelo,string capac,int cant,double preCom,double preVen,double desc,double idProducto)
        {
            this.codAlmacen = codAlmacen;
            this.modelo = modelo;
            capacidad = capac;
            cantidad = cant;
            precioCompra = preCom;
            precioVenta = preVen;
            descuento = desc;
            IdProducto = idProducto;
        }
    }
}
