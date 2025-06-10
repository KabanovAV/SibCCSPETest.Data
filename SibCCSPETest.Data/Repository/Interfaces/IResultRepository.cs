using System.Linq.Expressions;

namespace SibCCSPETest.Data
{
    public interface IResultRepository : IRepositoryBase<Result>
    {
        Task<IEnumerable<Result>> GetAllResultAsync(Expression<Func<Result, bool>>? expression = null, string? includeProperties = null);
        Task<Result> GetResultAsync(Expression<Func<Result, bool>> expression, string? includeProperties = null);
        Task AddResultAsync(Result entity);
        void UpdateResult(Result entity);
        void DeleteResult(Result entity);
    }
}
