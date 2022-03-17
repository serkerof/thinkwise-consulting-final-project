using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork.Contexts;

using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfEmailDal : EfEntityRepositoryBase<Email, TwcContext>, IEmailDal
    {
    }
}