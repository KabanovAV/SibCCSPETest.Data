using System.ComponentModel.DataAnnotations;

namespace SibCCSPETest.Data
{
    public class UserCreateDTO
    {
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "Количество символов от 10 до 30")]
        public string LastName { get; set; } = string.Empty;
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "Количество символов от 10 до 30")]
        public string FirstName { get; set; } = string.Empty;
        [Display(Name = "Отчество")]
        public string? Surname { get; set; }
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        public string Login { get; set; } = string.Empty;
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        public string Password { get; set; } = string.Empty;
        public string? Organization { get; set; }
        public string? Position { get; set; }
    }
}
