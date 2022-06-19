using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{
    
    [Table("Animal")]
    class Animal{
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_animal{get; set;}

        [Required]
        [MaxLength(30)]
        [Column("especie", TypeName = "NVARCHAR")]
        public string? especie{get; set;}

        [Required]
        [MaxLength(100)]
        [Column("alimentacao", TypeName = "NVARCHAR")]
        public string? alimentacao{get; set;}

        [Required]
        [MaxLength(1)]
        [Column("sexo", TypeName = "NVARCHAR")]
        public char? sexo{get; set;}
    }
}