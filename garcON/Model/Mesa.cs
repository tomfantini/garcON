using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace garcON.Model
{
    public class Mesa
    {
        [Key]
        public int NumeroMesa { get; set; }
        public Cliente Cliente { get; set; }
        public Pedido Pedido { get; set; }
        public Funcionario Garcon { get; set; }
    }
}
