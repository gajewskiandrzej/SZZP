using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class Department
    {
        [Key]
        public int IDDepartment { get; set; }
        public int IDOffice { get; set; }
        [Display(Name = "Nazwa Wydziału ")]
        public string NameDepartment { get; set; }
        [Display(Name = "Symbol Wydziału")]
        public string SymbolDeprtament { get; set; }

        public Office Offices { get; set; }
    }
}
