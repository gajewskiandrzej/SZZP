using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class Office
    {
        [Key]
        public int IDOffice { get; set; }
        [Display(Name ="Nazwa Biura")]
        public string NameOffice { get; set; }
        [Display(Name = "Symbol Biura")]
        public string SymbolOffice { get; set; }

        public ICollection<ADUser> ADUsers { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<Employment> Employment { get; set; }
    }
}
