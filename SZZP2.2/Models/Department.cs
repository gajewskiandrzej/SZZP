using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class Department
    {
        [Key]
        public int IDDepartment { get; set; }
        public int IDOffice { get; set; }
        [Display(Name = "Nazwa")]
        public string NameDepartment { get; set; }
        [Display(Name = "Symbol")]
        public string SymbolDeprtament { get; set; }

        public Office Offices { get; set; }
    }
}
