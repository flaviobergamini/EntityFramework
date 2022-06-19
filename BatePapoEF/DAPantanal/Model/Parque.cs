using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{

    [Table("Parque")]
    class Parque{

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_parque{get; set;}

        [Required]
        [MaxLength(30)]
        [Column("localizacao", TypeName = "NVARCHAR")]
        public string? localizacao{get; set;}

        [Required]
        [MaxLength(30)]
        [Column("area", TypeName = "FLOAT")]
        public double area{get; set;}

        [Required]
        [MaxLength(15)]
        [Column("relevo", TypeName = "NVARCHAR")]
        public string? relevo{get; set;}

        [ForeignKey("fk_animal")]
        public int fk_animal{get; set;}
        public Animal? animal{get; set;}

        [ForeignKey("fk_planta")]
        public int fk_planta{get; set;}
        public Planta? planta{get; set;}
    }
}