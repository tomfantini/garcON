using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garcON.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public ProdutoCategoria Categoria { get; set; }
    }
}
