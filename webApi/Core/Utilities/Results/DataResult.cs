namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        #region Public Constructors

        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        #endregion Public Constructors

        public T Data { get; }
    }
}