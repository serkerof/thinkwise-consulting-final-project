using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.Dto
{
    public class CommenterForRegisterDto : IDto
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public Email? Email { get; set; }
    }
}