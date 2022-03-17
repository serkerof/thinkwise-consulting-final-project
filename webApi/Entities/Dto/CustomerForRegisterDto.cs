using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.Dto
{
    public class CustomerForRegisterDto : IDto
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? MobileNumber { get; set; }

        public Email? Email { get; set; }
    }
}