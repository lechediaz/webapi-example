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

        [HttpGet]
        public async Task<ActionResult<List<CourseDto>>> Get()
        {
            return await Get<CourseDto>();
        }

        [HttpGet("{id:int}", Name = getCourseRouteName)]
        public async Task<ActionResult<CourseDto>> Get(int id)
        {
            return await Get<CourseDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult<CourseDto>> Post([FromBody] CreateCourseDto createCourseDto)
        {
            return await Post<CreateCourseDto, CourseDto>(createCourseDto, getCourseRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateCourseDto updateCourseDto)
        {
            return await Put<UpdateCourseDto>(updateCourseDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}