//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RevisaoProva_Web2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public int FuncaoId { get; set; }
    
        public virtual Funcao Funcao { get; set; }
    }
}