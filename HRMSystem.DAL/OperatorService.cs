using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class OperatorService
    {
        public Operator GetOperator(string un)
        {
            Operator op = null;
            string sql = "SELECT * FROM Operator WHERE UserName = @UserName";
            SqlParameter paraUserName = new SqlParameter("@UserName", un);
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, paraUserName);
            if (dr.Read())
            {
                op = new Operator();
                op.Id = (Guid)dr["Id"];
                op.UserName = dr["UserName"].ToString();
                op.Password = dr["Password"].ToString();
                op.RealName = dr["RealName"].ToString();
                op.IsDeleted = (bool)dr["IsDeleted"];
                op.IsAdmin = (bool)dr["IsAdmin"];
                op.IsLocked = (bool)dr["IsLocked"];
            }
            dr.Close();
            return op;
        }
        public DataTable GetOperatorList()
        {
            string sql = "SELECT Id AS 编号, RealName AS 真实姓名, UserName AS 用户名, IsDeleted AS 是否已删除, IsLocked AS 是否已锁定, IsAdmin AS 是否为管理员 FROM Operator WHERE IsDeleted = 0";
            return SqlHelper.GetDataTable(sql);
        }
        public DataTable GetOperatorList(OperatorSearchWhere osw)
        {
            string sql = "SELECT Id AS 编号, RealName AS 真实姓名, UserName AS 用户名, IsDeleted AS 是否已删除, IsLocked AS 是否已锁定, IsAdmin AS 是否为管理员 FROM Operator WHERE IsDeleted = 0";
            List<SqlParameter> whereParams = new List<SqlParameter>();
            string whereStr = null;
            List<string> whereList = new List<string>();
            if (!string.IsNullOrEmpty(osw.UserName))
            {
                whereList.Add(string.Format("UserName like '%' + @UserName + '%'"));
                whereParams.Add(new SqlParameter("@UserName", osw.UserName));
            }
            if (!string.IsNullOrEmpty(osw.RealName))
            {
                whereList.Add(string.Format("RealName like '%' + @RealName + '%'"));
                whereParams.Add(new SqlParameter("@RealName", osw.RealName));
            }
            whereStr = string.Join(" AND ", whereList);
            if (whereStr != null && whereStr.Length > 0)
            {
                sql += " AND " + whereStr;
            }
            return SqlHelper.GetDataTable(sql, whereParams.ToArray());
        }
        public Operator GetOperatorById(Guid id)
        {
            Operator op = null;
            string sql = "SELECT Id, UserName, Password,RealName, IsAdmin, IsLocked, IsDeleted FROM Operator WHERE Id = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id",id),
            };
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, parameters);
            if (dr.Read())
            {
                op.UserName = dr.GetString(1);
                op.Password = dr.GetString(2);
                op.RealName = dr.GetString(3);
                op.IsAdmin = dr.GetBoolean(4);
                op.IsLocked = dr.GetBoolean(5);
                op.IsDeleted = dr.GetBoolean(6);
            }
            dr.Close();
            return op;
        }
        public bool AddOperator(Operator op)
        {
            string sql = "INSERT INTO Operator (Id, UserName, Password, RealName,IsAdmin, IsLocked, IsDeleted) VALUES (@id, @username, @password,@realname, 0, 0, 0)";
            SqlParameter[] parameters = {
                new SqlParameter("@id", op.Id),
                new SqlParameter("@username", op.UserName),
                new SqlParameter("@realname", op.RealName),
                new SqlParameter("@password", op.Password),
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public void DeleteOperator(Guid id)
        {
            string sql = "UPDATE Operator SET IsDeleted = 1 WHERE Id = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id",id),
            };
            SqlHelper.ExecuteNonQuery(sql,parameters);
        }
        public void LockOperator(Guid id)
        {
            string sql = "UPDATE Operator SET IsLocked = 1 WHERE Id = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id",id),
            };
            SqlHelper.ExecuteNonQuery(sql, parameters);
        }
        public void PwdModify(string un, string pwdAfter)
        {
            string sql = "UPDATE Operator SET Password = @PasswordAfter WHERE UserName = @UserName";
            SqlParameter[] parameters = {
                new SqlParameter("@PasswordAfter", pwdAfter),
                new SqlParameter("@UserName", un)
            };
            SqlHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
