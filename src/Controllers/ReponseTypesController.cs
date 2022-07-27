using Microsoft.AspNetCore.Mvc;
using webapi_example.Models.Entities;

namespace webapi_example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReponseTypesController : ControllerBase
    {
        #region Responder con tipos básicos

        /// <summary>
        /// Responder con una cadena de texto.
        /// </summary>
        [HttpGet("string")]
        public string GetString() => "Hola humano";

        /// <summary>
        /// Responder con número.
        /// </summary>
        [HttpGet("number")]
        public int GetNumber() => 1945;

        /// <summary>
        /// Responder con una bandera.
        /// </summary>
        [HttpGet("boolean")]
        public bool GetBoolean() => 1 > 0;

        #endregion

        #region Responder con tipos complejos

        /// <summary>
        /// Responder con un tipo complejo (Clase).
        /// </summary>
        [HttpGet("complex")]
        public Course GetComplex() => new Course()
        {
            Id = 9999,
            Description = "Curso de ejemplo",
            Name = "Curso de ASP.NET Core gratis."
        };

        /// <summary>
        /// Responder con un tipo complejo (Lista).
        /// </summary>
        [HttpGet("complex-list")]
        public List<Course> GetComplexList() => new List<Course>() {
            new Course()
            {
                Id = 9997,
                Name = "Curso de SQL Server gratis."
            },
            new Course()
            {
                Id = 9998,
                Name = "Curso de ReactJs gratis."
            },
            new Course()
            {
                Id = 9999,
                Description = "Curso de ejemplo",
                Name = "Curso de ASP.NET Core gratis."
            },
        };

        #endregion

        #region Diferentes tipos de respuesta según calculos u operaciones.

        /// <summary>
        /// Cuando no conocemos tipo de respuesta o existen varias posibilidades de respuesta.
        /// </summary>
        [HttpGet("action-result/{number:int}")]
        public IActionResult GetActionresult(int number)
        {
            // Operacion
            if (number > 10)
            {
                return Conflict("The max number supported is 10");
            }

            return Ok();
        }

        /// <summary>
        /// Cuando conocemos tipo de respuesta al estar todo correcto, pero existen varias posibilidades de respuesta.
        /// </summary>
        [HttpGet("course/{id:int}")]
        public ActionResult<Course> GetActionresultWithType(int id)
        {
            // Operacion
            if (id != 9999)
            {
                return NotFound();
            }

            // Se podría retornar respuesta de otro tipo, pero es mala práctica, en caso de ser necesario usar IActionResult.
            // return Ok(12);

            return Ok(new Course()
            {
                Id = 9999,
                Description = "Curso de ejemplo",
                Name = "Curso de ASP.NET Core gratis."
            });
        }

        #endregion

        #region Peticiones Síncronas y Asíncronas

        private Task OperacionBloqueante() => Task.Delay(1000 * 30);

        /// <summary>
        /// Petición con operación bloqueante que ha sido tratada de forma asíncrona.
        /// </summary>
        [HttpGet("async-request")]
        public async Task<string> GetWithAsync()
        {
            // Simular operación bloqueante.
            await OperacionBloqueante();

            return "Finished";
        }

        #endregion
    }
}