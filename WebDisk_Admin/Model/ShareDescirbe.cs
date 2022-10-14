using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDisk_Admin.Model
{
    public class ShareDescirbe
    {
        public string UserName { get; set; }        //分享者
        public FileDescribe FileDescribe { get; set; } //文件分享信息
        public string AbsPath { get; set; } //文件绝对路径
        public DateTime StartTime { get; set; } //分享开始时间
        public DateTime EndTime { get; set; }   //分享结束时间
        public string Code { get; set; }    //分享码
        public int MaxVisit { get; set; } //最大访问人数
        public int Visited { get; set; }  //访问人数
    }
}
