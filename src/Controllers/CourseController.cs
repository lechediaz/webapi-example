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
    public class CourseController : CustomControllerBase<Course>
    {
        private const string getCourseRouteName = "getCourse";

        public CourseController(ICourseRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        /// <summary>
        /// Permite obtener todos los cursos.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<CourseDto>>> Get()
        {
            return await Get<CourseDto>();
        }

        /// <summary>
        /// Permite obtener un curso por su Id.
        /// </summary>
        [HttpGet("{id:int}", Name = getCourseRouteName)]
        public async Task<ActionResult<CourseDto>> Get(int id)
        {
            return await Get<CourseDto>(id);
        }

        /// <summary>
        /// Permite crear un curso.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<CourseDto>> Post([FromBody] CreateCourseDto createCourseDto)
        {
            return await Post<CreateCourseDto, CourseDto>(createCourseDto, getCourseRouteName);
        }

        /// <summary>
        /// Permite actualizar un curso.
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateCourseDto updateCourseDto)
        {
            return await Put<UpdateCourseDto>(updateCourseDto);
        }

        /// <summary>
        /// Permite eliminar un curso por Id.
        /// </summary>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}