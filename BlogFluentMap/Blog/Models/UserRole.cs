using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    [Table("UserRole")]
    public class UserRole{

        [Key]
        [Required]
        public int PK_Role { get; set; }

        [Key]
        [Required]
        public int UQ_Role_Slug { get; set; }
    }
}