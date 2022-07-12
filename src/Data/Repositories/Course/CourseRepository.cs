using webapi_example.Data.Base;
using webapi_example.Models.Entities;

namespace webapi_example.Data.Repositories
{
    public class CourseRepository : RepositoryBase<Course, ApplicationDbContext>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}