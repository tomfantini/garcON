using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarcON.Model
{
    public class ProdutoCategoria
    {
        public enum Categoria
        { 
            Lanche = 1,
            Prato = 2,
            Porcao = 3,
            Suco = 4,
            Cerveja = 5,
            Refrigerante = 6,
            Agua = 7,
            Dose = 8,
            Pizza = 9,
            Outros = 10
        }
    }
}
