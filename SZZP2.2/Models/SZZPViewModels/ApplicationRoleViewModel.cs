using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models.SZZPViewModels
{
    public class ApplicationRoleViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Nazwa roli")]
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
