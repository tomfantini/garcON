using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garcON.Model
{
    public class Cardapio
    {
        public int Id { get; set; }
        public List<Produto> Produto { get; set; }
        public ProdutoCategoria Categoria { get; set; }

    }
}
