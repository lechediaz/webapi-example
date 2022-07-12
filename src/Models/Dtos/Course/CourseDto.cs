using System.ComponentModel.DataAnnotations;

namespace webapi_example.Models.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }
    }
}