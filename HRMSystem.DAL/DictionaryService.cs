using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class DictionaryService
    {
        public DataTable GetComboList(string category)
        {
            string sql = "SELECT * FROM Dictionary WHERE Category = @Category";
            SqlParameter param = new SqlParameter("@Category", category);
            return SqlHelper.GetDataTable(sql, param);
        }
    }
}
