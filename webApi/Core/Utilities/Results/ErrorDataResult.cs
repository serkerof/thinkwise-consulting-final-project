namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        #region Public Constructors

        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }

        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult(string message) : base(data: default, false, message)
        {
        }

        public ErrorDataResult() : base(default, false)
        {
        }

        #endregion Public Constructors
    }
}