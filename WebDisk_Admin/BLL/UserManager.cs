using System;
using System.Data;
using System.Text.RegularExpressions;
using WebDisk_Admin.DAL;
using WebDisk_Admin.Model;
using WebDisk_Admin.Properties;

namespace WebDisk_Admin.BLL
{
    class UserManager
    {
        /// <summary>
        /// 数据库操作对象
        /// </summary>
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
                if(u == null)
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
        /// <returns></returns>
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
                user.Dir = $"{Settings.Default.absRootPath}/{user.UserName}";
                return dao.Insert(user) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns></returns>
        public bool DeleteUser(string userName)
        {
            try
            {
                if (userName == "")
                {
                    throw new Exception("用户名不能为空");
                }
                return dao.Delete(userName) > 0;
            }
            catch (Exception)
            {
                throw;
            }          
        }
    }
}
