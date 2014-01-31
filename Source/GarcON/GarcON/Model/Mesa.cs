using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarcON.Model
{
    public class Mesa
    {
        public int NumeroMesa { get; set; }
        public Cliente Cliente { get; set; }
        public Pedido Pedido { get; set; }
        public Funcionario Garcon { get; set; }
    }
}
