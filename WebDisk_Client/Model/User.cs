using System.Net;

namespace WebDisk_Client.Model
{
    public class User
    {
        public string UserName { get; set; }    //用户名
        public int Status { get; set; }         //用户状态     
        public string Password { get; set; }   //用户密码
        public string Mail { get; set; }        //用户邮箱
        public string Dir { get; set; }         //用户目录
        public int ULBandwidth { get; set; }    //上行带宽
        public int DLBandwidth { get; set; }    //下行带宽
        public double QuotaSize { get; set; }      //最大容量
        public int QuotaFiles { get; set; }     //最大文件
        public NetworkCredential Credential { get; set; } //网络凭证
    }
}
