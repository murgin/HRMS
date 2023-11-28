using HRMSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class ComboSource
    {
        private DepartmentService depServ = new DepartmentService();
        private OperatorService opServ = new OperatorService();
        public DataTable GetDepartmentSource()
        {
            return depServ.GetAllDepartments();
        }
        public DataTable GetOperatorSource()
        {
            return opServ.GetOperatorList();
        }
        public DataTable GetComboList(string type)
        {
            DictionaryService ds = new DictionaryService();
            return ds.GetComboList(type);
        }
    }
}
