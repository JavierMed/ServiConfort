using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Pedido
    {
        private int codCompra { get; set; }
        public Producto Producto { get; set; }
        public Proveedor Proveedor;
        public int cantidad { get; set; }
        private int precioCompra { get; set; }
        private double descuento { get; set; }
        public FormaPago FormaPago;
        public ComprobantePago Comprobante;

        public Pedido()
        {
            Producto = new Producto();
            Proveedor = new Proveedor();
            FormaPago = new FormaPago();
            Comprobante = new ComprobantePago();
        }
    }
}
