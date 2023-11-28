using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class DepartmentService
    {
        public DataTable GetDepartmentList()
        {
            string sql = "SELECT Id AS 部门编号, Name AS 部门名称 FROM Department";
            return SqlHelper.GetDataTable(sql);
        }
        public DataTable GetDepartmentList(string un)
        {
            string sql = "SELECT Id AS 部门编号, Name AS 部门名称 FROM Department WHERE Name LIKE @name";
            SqlParameter[] parameters = {
                new SqlParameter("@name", "%" + un + "%")
            };
            return SqlHelper.GetDataTable(sql, parameters);
        }
        public bool AddDepartment(Department dp)
        {
            string sql = "INSERT INTO Department(Id, Name) VALUES (@id, @name)";
            SqlParameter[] parameters = {
                new SqlParameter("@id", dp.Id),
                new SqlParameter("@name", dp.Name)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public void DeleteDepartment(Guid id)
        {
            string sql = "Delete FROM Department WHERE Id = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id", id)
            };
            SqlHelper.ExecuteNonQuery(sql, parameters);
        }
        public DataTable GetAllDepartments()
        {
            string sql = "SELECT * FROM Department";
            return SqlHelper.GetDataTable(sql);
        }
    }
}
