using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IEntities
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int EmailID { get; set; }
        public int UserID { get; set; }
        public string? MobileNumber { get; set; }
    }
}