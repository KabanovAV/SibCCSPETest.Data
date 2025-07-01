﻿using System.Linq.Expressions;

namespace SibCCSPETest.Data
{
    public class AnswerRepository : RepositoryBase<Answer>, IAnswerRepository
    {
        public AnswerRepository(DbDataContext db)
            : base(db) { }

        public async Task<IEnumerable<Answer>> GetAllAnswerAsync(Expression<Func<Answer, bool>>? expression = null, string? includeProperties = null)
            => await GetAllAsync(expression, includeProperties);

        public async Task<Answer> GetAnswerAsync(Expression<Func<Answer, bool>> expression, string? includeProperties = null)
            => await GetAsync(expression, includeProperties);

        public async Task AddAnswerAsync(Answer entity) => await AddAsync(entity);
        public async Task AddRangeAnswerAsync(List<Answer> entities) => await AddRangeAsync(entities);
        public void UpdateAnswer(Answer entity) => Update(entity);
        public void DeleteAnswer(Answer entity) => Delete(entity);
    }
}
