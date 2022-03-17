using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract
{
    public interface IUserService
    {
        #region Public Methods

        IResult Add(User user);

        IResult Delete(User user);

        IDataResult<User> Get(int id);

        User GetByMail(string email);

        List<OperationClaim> GetClaims(User user);

        IDataResult<List<User>> GetList();

        IResult Update(User user);

        #endregion Public Methods
    }
}