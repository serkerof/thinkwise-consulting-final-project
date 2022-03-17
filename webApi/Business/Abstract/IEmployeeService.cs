using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        #region Public Methods

        IResult Add(Employee employee);

        IResult Delete(Employee employee);

        IDataResult<Employee> Get(int id);

        Employee GetByMail(string email);

        List<OperationClaim> GetClaims(Employee employee);

        IDataResult<List<Employee>> GetList();

        IResult Update(Employee employee);

        #endregion Public Methods
    }
}