using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class Pedido 
    {
        private double codCompra { get; set; }
        public string idProducto { get; set; }
        public string idProvedor { get; set; }
        public int cantidad { get; set; }
        private double precioCompra { get; set; }
        private double descuento { get; set; }
        public string idPago { get; set; }
        public double codComprobante { get; set; }
    }
}
