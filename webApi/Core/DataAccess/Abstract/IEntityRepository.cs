using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        #region Public Methods

        void Add(T entity);

        void Delete(T entity);

        T Get(Expression<Func<T, bool>> filter);

        List<T> GetList(Expression<Func<T, bool>>? filter = null);

        void Update(T entity);

        #endregion Public Methods
    }
}