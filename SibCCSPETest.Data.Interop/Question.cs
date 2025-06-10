using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Question
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Название вопроса обязательно для заполнения")]
        public string Title { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public List<Answer>? Answers { get; set; }
        [JsonIgnore]
        public List<TopicQuestion>? TopicQuestion { get; set; }
    }
}
