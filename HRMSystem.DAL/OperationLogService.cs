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
    public class OperationLogService
    {
        public bool Add(OperationLog log)
        {
            string sql = "INSERT INTO OperationLog VALUES(@Id,@OperatorId,@ActionDate,@ActionDesc)";
            SqlParameter[] parameters = {
                new SqlParameter("@Id",log.Id),
                new SqlParameter("@OperatorId",log.OperatorId),
                new SqlParameter("@ActionDate",log.ActionDate),
                new SqlParameter("@ActionDesc",log.ActionDesc)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public DataTable GetOperationLogList(int pageNo, int numPerPage)
        {
            string sql = "SELECT Temp.Id AS 编号, Operator.RealName AS 操作员, Temp.ActionDate AS 操作时间, Temp.ActionDesc AS 描述 FROM (SELECT TOP(@LogNum) * FROM OperationLog WHERE Id NOT IN(SELECT TOP(@BeforeNum) Id FROM OperationLog)) AS Temp, Operator WHERE Temp.OperatorId = Operator.Id";
            SqlParameter[] parameters = {
                new SqlParameter("@LogNum", numPerPage),
                new SqlParameter("@BeforeNum", (pageNo - 1) * numPerPage)
            };
            return SqlHelper.GetDataTable(sql, parameters);
        }
        public DataTable GetOperationLogList(LogSearchWhere lsw, int pageNo,int numPerPage)
        {
            string sql = "SELECT lg.Id AS 编号, op.RealName AS 操作员, lg.ActionDate AS 操作时间, lg.ActionDesc AS 描述 FROM OperationLog AS lg, Operator AS op WHERE lg.OperatorId = op.Id";
            List<SqlParameter> whereParams = new List<SqlParameter>();
            string whereStr = null;
            List<string> whereList = new List<string>();
            if (!string.IsNullOrEmpty(lsw.RealName))
            {
                whereList.Add(string.Format("RealName like '%' + @RealName + '%'"));
                whereParams.Add(new SqlParameter("@RealName", lsw.RealName));
            }
            if (lsw.ExistDate)
            {
                whereList.Add("ActionDate >= @DateFrom AND ActionDate <= @DateTo");
                whereParams.Add(new SqlParameter("@DateFrom", lsw.ActionDateFrom));
                whereParams.Add(new SqlParameter("@DateTo", lsw.ActionDateTo));
            }
            if (!string.IsNullOrEmpty(lsw.ActionDesc))
            {
                whereList.Add(string.Format("ActionDesc like '%' + @ActionDesc + '%'"));
                whereParams.Add(new SqlParameter("@ActionDesc", lsw.ActionDesc));
            }
            whereStr = string.Join(" AND ", whereList);
            if (whereStr != null && whereStr.Length > 0)
            {
                sql += " AND " + whereStr;
            }
            sql += " ORDER BY 编号 OFFSET @BeforeNum ROWS FETCH NEXT @LogNum ROWS ONLY";
            SqlParameter[] parameters = {
                new SqlParameter("@LogNum", numPerPage),
                new SqlParameter("@BeforeNum", (pageNo - 1) * numPerPage)
            };
            whereParams.AddRange(parameters);
            return SqlHelper.GetDataTable(sql, whereParams.ToArray());
        }
        public int GetLogCount()
        {
            string sql = "SELECT COUNT(*) FROM OperationLog";
            return (int)SqlHelper.ExecuteScalar(sql);
        }
        public int GetLogCount(LogSearchWhere lsw)
        {
            string sql = "SELECT COUNT(*) FROM (SELECT lg.Id AS 编号, op.RealName AS 操作员, lg.ActionDate AS 操作时间, lg.ActionDesc AS 描述 FROM OperationLog AS lg, Operator AS op WHERE lg.OperatorId = op.Id";
            List<SqlParameter> whereParams = new List<SqlParameter>();
            string whereStr = null;
            List<string> whereList = new List<string>();
            if (!string.IsNullOrEmpty(lsw.RealName))
            {
                whereList.Add(string.Format("RealName like '%' + @RealName + '%'"));
                whereParams.Add(new SqlParameter("@RealName", lsw.RealName));
            }
            if (lsw.ExistDate)
            {
                whereList.Add("ActionDate >= @DateFrom AND ActionDate <= @DateTo");
                whereParams.Add(new SqlParameter("@DateFrom", lsw.ActionDateFrom));
                whereParams.Add(new SqlParameter("@DateTo", lsw.ActionDateTo));
            }
            if (!string.IsNullOrEmpty(lsw.ActionDesc))
            {
                whereList.Add(string.Format("ActionDesc like '%' + @ActionDesc + '%'"));
                whereParams.Add(new SqlParameter("@ActionDesc", lsw.ActionDesc));
            }
            whereStr = string.Join(" AND ", whereList);
            if (whereStr != null && whereStr.Length > 0)
            {
                sql += " AND " + whereStr + ") AS subquery";
            }
            else
            {
                sql += ") AS subquery";
            }
            return (int)SqlHelper.ExecuteScalar(sql, whereParams.ToArray());
        }
        public bool LogMigrate(DateTime datetime)
        {
            string sql0 = "select count(*) from information_schema.TABLES where TABLE_NAME = 'OperationLogBackup'";
            if ((int)SqlHelper.ExecuteScalar(sql0) == 0)
            {
                string sqlCreatTable = "SELECT * INTO OperationLogBackup FROM OperationLog WHERE 1 = 2";
                SqlHelper.ExecuteNonQuery(sqlCreatTable);
            }
            string sql1 = "INSERT INTO OperationLogBackup SELECT * FROM OperationLog WHERE [ActionDate] < @selectedDate";
            string sql2 = "DELETE FROM OperationLog WHERE [ActionDate] < @selectedDate";
            SqlParameter parameters = new SqlParameter("@selectedDate", datetime);
            return SqlHelper.Execute(sql1, sql2, parameters);
        }
    }
}
