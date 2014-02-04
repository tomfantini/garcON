using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarcON.Model
{
    public class Funcionario : Pessoa
    {
        public int FuncionarioId { get; set; }
        public string Funcao { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}
