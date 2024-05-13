using System.ComponentModel.DataAnnotations;

namespace ThinkAM.Sites.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}