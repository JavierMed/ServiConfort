using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Pedido
    {
        public int codCompra { get; set; }
        public int idProducto { get; set; }
        public List<Producto> Producto { get; set; }
        public Proveedor Proveedor { get; set; }
        public int idProveedor { get; set; }
        public int cantidad { get; set; }
        public double precioCompra { get; set; }
        public double descuento { get; set; }
        public int idPago { get; set; }
        public FormaPago FormaPago { get; set; }

        public Pedido()
        {
            Producto = new List<Producto>();
            Proveedor = new Proveedor();
            FormaPago = new FormaPago();
        }
    }
}
