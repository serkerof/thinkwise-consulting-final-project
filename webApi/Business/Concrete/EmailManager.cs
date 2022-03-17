using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmailManager : IEmailService
    {
        private IEmailDal _emailDal;

        public EmailManager(IEmailDal emailDal)
        {
            _emailDal = emailDal;
        }

        public IResult Add(Email email)
        {
            _emailDal.Add(email);
            return new SuccessResult(Messages.Success + email.EmailAddress);
        }

        public IResult Delete(Email email)
        {
            _emailDal.Delete(email);
            return new SuccessResult(Messages.Deleted + email.EmailAddress);
        }

        public IDataResult<Email> Get(int id)
        {
            return new SuccessDataResult<Email>(_emailDal.Get(filter: x => x.ID == id));
        }

        public IDataResult<List<Email>> GetList()
        {
            return new SuccessDataResult<List<Email>>(_emailDal.GetList());
        }

        public IResult Update(Email email)
        {
            _emailDal.Update(email);
            return new SuccessResult(Messages.Updated + email.EmailAddress);
        }
    }
}