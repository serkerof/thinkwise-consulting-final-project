using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Commenter : IEntities
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int EmailID { get; set; }
        public string? Message { get; set; }
        public int UserID { get; set; }
        public int AdminID { get; set; }
    }
}