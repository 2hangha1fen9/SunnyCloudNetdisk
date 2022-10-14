using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDisk_Admin.DAL;
using WebDisk_Admin.Model;
using WebDisk_Admin.Properties;

namespace WebDisk_Admin.BLL
{
    public class ShareManager
    {
        //数据库操作对象
        ShareDao dao = new ShareDao();
        /// <summary>
        /// 获取分享信息
        /// </summary>
        /// <param name="set"></param>
        public void GetShareInfo(DataSet set)
        {
            try
            {
                if (set.Tables["Share"] != null)
                {
                    set.Tables["Share"].Clear();
                }
                dao.Query(set, "Share");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取分享码
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
        /// 更新分享
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
    }
}
