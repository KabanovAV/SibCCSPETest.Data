using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Количество символов от 10 до 100")]
        public string Title { get; set; } = string.Empty;
        public int SpecializationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }

        [JsonIgnore]
        public Specialization? Specialization { get; set; }
        [JsonIgnore]
        public List<TopicQuestion>? TopicQuestion { get; set; }
    }
}
