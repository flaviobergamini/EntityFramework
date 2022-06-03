using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("User")]
    public class User{
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(80)]
        [Column("Name", TypeName ="NVARCHAR")]
        public string? Name { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("Email", TypeName ="NVARCHAR")]
        public string? Email { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("PasswordHash", TypeName ="NVARCHAR")]
        public string? PasswordHash { get; set; }

        [Required]
        [Column("Bio", TypeName ="TEXT")]
        public string? Bio { get; set; }

        [Required]
        [MaxLength(2000)]
        [Column("Image", TypeName ="NVARCHAR")]
        public string? Image { get; set; }

        [Required]
        [MaxLength(80)]
        [Column("Slug", TypeName ="NVARCHAR")]
        public string? Slug { get; set; }

    }
}