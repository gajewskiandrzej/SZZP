using System.Collections.Generic;

namespace SZZP2._2.Models.SZZPViewModels
{
    public class EmploymentIndexData
    {
        public IEnumerable<Employment> Employments { get; set; }
        public IEnumerable<Office> Offices { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
