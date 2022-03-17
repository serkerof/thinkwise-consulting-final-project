using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract;

public interface IAdminService
{
    #region Public Methods

    IResult Add(Admin admin);

    IResult Delete(Admin admin);

    IDataResult<Admin> Get(int id);

    Admin GetByMail(string email);

    List<OperationClaim> GetClaims(Admin admin);

    IDataResult<List<Admin>> GetList();

    IResult Update(Admin admin);

    #endregion Public Methods
}