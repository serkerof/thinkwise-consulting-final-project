using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmailService
    {
        #region Public Methods

        IResult Add(Email email);

        IResult Delete(Email email);

        IDataResult<Email> Get(int id);

        IDataResult<List<Email>> GetList();

        IResult Update(Email email);

        #endregion Public Methods
    }
}