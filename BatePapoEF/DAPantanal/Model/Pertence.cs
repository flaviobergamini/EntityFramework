using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{
    
    [Table("Pertence")]
    class Pertence{
        public int fk_animal{get; set;}
        public int fk_planta{get; set;}
    }
}