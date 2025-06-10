using System.Linq.Expressions;

namespace SibCCSPETest.Data
{
    public interface ISpecializationRepository : IRepositoryBase<Specialization>
    {
        Task<IEnumerable<Specialization>> GetAllSpecializationAsync(Expression<Func<Specialization, bool>>? expression = null, string? includeProperties = null);
        Task<Specialization?> GetSpecializationAsync(Expression<Func<Specialization, bool>> expression, string? includeProperties = null);
        Task AddSpecializationAsync(Specialization entity);
        void UpdateSpecialization(Specialization entity);
        void DeleteSpecialization(Specialization entity);
    }
}
