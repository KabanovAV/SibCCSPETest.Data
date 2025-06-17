using System.ComponentModel.DataAnnotations;

namespace SibCCSPETest.Data
{
    public class QuestionCreateDTO
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        public string Title { get; set; } = string.Empty;
    }
}
