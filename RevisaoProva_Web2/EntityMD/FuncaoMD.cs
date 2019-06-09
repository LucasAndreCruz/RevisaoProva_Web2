using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoProva_Web2.Models
{
    [MetadataType(typeof(FuncaoMD))]

    public partial class Funcao { }

    public class FuncaoMD
    {
        [DisplayName("Código de Função")]
        public int FuncaoId { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public string Descricao { get; set; }
    }
}