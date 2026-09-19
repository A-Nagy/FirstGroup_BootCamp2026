using System.ComponentModel.DataAnnotations;

namespace FirstGroup_1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }=string.Empty;
        [EmailAddress]
        public string? Email { get; set; }
        public string? Phone { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string Password { get; set; } = string.Empty;

        public ICollection<Role>? Roles { get; set; }

    }
}
