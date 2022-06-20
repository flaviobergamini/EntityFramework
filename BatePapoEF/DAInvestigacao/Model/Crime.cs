using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAInvestigacao.Model{

    [Table("Crime")]
    public class Crime{

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCrime { get; set; }

        [Required]
        [Column("data", TypeName = "DATETIME")]
        public DateTime? data { get; set; }

        [Required]
        [MaxLength(45)]
        [Column("nome", TypeName = "VARCHAR")]
        public string? nome { get; set; }

        [MaxLength(45)]
        [Column("local", TypeName = "VARCHAR")]
        public string? local { get; set; }

        [Column("duracao", TypeName = "INT")]
        public int duracao { get; set; }

        [ForeignKey("VilaoidVilao")]
        public int VilaoidVilao { get; set; }
        public Vilao? Vilao { get; set; }
    }
}