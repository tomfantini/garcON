using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace garcON.Model
{
    public class Delivery
    {
        [Key]
        public int NumeroPedido { get; set; }
        public Pedido Pedido { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Entregador { get; set; }

    }
}
