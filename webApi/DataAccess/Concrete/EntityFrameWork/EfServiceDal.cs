using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntityFrameWork.Contexts;


namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfServiceDal : EfEntityRepositoryBase<Service, TwcContext>, IServiceDal
    {
    }
}