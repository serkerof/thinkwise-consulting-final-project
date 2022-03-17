using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Concrete
{
    public class CommenterManager : ICommenterService
    {
        private ICommenterDal _commenterDal;

        public CommenterManager(ICommenterDal commenterDal)
        {
            _commenterDal = commenterDal;
        }

        public IResult Add(Commenter commenter)
        {
            _commenterDal.Add(commenter);
            return new SuccessResult(Messages.Success + commenter.Name);
        }

        public IResult Delete(Commenter commenter)
        {
            _commenterDal.Delete(commenter);
            return new SuccessResult(Messages.Deleted + commenter.Name);
        }

        public IDataResult<Commenter> Get(int id)
        {
            return new SuccessDataResult<Commenter>(_commenterDal.Get(filter: x => x.ID == id));
        }

        public Commenter GetByMail(string email)
        {
            throw new NotImplementedException();
        }

        public List<OperationClaim> GetClaims(Commenter commenter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Commenter>> GetList()
        {
            return new SuccessDataResult<List<Commenter>>(_commenterDal.GetList());
        }

        public IResult Update(Commenter commenter)
        {
            _commenterDal.Update(commenter);
            return new SuccessResult(Messages.Updated + commenter.Name);
        }
    }
}