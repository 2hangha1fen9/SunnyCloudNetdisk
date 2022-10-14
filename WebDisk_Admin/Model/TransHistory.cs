using System.Collections.Generic;
using System.Xml.Serialization;
using WebDisk_Admin.Utils;

namespace WebDisk_Admin.Model
{
    /// <summary>
    /// 传输历史,记录传输任务,配合对象持久化,完成断点续传功能
    /// </summary>
    [XmlRoot("TransHistory")]
    public class TransHistory
    {
        [XmlElement(ElementName = "TransTask")]
        public List<TransTask> transTasks = new List<TransTask>();
    }
}
