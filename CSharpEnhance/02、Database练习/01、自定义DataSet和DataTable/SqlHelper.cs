using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_自定义DataSet和DataTable
{
    public static class SqlHelper
    {
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["mssqlserver"].ConnectionString;

        public static CommandBehavior SqlCommandDataType { get; private set; }

        /// <summary>
        /// 获取sqlReader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] pms)
        {
            SqlConnection connection = new SqlConnection(connStr);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (pms != null)
                {
                    command.Parameters.AddRange(pms);
                }
                try
                {
                    connection.Open();
                    return command.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch
                {
                    connection.Close();
                    connection.Dispose();
                    throw;
                }

            }
        }

        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                if(pms!=null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
