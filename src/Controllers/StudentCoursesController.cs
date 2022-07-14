using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi_example.Controllers.Base;
using webapi_example.Data.Repositories;
using webapi_example.Models.Dtos;
using webapi_example.Models.Entities;

namespace webapi_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentCoursesController : CustomControllerBase<StudentCourses>
    {
        private const string getStudentCoursesRouteName = "getStudentCourses";

        public StudentCoursesController(IStudentCoursesRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        /// <summary>
        /// Permite asociar un curso a un estudiante.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateStudentCoursesDto createStudentCoursesDto)
        {
            var entity = mapper.Map<StudentCourses>(createStudentCoursesDto);
            await repository.AddAsync(entity);
            return Ok();
        }

        /// <summary>
        /// Permite eliminar la asociación entre un curso a un estudiante.
        /// </summary>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}