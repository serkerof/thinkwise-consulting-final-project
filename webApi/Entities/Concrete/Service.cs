using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Service : IEntities
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public bool Diccounted { get; set; }
    }
}