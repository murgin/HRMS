using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
    public class LogSearchWhere
    {
        public string RealName { get; set; }
        public bool ExistDate { get; set; }
        public DateTime ActionDateFrom { get; set; }
        public DateTime ActionDateTo { get; set; }
        public string ActionDesc { get; set; }
    }
}
