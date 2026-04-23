using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Doctor
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string email { get; set; }

        [Phone]
        [StringLength(30)]
        public string? phone { get; set; }

        [StringLength(100)]
        public string? specialty { get; set; }
    }
}
