using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebDisk_Client.DAL;
using WebDisk_Client.Model;
using WebDisk_Client.Properties;

namespace WebDisk_Client.BLL
{
    /// <summary>
    /// 分享操作类
    /// </summary>
    public class ShareManager
    {
        //数据库操作对象
        ShareDao dao = new ShareDao();

        /// <summary>
        /// 获取该用户的分享信息
        /// </summary>
        /// <param name="set">待填充的数据集</param>
        /// <param name="user">用户</param>
        public void GetShareInfo(DataSet set, User user)
        {
            try
            {
                if (set.Tables["Share"] != null)
                {
                    set.Tables["Share"].Clear();
                }
                dao.Query(set, "Share", user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取分享信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ShareDescirbe GetShareInfo(string code)
        {
            try
            {
                return dao.Query(code);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取有效的分享信息
        /// </summary>
        /// <param name="code">分享码</param>
        /// <returns></returns>
        public ShareDescirbe GetShareInfoEffective(string code)
        {
            try
            {
                return dao.Query(code, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 查询分享
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="fileName">文件名</param>
        /// <returns></returns>
        public ShareDescirbe GetShareInfo(string userName, string fileName)
        {
            try
            {
                return dao.Query(userName, fileName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 添加分享信息
        /// </summary>
        /// <param name="describe">文件描述</param>
        /// <param name="user">用户</param>
        /// <param name="endTime">结束时间</param>
        /// <param name="MaxVisit">最大访问人数</param>
        /// <returns></returns>
        public bool AddShareInfo(FileDescribe describe, User user, object endTime, int MaxVisit)
        {
            try
            {
                ShareDescirbe share = new ShareDescirbe();
                share.UserName = user.UserName;
                share.FileDescribe = describe;
                share.AbsPath = $"{Settings.Default.absRootPath}/{user.UserName}/{describe.CurrentPath}";
                share.EndTime = (DateTime)endTime;
                share.Code = GetShareCode();
                share.MaxVisit = MaxVisit;

                return dao.Insert(share) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        /// <summary>
        /// 删除分享信息
        /// </summary>
        /// <param name="code">分享码</param>
        /// <returns></returns>
        public bool DeleteShareInfo(string code)
        {
            try
            {
                return dao.Delete(code) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 更新分享信息
        /// </summary>
        /// <param name="share"></param>
        /// <returns></returns>
        public bool UpdateShareInfo(ShareDescirbe share)
        {
            try
            {
                return dao.Update(share) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取分享文件
        /// </summary>
        /// <param name="share">分享描述</param>
        /// <param name="user">用户</param>
        /// <param name="targetPath">目标路径</param>
        /// <returns></returns>
        public bool GetShareFile(ShareDescirbe share, User user, string targetPath)
        {
            try
            {
                return dao.GetFile(share, $"{Settings.Default.absRootPath}/{user.UserName}/{targetPath}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取所有分享码
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllCode()
        {
            try
            {
                return dao.QueryColumn("Code");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 生成分享码
        /// </summary>
        /// <returns></returns>
        public string GetShareCode()
        {
            try
            {
                List<string> codes = GetAllCode();
                if(codes == null)
                {
                    throw new Exception("未知错误");
                }
                string code;
                while (!codes.Contains(code = CreateRandomCode()))
                {
                    break;
                }
                return code;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 生成随机码4~8位
        /// </summary>
        /// <returns></returns>
        private string CreateRandomCode()
        {
            Random random = new Random();
            string src = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            StringBuilder code = new StringBuilder();
            int MaxLength = random.Next(4, 9);
            for (int i = 0; i < MaxLength; i++)
            {
                code.Append(src.Substring(random.Next(0, src.Length), 1));
            }
            return code.ToString();
        }

    }
}
