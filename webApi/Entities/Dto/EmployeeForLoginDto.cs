using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.Dto
{
    public class EmployeeForLoginDto : IDto
    {
        public int ID { get; set; }
        public int EmailID { get; set; }
        public Email? Email { get; set; }
    }
}