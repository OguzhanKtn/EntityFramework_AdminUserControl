using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminUser.Models
{
    [Table("AdminUsers")]
    public class Admin : BaseModel
    {
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        [MaxLength(50),EmailAddress]
        public string Email { get; set; }
        [MaxLength(15)]
        public string? Phone { get; set; }
    }
}
