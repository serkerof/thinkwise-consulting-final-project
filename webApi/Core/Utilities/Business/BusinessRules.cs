using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        #region Public Methods

        public static IResult? Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }

        #endregion Public Methods
    }
}