﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.entities
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }

        public Almacen Almacen { get; set; }
        public Pedido Pedido { get; set; }

        public Producto()
        {
          Almacen = new Almacen();
        }
    }
}
