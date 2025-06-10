using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Result
    {
        public int Id { get; set; }
        public int GroupUserId { get; set; }
        public int? AnswerId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public GroupUser? GroupUser { get; set; }
        [JsonIgnore]
        public Answer? Answer { get; set; }
    }
}
