using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ConnectDatabases
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectDatabases();
        }

        static void ConnectDatabases()
        {
            // 数据库路径，数据库名称 ，集成方式
            string connectStr = "Data Source = DESKTOP-VBO5GUV;Initial Catalog=adoTest1;integrated Security=true";

            using (SqlConnection conn = new SqlConnection(connectStr))
            {

                conn.Open();
                Save(conn);
                //Delete(conn);
                //Update(conn);
                //Query(conn);
                QueryAll(conn);

                Console.WriteLine("Open Connection Success");

            }
            Console.WriteLine("关闭连接，释放资源");
            Console.ReadKey();
        }
         /// <summary>
         /// 测试插入方法
         /// ExecuteNonQuery() 这个方法有一个返回值，表示执行insert、delete、update语句后，所影响的行数， 
         /// 执行其他语句永远返回-1
       
         /// </summary>
         /// <param name="connection"></param>
        static void Save(SqlConnection connection)
        {
            string sql = "insert into TblStudent values('yj')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                int ret = command.ExecuteNonQuery();
                Console.WriteLine("受影响的行数：{0}", ret);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        static void Update(SqlConnection connection)
        {
            string sql = "update TblStudent set username = 'lwh' where autoId = 2";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                int ret = command.ExecuteNonQuery();
                Console.WriteLine("受影响的行数：{0}", ret);
            }
        }
        
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="connection"></param>
        static void Query(SqlConnection connection)
        {
            string sql = "select count(*) from TblStudent";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                object obj = command.ExecuteScalar();
                if(obj!=null)
                {
                    Console.WriteLine(obj);
                }
            }
        }

        static void Delete(SqlConnection connection)
        {
            string sql = "delete from TblStudent where username = 'yj'";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                int ret = command.ExecuteNonQuery();
                Console.WriteLine("受影响的行数：{0}", ret);
            }
        }

        static void QueryAll(SqlConnection connection)
        {
            string sql = "select * from TblStudent";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    //每次查询前需要进行read来获取行数据
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        
                        Console.WriteLine("id = {0},username = {1}", id, name);
                    }
                }
            
                reader.Dispose();
            }
        }
    }
}
