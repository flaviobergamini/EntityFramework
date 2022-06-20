using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAInvestigacao.Model{

    [Table("Vilao")]
    public class Vilao{

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVilao { get; set; }

        [Required]
        [MaxLength(45)]
        [Column("nome", TypeName = "VARCHAR")]
        public string? nome { get; set; }

        [Required]
        [Column("numCrime", TypeName = "INT")]
        public int numCrime { get; set; }
    }
}