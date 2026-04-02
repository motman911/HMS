using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Patient
    {
        [Key] // Marks this as the primary key
        public int PatientId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(5)]
        public string BloodGroup { get; set; }

        [StringLength(10)]
        public string Genotype { get; set; }

        [Range(30, 250, ErrorMessage = "Height must be between 30cm and 250cm")]
        public float Height { get; set; }

        [Range(2, 300, ErrorMessage = "Weight must be between 2kg and 300kg")]
        public float Weight { get; set; }


    }
}
