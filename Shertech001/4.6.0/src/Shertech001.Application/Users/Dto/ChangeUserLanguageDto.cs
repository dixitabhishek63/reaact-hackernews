using System.ComponentModel.DataAnnotations;

namespace Shertech001.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}