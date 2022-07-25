using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webapi_example.Models.Base;

namespace webapi_example.Models.Entities
{
    [Table("Student")]
    public class Student : IHasId
    {
        [Column("StudentId")]
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