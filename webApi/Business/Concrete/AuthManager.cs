using Azure.Core;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        #region Public Methods

        public IResult AdminExists(string email)
        {
            throw new NotImplementedException();
        }

        public IResult CommenterExists(string email)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(Admin admin)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(Commenter commenter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public IResult CustomerExists(string email)
        {
            throw new NotImplementedException();
        }

        public IResult EmployeeExists(string email)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Admin> Login(AdminForLoginDto adminForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Commenter> Login(CommenterForRegisterDto commenterForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Commenter> Login(CommenterForLoginDto commenterForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> Login(CustomerForLoginDto customerForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Employee> Login(EmployeeForLoginDto EmployeeForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Admin> Register(AdminForRegisterDto adminForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> Register(CustomerForRegisterDto customerForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Employee> Register(EmployeeForRegisterDto EmployeeForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods
    }
}