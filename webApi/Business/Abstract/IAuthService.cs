using Azure.Core;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Abstract
{
    public interface IAuthService
    {
        #region Public Methods

        IResult AdminExists(string email);

        IResult CommenterExists(string email);

        IDataResult<AccessToken> CreateAccessToken(User user);

        IDataResult<AccessToken> CreateAccessToken(Admin admin);

        IDataResult<AccessToken> CreateAccessToken(Commenter commenter);

        IDataResult<AccessToken> CreateAccessToken(Customer customer);

        IDataResult<AccessToken> CreateAccessToken(Employee employee);

        IResult CustomerExists(string email);

        IResult EmployeeExists(string email);

        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        IDataResult<Admin> Login(AdminForLoginDto adminForLoginDto);

        IDataResult<Commenter> Login(CommenterForRegisterDto commenterForRegisterDto, string password);

        IDataResult<Commenter> Login(CommenterForLoginDto commenterForLoginDto);

        IDataResult<Customer> Login(CustomerForLoginDto customerForLoginDto);

        IDataResult<Employee> Login(EmployeeForLoginDto employeeForLoginDto);

        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);

        IDataResult<Admin> Register(AdminForRegisterDto adminForRegisterDto, string password);

        IDataResult<Customer> Register(CustomerForRegisterDto customerForRegisterDto, string password);

        IDataResult<Employee> Register(EmployeeForRegisterDto employeeForRegisterDto, string password);

        IResult UserExists(string email);

        #endregion Public Methods
    }
}