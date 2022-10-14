using MySql.Data.MySqlClient;
using System;
using System.Data;
using WebDisk_Admin.Properties;

namespace WebDisk_Admin.DAL
{
    /// <summary>
    /// 数据库工具类,可以执行sql语句
    /// </summary>
    static class DBHelper
    {
        //数据库连接字符串
        private static string conStr = $"server={Settings.Default.serverIp};" +
                                            $"database={Settings.Default.databaseName};" +
                                            $"uid={Settings.Default.databaseAccount};" +
                                            $"pwd={Settings.Default.databasePassword};" +
                                            $"SslMode=None ";


        /// <summary>
        /// 执行DML语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conStr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        return cmd.ExecuteNonQuery();
                    }
                }                        
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static MySqlDataReader Query(string sql)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conStr);
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql,con))
                {
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }                   
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 查询首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object QueryForObject(string sql)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conStr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 查询,并填充到DataSet中
        /// </summary>
        /// <param name="set"></param>
        /// <param name="tableName"></param>
        /// <param name="sql"></param>
        public static void QueryForDataSet(DataSet set, string tableName, string sql)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conStr))
                {
                    con.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con))
                    {
                        adapter.Fill(set, tableName);
                    }
                }              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
