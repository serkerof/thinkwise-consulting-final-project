namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        #region Public Constructors

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        #endregion Public Constructors

        public string Message { get; }
        public bool Success { get; }
    }
}