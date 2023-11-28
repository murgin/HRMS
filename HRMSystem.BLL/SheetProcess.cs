using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class SheetProcess
    {
        private SalarySheetService salServ = new SalarySheetService();
        private SalarySheetItemService itemServ = new SalarySheetItemService();
        private EmployeeService empServ = new EmployeeService();
        public bool IsEmployeeExist(SalarySheet ss)
        {
            if (empServ.IsEmployeeExist(ss.DepartmentId))
            {
                return true;
            }
            return false;
        }
        public bool IsSalarySheetExist(SalarySheet ss)
        {
            return salServ.IsSalarySheetExist(ss);
        }
        public Guid GetSalarySheetId(SalarySheet ss)
        {
            return salServ.GetSalarySheetId(ss);
        }　
        public void RebuildSalarySheetItem(SalarySheet ss)
        {　
            itemServ.RebuildSalarySheetItem(ss);
        }
        public DataTable GetSalarySheetItem(Guid id)
        {
            return itemServ.GetSalarySheetItem(id);
        }
        public void GenerateSalarySheet(SalarySheet ss)
        {
            salServ.GenerateSalarySheet(ss);
        }
        public void BuildSalarySheetItem(SalarySheet ss)
        {
            itemServ.BuildSalarySheetItem(ss);
        }
        public void SaveItem(SalarySheetItem item)
        {
            itemServ.SaveItem(item);
        }
    }
}
