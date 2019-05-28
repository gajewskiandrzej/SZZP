using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class Status
    {
        [Key]
        public int IDStatus { get; set; }
        [Display(Name ="Status")]
        public string NameStatus { get; set; }
    }
}
