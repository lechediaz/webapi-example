using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webapi_example.Models.Base;

namespace webapi_example.Models.Entities
{
    [Table("Course")]
    public class Course : IHasId
    {
        [Column("CourseId")]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }

        public virtual ICollection<StudentCourses> EnrolledStudents { get; set; }
    }
}