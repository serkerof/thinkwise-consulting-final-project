using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public IResult Add(Admin admin)
        {
            _adminDal.Add(admin);
            return new SuccessResult(Messages.Success + admin.Name);
        }

        public IResult Delete(Admin admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult(Messages.Deleted + admin.Name);
        }

        public IDataResult<Admin> Get(int id)
        {
            return new SuccessDataResult<Admin>(_adminDal.Get(filter: x => x.ID == id));
        }

        public Admin GetByMail(string email)
        {
            throw new NotImplementedException();
        }

        public List<OperationClaim> GetClaims(Admin admin)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Admin>> GetList()
        {
            return new SuccessDataResult<List<Admin>>(_adminDal.GetList());
        }

        public IResult Update(Admin admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult(Messages.Updated + admin.Name);
        }

        IResult IAdminService.Add(Admin admin)
        {
            throw new NotImplementedException();
        }

        IResult IAdminService.Delete(Admin admin)
        {
            throw new NotImplementedException();
        }

        IDataResult<Admin> IAdminService.Get(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Admin>> IAdminService.GetList()
        {
            throw new NotImplementedException();
        }

        IResult IAdminService.Update(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}