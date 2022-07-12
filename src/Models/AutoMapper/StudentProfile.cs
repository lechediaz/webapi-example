using AutoMapper;
using webapi_example.Models.Dtos;
using webapi_example.Models.Entities;

namespace webapi_example.Models.AutoMapper
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<CreateStudentDto, Student>();
            CreateMap<UpdateStudentDto, Student>();
            CreateMap<Student, StudentDto>();
        }
    }
}