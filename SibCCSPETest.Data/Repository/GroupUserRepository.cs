﻿namespace SibCCSPETest.Data
{
    public class GroupUserRepository : RepositoryBase<GroupUser>, IGroupUserRepository
    {
        public GroupUserRepository(DbDataContext db)
            : base(db) { }

        public async Task AddGroupUserAsync(GroupUser entity) => await AddAsync(entity);
        public void UpdateGroupUser(GroupUser entity) => Update(entity);
        public void DeleteGroupUser(GroupUser entity) => Delete(entity);
    }
}
