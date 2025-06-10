using System.ComponentModel.DataAnnotations;

namespace SibCCSPETest.Data
{
    public class SpecializationDTO
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Количество символов от 10 до 100")]
        public string Title { get; set; } = string.Empty;
    }
}
