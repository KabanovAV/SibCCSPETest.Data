using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class TopicQuestion
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public int QuestionId { get; set; }
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public Topic? Topic { get; set; }
        [JsonIgnore]
        public Question? Question { get; set; }        
    }
}
