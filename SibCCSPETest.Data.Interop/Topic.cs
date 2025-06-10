using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Topic
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Название темы обязательно для заполнения")]
        public string Title { get; set; } = string.Empty;
        public int SpecializationId { get; set; }
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public Specialization? Specialization { get; set; }
        [JsonIgnore]
        public List<TopicQuestion>? TopicQuestion { get; set; }
    }
}
