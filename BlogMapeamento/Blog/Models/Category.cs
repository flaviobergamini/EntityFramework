using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    [Table("Category")]
    public class Category{

        [Key]   // Define no banco a chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //Define que o atributo é auto incremental
        public int id { get; set; }

        [Required]       // Define que o atributo nome é obrigatório
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string? Name { get; set; }

        [Required]       // Define que o atributo nome é obrigatório
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "VARCHAR")]
        public string? Slug { get; set; }

    }
}