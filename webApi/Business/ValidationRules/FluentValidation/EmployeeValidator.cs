using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        #region Public Constructors

        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Boş ola bilməz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Boş ola bilməz");
            RuleFor(x => x.ID).NotEmpty().WithMessage("Email Boş ola bilməz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifrə Boş ola bilməz");
        }

        #endregion Public Constructors
    }
}