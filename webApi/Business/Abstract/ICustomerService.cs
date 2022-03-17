using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract;

public interface ICustomerService
{
    #region Public Methods

    IResult Add(Customer customer);

    IResult Delete(Customer customer);

    IDataResult<Customer> Get(int id);

    Customer GetByMail(string email);

    List<OperationClaim> GetClaims(Customer customer);

    IDataResult<List<Customer>> GetList();

    IResult Update(Customer customer);

    #endregion Public Methods
}