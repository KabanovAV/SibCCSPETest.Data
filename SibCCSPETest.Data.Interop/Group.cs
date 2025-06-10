using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class Group
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Название группы обязательно для заполнения")]
        public string Title { get; set; } = string.Empty;
        public int SpecializationId { get; set; }
        [Required(ErrorMessage = "Дата начала обязательно для заполнения")]
        public DateTime? Begin { get; set; }
        [Required(ErrorMessage = "Дата окончания обязательно для заполнения")]
        public DateTime? End { get; set; }
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public Specialization? Specialization { get; set; }
        [JsonIgnore]
        public List<GroupUser>? GroupUser { get; set; }
        [JsonIgnore]
        public Setting? Setting { get; set; }
    }
}
