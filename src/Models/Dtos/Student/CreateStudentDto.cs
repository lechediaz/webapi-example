using System.ComponentModel.DataAnnotations;

namespace webapi_example.Models.Dtos
{
    public class CreateStudentDto
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        [MaxLength(60)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(80)]
        public string Email { get; set; }
    }
}