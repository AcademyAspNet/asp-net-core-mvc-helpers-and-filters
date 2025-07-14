using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMvcHelpers.Models.Views
{
    public class FormViewModel
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Укажите имя")]
        [MinLength(2, ErrorMessage = "Минимальная длина имени - 2 символа")]
        [MaxLength(64, ErrorMessage = "Максимальная длина имени - 64 символа")]
        public string? FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Укажите фамилию")]
        [MinLength(2, ErrorMessage = "Минимальная длина фамилии - 2 символа")]
        [MaxLength(64, ErrorMessage = "Максимальная длина фамилии - 64 символа")]
        public string? LastName { get; set; }
    }
}
