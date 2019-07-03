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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data zatrudnienia")]
        public DateTime DateEmployment { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Koniec umowy")]
        public DateTime? EndContract { get; set; }
        [Display(Name = "Stanowisko")]
        public int IDPosition { get; set; }
        [Display(Name = "Status")]
        public int IDStatus { get; set; }

        public ADUser ADUsers { get; set; }
        public Office Offices { get; set; }
        public Status Statuses { get; set; }
        //public Position Positions { get; set; }
    }
}
