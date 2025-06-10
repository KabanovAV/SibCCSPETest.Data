using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SibCCSPETest.Data
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Фамилия обязательно для заполнения")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        public string FirstName { get; set; } = string.Empty;
        public string? Surname { get; set; }
        [Required(ErrorMessage = "Логин обязательно для заполнения")]
        public string Login { get; set; } = string.Empty;
        [Required(ErrorMessage = "Пароль обязательно для заполнения")]
        public string Password { get; set; } = string.Empty;
        public string? Organization { get; set; }
        public string? Position { get; set; }
        public DateTime? CreatedDate { get; set; }

        [JsonIgnore]
        public List<GroupUser>? GroupUser { get; set; }
    }
}
