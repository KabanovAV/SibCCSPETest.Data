﻿using System.ComponentModel.DataAnnotations;

namespace SibCCSPETest.Data
{
    public class AnswerCreateDTO
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        public string Title { get; set; } = string.Empty;
        public int QuestionId { get; set; }
        [Display(Name = "Верный ответ")]
        public bool IsCorrect { get; set; }
    }
}
