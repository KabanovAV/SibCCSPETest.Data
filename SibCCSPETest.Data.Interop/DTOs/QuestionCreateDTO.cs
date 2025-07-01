using System.ComponentModel.DataAnnotations;

namespace SibCCSPETest.Data
{
    public class QuestionCreateDTO
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        public string Title { get; set; } = string.Empty;
        public List<AnswerDTO>? AnswerItems { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }
    }
}
