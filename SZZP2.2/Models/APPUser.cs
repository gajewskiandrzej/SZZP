using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class APPUser
    {
        [Key]
        public int IDAPPUser { get; set; }
        [Display(Name = "Login")]
        public string Login { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Rola")]
        public int IDRole { get; set; }

        public Role Roles { get; set; }
    }
}
