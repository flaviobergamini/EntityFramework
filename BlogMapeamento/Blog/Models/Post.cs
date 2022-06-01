using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    [Table("Post")]
    public class Post{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(160)]
        [Column("Title", TypeName = "VARCHAR")]
        public string? Title { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("Summary", TypeName = "VARCHAR")]
        public string? Summary { get; set; }

        [Required]
        [Column("Boby", TypeName = "TEXT")]
        public string? Body { get; set; }

        [Required]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string? Slug { get; set; }

        [Required]
        [Column("CreateDate", TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }

        [Required]
        [Column("CreateDate", TypeName = "DATETIME")]
        public DateTime LastUpdateDate { get; set; }

    }
}