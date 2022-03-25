using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AdminCRUD.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [DefaultValue("true")]
        public bool IsActive { get; set; }
    }
}
