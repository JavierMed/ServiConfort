using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    class Pedido
    {
        private int codCompra { get; set; }
        public string idProducto { get; set; }
        public string idProvedor { get; set; }
        public int cantidad { get; set; }
        private int precioCompra { get; set; }
        private double descuento { get; set; }
        public string idPago { get; set; }
        public int codComprobante { get; set; }

        public Pedido(int codcompra,int cant,int preCompra,double desc)
        {
            codCompra = codcompra;
            cantidad = cant;
            precioCompra = preCompra;
            descuento = desc;
        }
    }
}
