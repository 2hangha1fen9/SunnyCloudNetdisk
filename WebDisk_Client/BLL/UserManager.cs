using System;
using System.Data;
using System.Net;
using WebDisk_Client.DAL;
using WebDisk_Client.Model;
using WebDisk_Client.Properties;

namespace WebDisk_Client.BLL
{
    class UserManager
    {
        // 数据库操作对象
        private UserDao dao = new UserDao();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user">登录者</param>
        /// <returns></returns>
        public User UserLogin(User user)
        {
            try
            {
                User u = dao.Query(user.UserName, user.Password);
                if (u == null)
                {
                    throw new Exception("账号或密码错误");
                }
                return u;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="account"></param>
        /// <returns>用户</returns>
        public User GetUser(string account)
        {
            try
            {
                User u = dao.Query(account);
                return u;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <param name="set">查询结果集</param>
        public void GetAllUsers(DataSet set)
        {
            try
            {
                if (set.Tables["Users"] != null)
                {
                    set.Tables["Users"].Clear();
                }
                dao.Query(set, "Users");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool UserIsExist(string account)
        {
            try
            {
                return dao.QueryExist(account) != null ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns></returns>
        public bool UpdateUser(User user)
        {
            try
            {
                user.Credential = new NetworkCredential(user.UserName, user.Password);
                return dao.Update(user) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns></returns>
        public bool AddUser(User user)
        {
            try
            {
                //设置用户的目录
                user.Dir = $"{Settings.Default.absRootPath}/{user.UserName}";
                return dao.Insert(user) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
