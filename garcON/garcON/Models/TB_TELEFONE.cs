//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace garcON.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_TELEFONE
    {
        public int PessoaId { get; set; }
        public string DDDTelefoneResidencial { get; set; }
        public string TelefoneResidencial { get; set; }
        public string DDDTelefoneComercial { get; set; }
        public string TelefoneComercial { get; set; }
        public string DDDTelefoneCelular { get; set; }
        public string TelefoneCelular { get; set; }
        public string DDDTelefoneContato { get; set; }
        public string TelefoneContato { get; set; }
    
        public virtual TB_PESSOA TB_PESSOA { get; set; }
    }
}