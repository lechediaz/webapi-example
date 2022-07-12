using webapi_example.Models.Base;

namespace webapi_example.Models.Dtos
{
    public class UpdateCourseDto : CreateCourseDto, IHasId
    {
        public int Id { get; set; }
    }
}