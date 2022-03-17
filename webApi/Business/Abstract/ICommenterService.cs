using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract
{
    public interface ICommenterService
    {
        #region Public Methods

        IResult Add(Commenter commenter);

        IResult Delete(Commenter commenter);

        IDataResult<Commenter> Get(int id);

        Commenter GetByMail(string email);

        List<OperationClaim> GetClaims(Commenter commenter);

        IDataResult<List<Commenter>> GetList();

        IResult Update(Commenter commenter);

        #endregion Public Methods
    }
}