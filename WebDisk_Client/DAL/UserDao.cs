using MySql.Data.MySqlClient;
using System;
using System.Data;
using WebDisk_Client.Model;

namespace WebDisk_Client.DAL
{
    /// <summary>
    /// 数据库访问层
    /// </summary>
    class UserDao
    {
        /// <summary>
        /// 查询记录
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="passwod">密码</param>
        /// <returns></returns>
        public User Query(string account, string passwod)
        {
            try
            {
                //sql语句
                string sql = $"select * from ftpd where ((User = '{account}' and Password = '{passwod}') or (Mail = '{account}' and Password = '{passwod}')) and status = '1'";
                //执行sql语句并封装对象,返回
                User user = null;
                using (MySqlDataReader reader = DBHelper.Query(sql))
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        user = new User();
                        user.UserName = reader.GetString("User");
                        user.Status = reader.GetInt32("Status");
                        user.Password = reader.GetString("Password");
                        user.Mail = reader.GetString("Mail");
                        user.ULBandwidth = reader.GetInt32("ULBandwidth");
                        user.DLBandwidth = reader.GetInt32("DLBandwidth");
                        user.QuotaSize = reader.GetInt32("QuotaSize");
                        user.QuotaFiles = reader.GetInt32("QuotaFiles");
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return null;
            }
        }

        /// <summary>
        /// 查询记录
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="passwod">密码</param>
        /// <returns></returns>
        public User Query(string account)
        {
            try
            {
                //sql语句
                string sql = $"select * from ftpd where User = '{account}' or Mail = '{account}'";
                //执行sql语句并封装对象,返回
                User user = null;
                using (MySqlDataReader reader = DBHelper.Query(sql))
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        user = new User();
                        user.UserName = reader.GetString("User");
                        user.Status = reader.GetInt32("Status");
                        user.Password = reader.GetString("Password");
                        user.Mail = reader.GetString("Mail");
                        user.ULBandwidth = reader.GetInt32("ULBandwidth");
                        user.DLBandwidth = reader.GetInt32("DLBandwidth");
                        user.QuotaSize = reader.GetInt32("QuotaSize");
                        user.QuotaFiles = reader.GetInt32("QuotaFiles");
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return null;
            }
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <param name="set">结果集</param>
        /// <param name="tableName">表名</param>
        public void Query(DataSet set, string tableName)
        {
            try
            {
                string sql = "select * from ftpd";
                DBHelper.QueryForDataSet(set, tableName, sql);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
            }
        }

        public object QueryExist(string account)
        {
            try
            {
                //sql语句
                string sql = $"select * from ftpd where User = '{account}' or Mail = '{account}'";
                //执行sql语句并封装对象,返回
                return DBHelper.QueryForObject(sql);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return null;
            }
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Update(User user)
        {
            try
            {
                string sql = $"update ftpd set Status = '{user.Status}',Password = '{user.Password}',Mail = '{user.Mail}',ULBandwidth = {user.ULBandwidth},DLBandwidth = {user.DLBandwidth},QuotaSize = {user.QuotaSize},QuotaFiles = {user.QuotaFiles} where User = '{user.UserName}'";
                return DBHelper.Update(sql);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return 0;
            }
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns></returns>
        public int Insert(User user)
        {
            try
            {
                string sql = $"insert into ftpd (User,Password,Dir,Mail) values('{user.UserName}','{user.Password}','{user.Dir}','{user.Mail}')";
                return DBHelper.Update(sql);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return 0;
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Delete(string userName)
        {
            try
            {
                string sql = $"delete from ftpd where User = '{userName}'";
                return DBHelper.Update(sql);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    throw new Exception("网络错误,请检查网络");
                }
                return 0;
            }
        }
    }
}
