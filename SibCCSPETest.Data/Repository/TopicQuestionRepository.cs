﻿namespace SibCCSPETest.Data
{
    public class TopicQuestionRepository : RepositoryBase<TopicQuestion>, ITopicQuestionRepository
    {
        public TopicQuestionRepository(DbDataContext db)
            : base(db) { }

        public async Task AddTopicQuestionAsync(TopicQuestion entity) => await AddAsync(entity);
        public void UpdateTopicQuestion(TopicQuestion entity) => Update(entity);
        public void DeleteTopicQuestion(TopicQuestion entity) => Delete(entity);
    }
}
