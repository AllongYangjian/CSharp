using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Asp.net复习
{
    static class SqlHelper
    {
        private static String connStr = ConfigurationManager.ConnectionStrings["sqlserver_name"].ConnectionString;

        public static int ExecuteNoQuery(string sql, CommandType type, params SqlParameter[] psm)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = type;
                    if (psm != null)
                    {
                        command.Parameters.AddRange(psm);
                    }
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static object ExecutorScalar(string sql,CommandType type,params SqlParameter[] pms)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = type;
                    if(pms!=null)
                    {
                        command.Parameters.AddRange(pms);
                    }
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuterDataReader(string sql, CommandType type, params SqlParameter[] psm)
        {
            SqlConnection connection = new SqlConnection(connStr);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = type;
                if (psm != null)
                {
                    command.Parameters.AddRange(psm);
                }
                connection.Open();
                try
                {
                   return command.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception)
                {
                    connection.Close();
                    connection.Dispose();
                    throw;
                }

            }
        }

        public static DataTable ExecuteDataTable(string sql,CommandType type,params SqlParameter[] pms)
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
