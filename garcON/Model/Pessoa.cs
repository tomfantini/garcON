using garcON.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garcON.Model
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Documento Documento { get; set; }
        public Endereco Endereco { get; set; }

        public Telefone Telefone { get; set; }

    }

  
   

}
