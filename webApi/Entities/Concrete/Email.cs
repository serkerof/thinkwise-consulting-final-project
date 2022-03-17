using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Email : IEntities
    {
        public int ID { get; set; }
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
    }
}