using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{
    
    [Table("Planta")]
    class Planta{

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_planta{get; set;}

        [Required]
        [MaxLength(30)]
        [Column("especie", TypeName = "NVARCHAR")]
        public string? especie{get; set;}

        [Required]
        [MaxLength(100)]
        [Column("especie", TypeName = "NVARCHAR")]
        public string? grupo{get; set;}
    }
}