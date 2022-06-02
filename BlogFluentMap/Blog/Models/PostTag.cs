using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    [Table("PostTag")]
    public class PostTag{
        [Key]
        [Required]
        public int PostId { get; set; }

        [Key]
        [Required]
        public int TagId { get; set; }
    }
}