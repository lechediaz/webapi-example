using webapi_example.Models.Base;

namespace webapi_example.Models.Dtos
{
    public class UpdateStudentDto : CreateStudentDto, IHasId
    {
        public int Id { get; set; }
    }
}