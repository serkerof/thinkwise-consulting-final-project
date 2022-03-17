using Microsoft.IdentityModel.Tokens;

namespace Core.Extensions;

public class ValidationErrorDetails : ErrorDetails
{
    public IEnumerable<ValidationFailure>? Errors { get; set; }
}