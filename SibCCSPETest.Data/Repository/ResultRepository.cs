﻿using System.Linq.Expressions;

namespace SibCCSPETest.Data
{
    public class ResultRepository : RepositoryBase<Result>, IResultRepository
    {
        public ResultRepository(DbDataContext db)
            : base(db) { }

        public async Task<IEnumerable<Result>> GetAllResultAsync(Expression<Func<Result, bool>>? expression = null, string? includeProperties = null)
            => await GetAllAsync(expression, includeProperties);

        public async Task<Result> GetResultAsync(Expression<Func<Result, bool>> expression, string? includeProperties = null)
            => await GetAsync(expression, includeProperties);

        public async Task AddResultAsync(Result entity) => await AddAsync(entity);
        public void UpdateResult(Result entity) => Update(entity);
        public void DeleteResult(Result entity) => Delete(entity);
    }
}
