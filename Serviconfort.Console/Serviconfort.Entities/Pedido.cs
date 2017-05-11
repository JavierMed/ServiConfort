using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Entities
{
    public class Pedido 
    {
        private int codCompra { get; set; }
        public string idProducto { get; set; }
        public string idProvedor { get; set; }
        public string cantidad { get; set; }
        private string precioCompra { get; set; }
        private string descuento { get; set; }
        public string idPago { get; set; }
        public int codComprobante { get; set; }

        public Pedido(int codcompra)
        {
            codCompra = codcompra;
        }

        public Pedido(string idproducto)
        {
            idProducto = idproducto;
        }

        public Pedido(string idprovedor)
        {
            idProvedor = idprovedor;
        }

        public Pedido(string Cantidad)
        {
            cantidad = Cantidad;
        }

        public Pedido(string preciocompra)
        {
            precioCompra = preciocompra;
        }

        public Pedido(string Descuento)
        {
            descuento = Descuento;
        }

        public Pedido(int idpago)
        {
            idPago = idpago;
        }

        public Pedido(int CodComprobante)
        {
            codComprobante = CodComprobante;
        }

    }
}
