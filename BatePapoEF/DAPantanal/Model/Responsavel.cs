using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPantanal.Model{

    [Table("Responsavel")]
    class Responsavel{

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_responsavel{get; set;}

        [Required]
        [MaxLength(100)]
        [Column("nome", TypeName = "NVARCHAR")]
        public string? nome{get; set;}

        [Required]
        [MaxLength(14)]
        [Column("cpf", TypeName = "NVARCHAR")]
        public string? cpf{get; set;}

        [Required]
        [MaxLength(40)]
        [Column("profissao", TypeName = "NVARCHAR")]
        public string? profissao{get; set;}

        [MaxLength(50)]
        [Column("email", TypeName = "NVARCHAR")]
        public string? email{get; set;}
    }
}