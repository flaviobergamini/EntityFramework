using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{
    
    [Table("Animal")]
    class Animal{
        [Key]
        public int id_animal{get; set;}
        public string? especie{get; set;}
        public string? alimentacao{get; set;}
        public char? sexo{get; set;}
    }
}