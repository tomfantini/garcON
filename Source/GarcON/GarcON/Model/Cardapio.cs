using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarcON.Model
{
    public class Cardapio
    {
        public int Id { get; set; }
        public List<Produto> Oroduto { get; set; }
        public ProdutoCategoria Categoria { get; set; }

    }
}
