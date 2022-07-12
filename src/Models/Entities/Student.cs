using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace webapi_example.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        [MaxLength(60)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(80)]
        public string Email { get; set; }

        public virtual ICollection<StudentCourses> EnrolledCourses { get; set; }
    }
}