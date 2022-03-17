using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        #region Public Constructors

        public AdminValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Boş ola bilməz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Boş ola bilməz");
            RuleFor(x => x.ID).NotEmpty().WithMessage("Email Boş ola bilməz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifrə Boş ola bilməz");
            RuleFor(x => x.Password).Length(8, 20).WithMessage("Şifrə uzunluğu 8 ilə 20 arasında olmalıdır");
            RuleFor(x => x.Password).Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,20}$").WithMessage("Şifrə 8 ilə 20 arasında olmalıdır");
        }

        #endregion Public Constructors
    }
}