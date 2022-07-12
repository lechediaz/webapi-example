using AutoMapper;
using webapi_example.Models.Dtos;
using webapi_example.Models.Entities;

namespace webapi_example.Models.AutoMapper
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<CreateCourseDto, Course>();
            CreateMap<UpdateCourseDto, Course>();
            CreateMap<Course, CourseDto>();
        }
    }
}