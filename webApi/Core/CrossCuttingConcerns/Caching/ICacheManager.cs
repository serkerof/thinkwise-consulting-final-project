namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        #region Public Methods

        void Add(string key, object value, int duration);

        T Get<T>(string key);

        object Get(string key);

        bool IsAdd(string key);

        void Remove(string key);

        void RemoveByPattern(string pattern);

        #endregion Public Methods
    }
}