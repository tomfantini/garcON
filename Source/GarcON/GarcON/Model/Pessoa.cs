using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarcON.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public Documento Documento { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }



    }

    public class Endereco
    {
        public string Descricao { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }

    public class Documento
    {
        public int Id { get; set; }
        public TipoDocumento Tipo { get; set; }
        public string Numero { get; set; }
    }

    public enum TipoDocumento
    {
        RG =1,
        CPF =2
    }
}
