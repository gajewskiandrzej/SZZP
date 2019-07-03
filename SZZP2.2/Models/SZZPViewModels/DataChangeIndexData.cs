using System.Collections.Generic;

namespace SZZP2._2.Models.SZZPViewModels
{
    public class DataChangeIndexData
    {
        public IEnumerable<DataChange> DataChanges { get; set; }
        public IEnumerable<ADUser> AdUsers { get; set; }
        public IEnumerable<Office> Offices { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
