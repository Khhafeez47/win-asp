using System.ComponentModel.DataAnnotations;

namespace win-asp-core-iis.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}