using System.ComponentModel.DataAnnotations;

namespace SZZP2._2.Models
{
    public class Position
    {
        [Key]
        public int IDPosition { get; set; }
        [Display(Name ="Stanowisko")]
        public string NamePosition { get; set; }
    }
}
