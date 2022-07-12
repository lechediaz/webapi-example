using webapi_example.Data.Base;
using webapi_example.Models.Entities;

namespace webapi_example.Data.Repositories
{
    public class StudentRepository : RepositoryBase<Student, ApplicationDbContext>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}