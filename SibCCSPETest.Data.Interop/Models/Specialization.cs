using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Specialization
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Количество символов от 10 до 100")]
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }

        [JsonIgnore]
        public List<Group>? Groups { get; set; }
        [JsonIgnore]
        public List<Topic>? Topics { get; set; }
    }
}
