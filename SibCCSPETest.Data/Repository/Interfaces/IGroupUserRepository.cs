namespace SibCCSPETest.Data
{
    public interface IGroupUserRepository : IRepositoryBase<GroupUser>
    {        
        Task AddGroupUserAsync(GroupUser entity);
        void UpdateGroupUser(GroupUser entity);
        void DeleteGroupUser(GroupUser entity);
    }
}
