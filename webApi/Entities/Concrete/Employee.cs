using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Employee : IEntities
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public int EmailID { get; set; }
        public int MobileNumber { get; set; }
        public int Password { get; set; }

        public int AdminID { get; set; }
    }
}