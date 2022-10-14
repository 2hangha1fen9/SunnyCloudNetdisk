using System;
using System.IO;
using System.Xml.Serialization;
using WebDisk_Admin.Utils;

namespace WebDisk_Admin.Model
{
    /// <summary>
    /// 用于封装远程访问的文件,所包含的信息
    /// </summary>
    [Serializable]
    public class FileDescribe
    {
        [XmlElement(ElementName = "Type")]
        public FileType Type { get; set; }//文件类型

        [XmlElement(ElementName = "Size")]
        public long Size { get; set; } //文件大小

        [XmlElement(ElementName = "Time")]
        public string Time { get; set; }//修改时间

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }//文件名

        [XmlElement(ElementName = "CurrentPath")]
        public string CurrentPath { get; set; }//当前文件所在路径

        public FileDescribe() { }
        public FileDescribe(FileInfo info)
        {
            this.Type = FileHelper.GetFileType(info);
            this.Size = info.Length;
            this.Time = info.LastWriteTime.ToShortTimeString();
            this.Name = info.Name;
        }
        public FileDescribe(DirectoryInfo info)
        {
            this.Type = FileHelper.GetFileType(info);
            this.Size = this.Type == FileType.Folder ? 0 : new FileInfo(info.FullName).Length;
            this.Time = info.LastWriteTime.ToShortDateString();
            this.Name = info.Name;
        }
        public FileDescribe(FileType type, long size, string time, string name)
        {
            this.Type = type;
            this.Size = size;
            this.Time = time;
            this.Name = name;

            if (this.Type == FileType.Folder)
            {
                this.Size = 0;
            }
        }
        public FileDescribe(FileType type, long size, string time, string name, string currentPath) : this(type, size, time, name)
        {
            this.CurrentPath = currentPath + name;
        }
        public FileDescribe(string[] detail, string name)
        {
            this.Type = FileHelper.GetFileType(detail, name);
            this.Size = long.Parse(detail[4]);
            this.Time = detail[5] + " " + detail[6] + "th " + detail[7];
            this.Name = name;

            if (this.Type == FileType.Folder)
            {
                this.Size = 0;
            }
        }
        public FileDescribe(string[] detail, string name, string currentPath) : this(detail, name)
        {
            this.CurrentPath = currentPath + name;
        }

        /// <summary>
        /// 获取该对象的描述信息
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"文件类型:{FileHelper.GetTypeStr(Type)}\n" +
                    $"文件大小:{FileHelper.UnitConversion(Size)}\n" +
                    $"修改时间:{Time}\n" +
                    $"文件名:{Name}\n" +
                    $"路径:{CurrentPath}";
        }
    }
}
