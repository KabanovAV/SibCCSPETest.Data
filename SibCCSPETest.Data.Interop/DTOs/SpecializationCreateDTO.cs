using System.ComponentModel.DataAnnotations;

namespace SibCCSPETest.Data
{
    public class SpecializationCreateDTO
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [StringLength(100, ErrorMessage = "Количество символов до 100")]
        public string Title { get; set; } = string.Empty;
    }
}
