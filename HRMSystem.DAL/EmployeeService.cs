using HRMSystem.Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class EmployeeService
    {
        public DataTable GetEmployeeList()
        {
            string sql = "SELECT Id AS 编号, Number AS 工号, Name AS 姓名, InDay AS 入职时间, Nation AS 民族, NativePlace AS 籍贯 FROM Employee";
            return SqlHelper.GetDataTable(sql);
        }
        public DataTable GetEmployeeList(EmployeeSearchWhere esw)
        {
            string sql = "SELECT Id AS 编号, Number AS 工号, Name AS 姓名, InDay AS 入职时间, Nation AS 民族, NativePlace AS 籍贯 FROM Employee";
            List<SqlParameter> whereParams = new List<SqlParameter>();
            string whereStr = null;
            List<string> whereList = new List<string>();
            if (!string.IsNullOrEmpty(esw.Name))
            {
                whereList.Add(string.Format("Name like '%' + @Name + '%'"));
                whereParams.Add(new SqlParameter("@Name", esw.Name));
            }
            if (esw.ExistDate)
            {
                whereList.Add("InDay >= @DateFrom AND InDay <= @DateTo");
                whereParams.Add(new SqlParameter("@DateFrom", esw.InDayFrom));
                whereParams.Add(new SqlParameter("@DateTo", esw.InDayTo));
            }
            if (esw.DeptId != Guid.Empty)
            {
                whereList.Add("DepartmentId = @DepartmentId");
                whereParams.Add(new SqlParameter("@DepartmentId", esw.DeptId));
            }
            whereStr = string.Join(" AND ", whereList);
            if(whereStr!=null && whereStr.Length > 0)
            {
                sql += " WHERE " + whereStr;
            }
            return SqlHelper.GetDataTable(sql,whereParams.ToArray());
        }
        public Employee GetEmployeeById(Guid id)
        {
            Employee emp = new Employee();
            string sql = "SELECT Id,Number,Name,BirthDay,InDay,MarriageId,PartyId,EducationId,GenderId,DepartmentId,Telephone,Address,Email,Remarks,Resume,Photo,Nation,NativePlace FROM Employee WHERE Id = @Id";
            SqlParameter paramId = new SqlParameter("@Id", id);
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, paramId);
            if (dr.Read())
            {
                emp.Id = dr.GetGuid(0);
                emp.Number = dr.GetString(1);
                emp.Name = dr.GetString(2);
                emp.BirthDay = dr.GetDateTime(3);
                emp.InDay = dr.GetDateTime(4);
                emp.MarriageId = dr.GetGuid(5);
                emp.PartyId = dr.GetGuid(6);
                emp.EducationId = dr.GetGuid(7);
                emp.GenderId = dr.GetGuid(8);
                emp.DepartmentId = dr.GetGuid(9);
                emp.Telephone = dr.GetString(10);
                emp.Address = dr.GetString(11);
                emp.Email = dr.GetString(12);
                emp.Remarks = dr.GetString(13);
                emp.Resume = dr.GetString(14);
                if (dr["Photo"] != DBNull.Value)
                {
                    emp.Photo = (byte[])dr["Photo"];
                }
                else
                {
                    emp.Photo = null;
                }
                emp.Nation = dr.GetString(16);
                emp.NativePlace = dr.GetString(17);
            }
            dr.Close();
            return emp;
        }
        public bool AddEmployee(Employee emp)
        {
            string sql = "INSERT INTO Employee (Id,Number,Name,BirthDay,InDay,MarriageId,PartyId,EducationId,GenderId,DepartmentId,Telephone,Address,Email,Remarks,Resume,Photo,Nation,NativePlace) VALUES (@Id,@Number,@Name,@BirthDay,@InDay,@MarriageId,@PartyId,@EducationId,@GenderId,@DepartmentId,@Telephone,@Address,@Email,@Remarks,@Resume,@Photo,@Nation,@NativePlace)";
            SqlParameter paramPhoto = new SqlParameter("@Photo", SqlDbType.Image);
            if (emp.Photo == null)
            {
                paramPhoto.Value = DBNull.Value;
            }
            else
            {
                paramPhoto.Value = emp.Photo;
            }
            SqlParameter[] parameters = {
                new SqlParameter("@Id", emp.Id),
                new SqlParameter("@Number", emp.Number),
                new SqlParameter("@Name", emp.Name),
                new SqlParameter("@BirthDay", emp.BirthDay),
                new SqlParameter("@InDay", emp.InDay),
                new SqlParameter("@MarriageId", emp.MarriageId),
                new SqlParameter("@PartyId", emp.PartyId),
                new SqlParameter("@EducationId", emp.EducationId),
                new SqlParameter("@GenderId",emp.GenderId),
                new SqlParameter("@DepartmentId",emp.DepartmentId),
                new SqlParameter("@Telephone",emp.Telephone),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@Email",emp.Email),
                new SqlParameter("@Remarks",emp.Remarks),
                new SqlParameter("@Resume",emp.Resume),
                new SqlParameter("@Nation",emp.Nation),
                new SqlParameter("@NativePlace",emp.NativePlace),
                paramPhoto
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool EditEmployee(Employee emp)
        {
            string sql = "UPDATE Employee SET Number = @Number, Name = @Name, BirthDay = @BirthDay, InDay = @Inday, MarriageId = @MarriageId, PartyId = @PartyId, EducationId = @EducationId, GenderId = @GenderId, DepartmentId = @DepartmentId, Telephone = @Telephone, Address = @Address, Email = @Email,Remarks = @Remarks, Resume = @Resume, Photo = @Photo, Nation = @Nation, NativePlace = @NativePlace Where Id = @Id";
            SqlParameter paramPhoto = new SqlParameter("@Photo", SqlDbType.Image);
            if (emp.Photo == null)
            {
                paramPhoto.Value = DBNull.Value;
            }
            else
            {
                paramPhoto.Value = emp.Photo;
            }
            SqlParameter[] parameters = {
                new SqlParameter("@Id", emp.Id),
                new SqlParameter("@Number", emp.Number),
                new SqlParameter("@Name", emp.Name),
                new SqlParameter("@BirthDay", emp.BirthDay),
                new SqlParameter("@InDay", emp.InDay),
                new SqlParameter("@MarriageId", emp.MarriageId),
                new SqlParameter("@PartyId", emp.PartyId),
                new SqlParameter("@EducationId", emp.EducationId),
                new SqlParameter("@GenderId",emp.GenderId),
                new SqlParameter("@DepartmentId",emp.DepartmentId),
                new SqlParameter("@Telephone",emp.Telephone),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@Email",emp.Email),
                new SqlParameter("@Remarks",emp.Remarks),
                new SqlParameter("@Resume",emp.Resume),
                new SqlParameter("@Nation",emp.Nation),
                new SqlParameter("@NativePlace",emp.NativePlace),
                paramPhoto
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool DeleteEmployee(Guid id)
        {
            string sql = "Delete FROM Employee Where Id = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", id)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool ExportToExcel(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return false;
            }
            string sql = "SELECT Number AS 工号, Name AS 姓名, InDay AS 入职时间, Nation AS 民族, NativePlace AS 籍贯 FROM Employee";
            DataTable dt = SqlHelper.GetDataTable(sql);
            IWorkbook wb = new HSSFWorkbook();
            ISheet sh = wb.CreateSheet("员工数据");
            sh.SetColumnWidth(2, 15 * 256);
            int rowCount = dt.Rows.Count;
            int colCount = dt.Columns.Count;
            IRow headerRow = sh.CreateRow(0);
            IFont headerFont = wb.CreateFont();
            ICellStyle headerStyle = wb.CreateCellStyle();
            headerFont.FontName = "宋体";
            headerFont.Boldweight = (short)FontBoldWeight.BOLD;
            headerStyle.SetFont(headerFont);
            headerStyle.Alignment = HorizontalAlignment.CENTER;
            for(int i = 0; i < colCount; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                cell.CellStyle = headerStyle;
                cell.SetCellValue(dt.Columns[i].ColumnName);
            }
            for(int i = 1; i <= rowCount; i++)
            {
                IRow row = sh.CreateRow(i);
                for(int j = 0; j < colCount; j++)
                {
                    ICell cell = row.CreateCell(j);
                    if (j == 2)
                    {
                        cell.SetCellValue((DateTime)dt.Rows[i - 1][j]);
                        ICellStyle cellStyle = wb.CreateCellStyle();
                        cellStyle.DataFormat = wb.CreateDataFormat().GetFormat("yyyy年mm月d日");
                        cell.CellStyle = cellStyle;
                    }
                    else
                    {
                        cell.SetCellValue(dt.Rows[i - 1][j].ToString());
                    }
                }
            }
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    wb.Write(fs);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool IsEmployeeExist(Guid deptId)
        {
            string sql = "SELECT COUNT(*) FROM Employee WHERE DepartmentId = @DeptId";
            SqlParameter[] parameters = {
                new SqlParameter("@DeptId", deptId)
            };
            return (int)SqlHelper.ExecuteScalar(sql, parameters) > 0;
        }
    }
}
