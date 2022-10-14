
namespace WebDisk_Client.Model
{
    /// <summary>
    /// 远程文件类型枚举
    /// </summary>
    public enum FileType
    {
        Folder = 0, //文件夹
        Txt = 1,    //纯文本
        Img = 2,    //图片
        Music = 3,  //音乐
        Video = 4,  //视频
        Doc = 5,    //word文档
        Ppt = 6,    //ppt幻灯片
        Xls = 7,    //excel电子表格
        Pdf = 8,    //pdf文档
        Rar = 9,    //压缩包
        Exe = 10,   //可执行文件
        Other = 11  //其他
    }
}
