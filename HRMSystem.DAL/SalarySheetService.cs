using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class SalarySheetService
    {
        public bool IsSalarySheetExist(SalarySheet ss)
        {
            string sql = "SELECT COUNT(*) FROM SalarySheet WHERE Year = @Year AND Month = @Month AND DepartmentId = @DeptId";
            SqlParameter[] parameters = {
                new SqlParameter("@Year",ss.Year),
                new SqlParameter("@Month",ss.Month),
                new SqlParameter("@DeptId",ss.DepartmentId)
            };
            return (int)SqlHelper.ExecuteScalar(sql, parameters) > 0;
        }
        public Guid GetSalarySheetId(SalarySheet ss)
        {
            string sql = "SELECT * FROM SalarySheet WHERE Year = @Year AND Month = @Month AND DepartmentId = @DeptId";
            SqlParameter[] parameters ={
                new SqlParameter("@Year",ss.Year),
                new SqlParameter("@Month",ss.Month),
                new SqlParameter("@DeptId",ss.DepartmentId)
            };
            return (Guid)SqlHelper.ExecuteScalar(sql, parameters);
        }
        public void GenerateSalarySheet(SalarySheet ss)
        {
            string sql = "INSERT INTO SalarySheet VALUES(@Id, @Year, @Month, @DeptId)";
            SqlParameter[] parameters = {
                new SqlParameter("@Id",ss.Id),
                new SqlParameter("@Year",ss.Year),
                new SqlParameter("@Month",ss.Month),
                new SqlParameter("@DeptId",ss.DepartmentId)
            };
            SqlHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
