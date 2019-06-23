using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class ADUser
    {
        [Key]
        [Display(Name = "Numer SAP")]
        public string NrSap { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data zatrudnienia")]
        public DateTime DateEmployment { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Koniec umowy")]
        public DateTime? EndContract { get; set; }
        [Display(Name = "Biuro")]
        public int IDOffice { get; set; }
        [Display(Name = "Department")]
        public int IDDepartment { get; set; }

        public Office Office { get; set; }
        //public ICollection<APPUser> APPUsers { get; set; }
        public ICollection<DataChange> DataChanges { get; set; }
        public ICollection<Dismissal> Dismissals { get; set; }
    }
}
