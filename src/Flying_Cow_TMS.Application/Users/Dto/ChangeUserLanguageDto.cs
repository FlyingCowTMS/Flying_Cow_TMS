using System.ComponentModel.DataAnnotations;

namespace Flying_Cow_TMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}