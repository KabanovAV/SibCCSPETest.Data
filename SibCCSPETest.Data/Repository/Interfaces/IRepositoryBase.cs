using System.Linq.Expressions;

namespace SibCCSPETest.Data
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null, string? includeProperties = null);
        Task<T?> GetAsync(Expression<Func<T, bool>> expression, string? includeProperties = null);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
