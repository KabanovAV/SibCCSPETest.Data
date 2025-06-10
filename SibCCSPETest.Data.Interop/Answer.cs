using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Answer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Название ответа обязательно для заполнения")]
        public string Title { get; set; } = string.Empty;
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public Question? Question { get; set; }
    }
}
