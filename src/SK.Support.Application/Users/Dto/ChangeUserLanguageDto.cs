using System.ComponentModel.DataAnnotations;

namespace SK.Support.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}