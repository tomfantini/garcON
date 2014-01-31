using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarcON.Model
{
    public class Delivery
    {
        public int NumeroDelivery { get; set; }
        public Pedido Pedido { get; set; }

    }
}
