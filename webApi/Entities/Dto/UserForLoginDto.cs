using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.Dto
{
    public class UserForLoginDto : IDto
    {
        public int ID { get; set; }
        public int EmailID { get; set; }
        public Email? Email { get; set; }
    }
}