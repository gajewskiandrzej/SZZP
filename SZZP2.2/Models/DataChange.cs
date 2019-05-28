using System;
using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class DataChange
    {
        [Key]
        public int IDDataChange { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data zmiany")]
        public DateTime DateChange { get; set; }
        [Display(Name = "Numer SAP")]
        public string NrSap { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "Nazwa Biura")]
        public int IDOffice { get; set; }
        [Display(Name = "Nazwa Wydziału")]
        public int IDDepartment { get; set; }
        [Display(Name = "Nowe Biuro")]
        public int? NewIDOffice { get; set; }
        [Display(Name = "Nowy Wydział")]
        public int? NewIDDepartament { get; set; }
        [Display(Name = "Nowe nazwisko")]
        public string NewSurname { get; set; }
        [Display(Name = "Status")]
        public string StatusDataChange { get; set; }

        public ADUser ADUsers { get; set; }
    }
}
