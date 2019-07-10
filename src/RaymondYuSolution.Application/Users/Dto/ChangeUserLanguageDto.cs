using System.ComponentModel.DataAnnotations;

namespace RaymondYuSolution.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}