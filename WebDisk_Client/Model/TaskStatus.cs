namespace WebDisk_Client.Model
{
    /// <summary>
    /// 传输任务状态枚举
    /// </summary>
    public enum TaskStatus
    {
        Start,              //开始
        Stop,               //暂停
        Interrupt,          //中断
        Error,              //错误
        Completed           //完成
    }
}
