using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{
    
    [Table("Parque")]
    class Parque{
        [Key]
        public int id_parque{get; set;}
        public string? localizacao{get; set;}
        public double area{get; set;}
        public string? relevo{get; set;}
        public int fk_animal{get; set;}
        public int fk_planta{get; set;}
    }
}