using Microsoft.Azure.Documents;
using NuGet.Protocol.Plugins;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        #region Public Methods

        AccessToken CreateToken(
            User user, List<OperationClaim> operationClaims);

        #endregion Public Methods
    }
}