using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class SalarySheetItemService
    {
        public DataTable GetSalarySheetItem(Guid sheetId)
        {
            string sql = "SELECT s.Id AS 数据编号, Name AS 姓名, BaseSalary AS 基本工资, Bonus AS 津贴, Fine AS 罚款, Other AS 其他 FROM SalarySheetItem s, Employee e WHERE SheetId = @SheetId AND s.EmployeeId = e.Id";
            SqlParameter[] parameters = {
                new SqlParameter("@SheetId",sheetId)
            };
            return SqlHelper.GetDataTable(sql, parameters);
        }
        public void BuildSalarySheetItem(SalarySheet ss)
        {
            string sql1 = "SELECT Id FROM Employee WHERE DepartmentId = @deptId";
            string sql2 = "INSERT INTO SalarySheetItem VALUES(@Id, @SheetId, @EmployeeId, 0, 0, 0, 0)";
            SqlParameter parameter = new SqlParameter("@deptId", ss.DepartmentId);
            SqlDataReader dr = SqlHelper.ExecuteReader(sql1, parameter);
            while (dr.Read())
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@Id",Guid.NewGuid()),
                    new SqlParameter("@SheetId",ss.Id),
                    new SqlParameter("@EmployeeId",dr["Id"])
                };
                SqlHelper.ExecuteNonQuery(sql2, parameters);
            }
        }
        public void RebuildSalarySheetItem(SalarySheet ss)
        {
            string sqlDelete = "DELETE FROM SalarySheetItem WHERE SheetId = @SheetId";
            SqlParameter parameterDelete = new SqlParameter("@SheetId", ss.Id);
            SqlHelper.ExecuteNonQuery(sqlDelete, parameterDelete);
            BuildSalarySheetItem(ss);
        }
        public void SaveItem(SalarySheetItem item)
        {
            string sql = "UPDATE SalarySheetItem SET BaseSalary = @BaseSalary, Bonus = @Bonus, Fine = @Fine, Other = @Other WHERE Id = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@BaseSalary",item.BaseSalary),
                new SqlParameter("@Bonus",item.Bonus),
                new SqlParameter("@Fine",item.Fine),
                new SqlParameter("@Other",item.Other),
                new SqlParameter("@Id",item.Id)
            };
            SqlHelper.ExecuteNonQuery(sql, parameters);
        }
        public DataTable GetReportSheet(Guid sheetId)
        {
            string sql = "SELECT SalarySheet.Year AS Year, SalarySheet.Month AS Month, Department.Name AS Dept, Employee.Name AS Name, BaseSalary AS BaseSalary, Bonus AS Bonus, Fine AS Fine, Other AS Other FROM SalarySheetItem, Employee, SalarySheet, Department WHERE SheetId = @SheetId AND SalarySheetItem.EmployeeId = Employee.Id AND SalarySheetItem.SheetId = SalarySheet.Id AND SalarySheet.DepartmentId = Department.Id";
            SqlParameter para = new SqlParameter("@SheetId", sheetId);
            return SqlHelper.GetDataTable(sql, para);
        }
    }
}
