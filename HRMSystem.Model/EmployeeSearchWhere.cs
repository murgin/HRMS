using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
    public class EmployeeSearchWhere
    {
        public string Name { get; set; }
        public bool ExistDate { get; set; }
        public DateTime InDayFrom { get; set; }
        public DateTime InDayTo { get; set; }
        public Guid DeptId { get; set; }
    }
}
