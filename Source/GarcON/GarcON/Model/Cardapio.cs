using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarcON.Model
{
    public class Cardapio
    {
        public int id { get; set; }
        public List<Produto> produto { get; set; }
        public ProdutoCategoria categoria { get; set; }

    }
}
