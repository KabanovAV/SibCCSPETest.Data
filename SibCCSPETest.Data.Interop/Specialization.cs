using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Specialization
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Название специализации обязательно для заполнения")]
        public string Title { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public List<Group>? Groups { get; set; }
        [JsonIgnore]
        public List<Topic>? Topics { get; set; }
    }
}
