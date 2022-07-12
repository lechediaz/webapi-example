using webapi_example.Models.Base;

namespace webapi_example.Models.Entities
{
    public class StudentCourses : IHasId
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}