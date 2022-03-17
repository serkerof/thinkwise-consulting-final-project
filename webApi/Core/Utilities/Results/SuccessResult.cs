namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        #region Public Constructors

        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }

        #endregion Public Constructors
    }
}