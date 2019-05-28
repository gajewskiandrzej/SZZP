using System;
using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class Dismissal
    {
        [Key]
        public int IDDismissal { get; set; }
        [Display(Name ="Numer SAP")]
        public string NrSap { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "Stanowisko")]
        public int Position { get; set; }
        [Display(Name = "Biuro")]
        public int IDOffice { get; set; }
        [Display(Name = "Wydział")]
        public int IDDepartment { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data zwolnienia")]
        public DateTime EndContract { get; set; }
        [Display(Name = "Status")]
        public string StatusDismissal { get; set; }


        public ADUser ADUsers { get; set; }
    }
}
