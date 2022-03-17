using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Order : IEntities
    {
        public int ID { get; set; }
        public int TeamID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
    }
}