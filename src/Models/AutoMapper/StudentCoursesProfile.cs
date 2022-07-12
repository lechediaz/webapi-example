using AutoMapper;
using webapi_example.Models.Dtos;
using webapi_example.Models.Entities;

namespace webapi_example.Models.AutoMapper
{
    public class StudentCoursesProfile : Profile
    {
        public StudentCoursesProfile()
        {
            CreateMap<CreateStudentCoursesDto, StudentCourses>();
        }
    }
}