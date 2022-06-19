using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{
    
    [Table("Pertence")]
    class Pertence{

        [ForeignKey("fk_animal")]
        public int fk_animal{get; set;}
        public Animal? animal{get; set;}

        [ForeignKey("fk_planta")]
        public int fk_planta{get; set;}
        public Planta? planta{get; set;}
    }
}