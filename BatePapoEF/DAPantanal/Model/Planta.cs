using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{
    
    [Table("Planta")]
    class Planta{
        [Key]
        public int id_planta{get; set;}
        public string? especie{get; set;}
        public string? grupo{get; set;}
    }
}