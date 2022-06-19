using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{
    
    [Table("Responsavel")]
    class Responsavel{
        [Key]
        public int id_responsavel{get; set;}
        public string? nome{get; set;}
        public string? cpf{get; set;}
        public string? profissao{get; set;}
        public string? email{get; set;}
    }
}