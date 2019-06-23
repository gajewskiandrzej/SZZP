using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models.SZZPViewModels
{
    public class LoginVM
    {
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
