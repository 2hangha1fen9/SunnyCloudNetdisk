using MySql.Data.MySqlClient;
using System;
using System.Data;
using WebDisk_Client.Properties;

namespace WebDisk_Client.DAL
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
        //数据库连接
        private static MySqlConnection con;

        /// <summary>
        /// 初始化连接
        /// </summary>
        private static void InitConnection()
        {
            try
            {
                if (con == null)
                {
                    con = new MySqlConnection(conStr);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (con.State == ConnectionState.Broken)
                {
                    con.Close();
                    con.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 执行DML语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            try
            {
                InitConnection();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
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
                InitConnection();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            catch (Exception)
            {
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
                InitConnection();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception)
            {

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
                InitConnection();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con))
                {
                    adapter.Fill(set, tableName);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
