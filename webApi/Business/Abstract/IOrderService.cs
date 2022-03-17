using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderService
    {
        #region Public Methods

        IResult Add(Order order);

        IResult Delete(Order order);

        IDataResult<Order> Get(int id);

        IDataResult<List<Order>> GetList();

        IResult Update(Order order);

        #endregion Public Methods
    }
}