using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SZZP2._2.Models.SZZPViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Powtórz hasło")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        public List<SelectListItem> ApplicationRoles { get; set; }
        [Display(Name = "Rola w systemie")]
        public string ApplicationRoleId { get; set; }
    }
}
