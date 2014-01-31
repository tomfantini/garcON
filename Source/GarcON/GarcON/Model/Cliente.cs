using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarcON.Model
{
    public class Cliente : Pessoa
    {
        public int Id { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
