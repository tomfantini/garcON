using garcON.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garcON.Model
{
    public class Cliente : Pessoa
    {
        public int ClienteId { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
