namespace SibCCSPETest.Data
{
    public interface ITopicQuestionRepository : IRepositoryBase<TopicQuestion>
    {
        Task AddTopicQuestionAsync(TopicQuestion entity);
        void UpdateTopicQuestion(TopicQuestion entity);
        void DeleteTopicQuestion(TopicQuestion entity);
    }
}
