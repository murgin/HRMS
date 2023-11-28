using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
    public class SalarySheetItem
    {
        public Guid Id;
        public decimal BaseSalary;
        public decimal Bonus;
        public decimal Fine;
        public decimal Other;
    }
}
