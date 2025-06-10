using System.Linq.Expressions;

namespace SibCCSPETest.Data
{
    public interface IAnswerRepository : IRepositoryBase<Answer>
    {
        Task<IEnumerable<Answer>> GetAllAnswerAsync(Expression<Func<Answer, bool>>? expression = null, string? includeProperties = null);
        Task<Answer> GetAnswerAsync(Expression<Func<Answer, bool>> expression, string? includeProperties = null);
        Task AddAnswerAsync(Answer entity);
        void UpdateAnswer(Answer entity);
        void DeleteAnswer(Answer entity);
    }
}
