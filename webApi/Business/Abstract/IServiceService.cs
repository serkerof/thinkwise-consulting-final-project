using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IServiceService
    {
        #region Public Methods

        IResult Add(Service service);

        IResult Delete(Service service);

        IDataResult<Service> Get(int id);

        IDataResult<List<Service>> GetList();

        IResult Update(Service service);

        #endregion Public Methods
    }
}