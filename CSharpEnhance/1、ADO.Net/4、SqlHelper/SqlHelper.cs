using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_SqlHelper
{
    public static class SqlHelper
    {
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["mssqlserver"]
            .ConnectionString;

        /// <summary>
        /// 封装查询数据的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    if (pms != null)
                    {
                        command.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 查询单个对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (pms != null)
                    {
                        command.Parameters.AddRange(pms);
                    }
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 返回reader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] pms)
        {
            SqlConnection connection = new SqlConnection(conStr);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (pms != null)
                {
                    command.Parameters.AddRange(pms);
                }
                try
                {
                    connection.Open();
                    //添加这个参数时，表示当reader对象被关闭时，关联的connection对象也会被关闭
                    return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch
                {
                    connection.Close();
                    connection.Dispose();
                    throw;
                }
            }

        }

    }
}
