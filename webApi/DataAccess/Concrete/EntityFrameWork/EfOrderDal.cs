using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntityFrameWork.Contexts;


namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, TwcContext>, IOrderDal
    {
    }
}