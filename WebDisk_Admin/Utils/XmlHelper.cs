using System;
using System.IO;
using System.Xml.Serialization;
using WebDisk_Admin.UI;

namespace WebDisk_Admin.Utils
{
    /// <summary>
    /// 这是一个对象持久化的工具,可以使对象以xml文档的方式保存在本地,并读取xml文档实例化对象
    /// </summary>
    static class XmlHelper
    {
        /// <summary>
        /// 将对象转换为xml文档
        /// </summary>
        /// <param name="obj">转换对象</param>
        public static void ObjectToXml(object obj,string userName)
        {
            //绑定对象
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            string content = string.Empty; //序列化后的内容
            using (StringWriter stringWriter = new StringWriter())
            {
                //序列化
                serializer.Serialize(stringWriter, obj);
                content = stringWriter.ToString();
            }

            using (StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + $"//History_{userName}.xml"))
            {
                streamWriter.Write(content);
            }
        }

        /// <summary>
        /// 将xml文档转换为对象
        /// </summary>
        /// <param name="type">类对象</param>
        public static object XmlToObject(Type type,string userName)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            using (StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + $"//History_{userName}.xml"))
            {
                //反序列化
                return serializer.Deserialize(streamReader);
            }

        }
    }
}
