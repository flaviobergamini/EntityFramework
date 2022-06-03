using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    [Table("Role")]
    public class Role{

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(80)]
        [Column("Name", TypeName = "VARCHAR")]
        public string? Name { get; set; }

        [Required]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string? Slug { get; set; }
    }
}