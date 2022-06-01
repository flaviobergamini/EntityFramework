using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    [Table("Tag")]
    public class Tag{
        [Key]
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }

    }
}