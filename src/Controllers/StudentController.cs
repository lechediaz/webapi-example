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
    public class StudentController : CustomControllerBase<Student>
    {
        private const string getStudentRouteName = "getStudent";

        public StudentController(IStudentRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        /// <summary>
        /// Permite obtener todos los estudiantes.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<StudentDto>>> Get()
        {
            return await Get<StudentDto>();
        }

        /// <summary>
        /// Permite obtener un estudiante por su Id.
        /// </summary>
        [HttpGet("{id:int}", Name = getStudentRouteName)]
        public async Task<ActionResult<StudentDto>> Get(int id)
        {
            return await Get<StudentDto>(id);
        }

        /// <summary>
        /// Permite crear un estudiante.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<StudentDto>> Post([FromBody] CreateStudentDto createStudentDto)
        {
            return await Post<CreateStudentDto, StudentDto>(createStudentDto, getStudentRouteName);
        }

        /// <summary>
        /// Permite actualizar un estudiante.
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateStudentDto updateStudentDto)
        {
            return await Put<UpdateStudentDto>(updateStudentDto);
        }

        /// <summary>
        /// Permite eliminar un estudiante por Id.
        /// </summary>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}