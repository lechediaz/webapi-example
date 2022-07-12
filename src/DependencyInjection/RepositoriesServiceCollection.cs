using webapi_example.Data.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepositoriesServiceCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) =>
            services.AddScoped<ICourseRepository, CourseRepository>()
                .AddScoped<IStudentRepository, StudentRepository>()
                .AddScoped<IStudentCoursesRepository, StudentCoursesRepository>();
    }
}