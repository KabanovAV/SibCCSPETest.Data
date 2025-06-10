using System.Linq.Expressions;

namespace SibCCSPETest.Data
{
    public interface IQuestionRepository : IRepositoryBase<Question>
    {
        Task<IEnumerable<Question>> GetAllQuestionAsync(Expression<Func<Question, bool>>? expression = null, string? includeProperties = null);
        Task<Question> GetQuestionAsync(Expression<Func<Question, bool>> expression, string? includeProperties = null);
        Task AddQuestionAsync(Question entity);
        void UpdateQuestion(Question entity);
        void DeleteQuestion(Question entity);
    }
}
