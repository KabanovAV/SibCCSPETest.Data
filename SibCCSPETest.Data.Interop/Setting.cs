using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Setting
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int CountOfQuestion { get; set; }
        public TimeSpan? Timer { get; set; }
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public Group? Group { get; set; }
    }
}
