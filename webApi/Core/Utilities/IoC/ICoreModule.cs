using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    public interface ICoreModule
    {
        #region Public Methods

        void Load(IServiceCollection serviceCollection);

        #endregion Public Methods
    }
}