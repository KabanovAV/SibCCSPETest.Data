﻿using System.Linq.Expressions;

namespace SibCCSPETest.Data
{
    public class SpecializationRepository : RepositoryBase<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(DbDataContext db)
            : base(db) { }

        public async Task<IEnumerable<Specialization>> GetAllSpecializationAsync(Expression<Func<Specialization, bool>>? expression = null, string? includeProperties = null)
            => await GetAllAsync(expression, includeProperties);

        public async Task<Specialization?> GetSpecializationAsync(Expression<Func<Specialization, bool>> expression, string? includeProperties = null)
            => await GetAsync(expression, includeProperties);

        public async Task AddSpecializationAsync(Specialization entity) => await AddAsync(entity);
        public void UpdateSpecialization(Specialization entity) => Update(entity);
        public void DeleteSpecialization(Specialization entity) => Delete(entity);
    }
}
