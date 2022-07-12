using webapi_example.Data.Base;
using webapi_example.Models.Entities;

namespace webapi_example.Data.Repositories
{
    public class StudentCoursesRepository : RepositoryBase<StudentCourses, ApplicationDbContext>, IStudentCoursesRepository
    {
        public StudentCoursesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}