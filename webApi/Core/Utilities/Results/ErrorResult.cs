namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        #region Public Constructors

        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }

        #endregion Public Constructors
    }
}