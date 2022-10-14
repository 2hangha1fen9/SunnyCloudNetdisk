using CXuesong.Shims.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using WebDisk_Client.Model;

namespace WebDisk_Client.Utils
{
    /// <summary>
    /// 这是一个文件操作的工具类,提供一些文件常用的方法
    /// </summary>
    static class FileHelper
    {
        private static Computer myComputer = new Computer();   //本地文件操作

        /// <summary>
        /// 转换集合为路径
        /// </summary>
        /// <param name="path">远程路径集合</param>
        /// <returns>路径字符串</returns>
        public static string GetPath(LinkedList<string> path)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string str in path)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 路径转换集合
        /// </summary>
        /// <param name="path"></param>
        /// <param name="pathStr"></param>
        public static void PutPath(LinkedList<string> path, string pathStr)
        {          
            string[] node = Regex.Split(pathStr, "/+");
            path.Clear();
            for (int i = 1; i < node.Length - 1; i++)
            {
                path.AddLast(node[i] + "/");
            }
        }


        /// <summary>
        /// 获取文件类型
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>文件类型枚举</returns>
        public static FileType GetFileType(string[] detail, string fileName)
        {
            if (detail[0].StartsWith("d"))
            {
                return FileType.Folder;
            }
            string name = fileName.ToLower();
            if (name.EndsWith(".txt"))
            {
                return FileType.Txt;
            }
            else if (name.EndsWith(".img") || name.EndsWith(".png") || name.EndsWith(".gif") || name.EndsWith(".jpg"))
            {
                return FileType.Img;
            }
            else if (name.EndsWith(".mp3") || name.EndsWith(".wma") || name.EndsWith(".wav") || name.EndsWith(".flac"))
            {
                return FileType.Music;
            }
            else if (name.EndsWith(".doc") || name.EndsWith(".docx"))
            {
                return FileType.Doc;
            }
            else if (name.EndsWith(".ppt") || name.EndsWith(".pptx"))
            {
                return FileType.Ppt;
            }
            else if (name.EndsWith(".xls") || name.EndsWith(".xlsx"))
            {
                return FileType.Xls;
            }
            else if (name.EndsWith(".pdf"))
            {
                return FileType.Pdf;
            }
            else if (name.EndsWith(".rar") || name.EndsWith(".zip") || name.EndsWith(".7z"))
            {
                return FileType.Rar;
            }
            else if (name.EndsWith(".exe"))
            {
                return FileType.Exe;
            }
            else
            {
                return FileType.Other;
            }
        }

        /// <summary>
        /// 获取文件类型
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>文件类型枚举</returns>
        public static FileType GetFileType(DirectoryInfo info)
        {
            try
            {
                string name = info.Name.ToLower();

                if (info.Exists)
                {
                    return FileType.Folder;
                }

                if (name.EndsWith(".txt"))
                {
                    return FileType.Txt;
                }
                else if (name.EndsWith(".img") || name.EndsWith(".png") || name.EndsWith(".gif") || name.EndsWith(".jpg"))
                {
                    return FileType.Img;
                }
                else if (name.EndsWith(".mp3") || name.EndsWith(".wma") || name.EndsWith(".wav") || name.EndsWith(".flac"))
                {
                    return FileType.Music;
                }
                else if (name.EndsWith(".doc") || name.EndsWith(".docx"))
                {
                    return FileType.Doc;
                }
                else if (name.EndsWith(".ppt") || name.EndsWith(".pptx"))
                {
                    return FileType.Ppt;
                }
                else if (name.EndsWith(".xls") || name.EndsWith(".xlsx"))
                {
                    return FileType.Xls;
                }
                else if (name.EndsWith(".pdf"))
                {
                    return FileType.Pdf;
                }
                else if (name.EndsWith(".rar") || name.EndsWith(".zip") || name.EndsWith(".7z"))
                {
                    return FileType.Rar;
                }
                else if (name.EndsWith(".exe"))
                {
                    return FileType.Exe;
                }
                else
                {
                    return FileType.Other;
                }
            }
            catch (Exception)
            {
                return FileType.Other;
            }

        }

        /// <summary>
        /// 获取文件类型
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>文件类型枚举</returns>
        public static FileType GetFileType(FileInfo info)
        {
            try
            {
                string name = info.Name.ToLower(); ;

                if (name.EndsWith(".txt"))
                {
                    return FileType.Txt;
                }
                else if (name.EndsWith(".img") || name.EndsWith(".png") || name.EndsWith(".gif") || name.EndsWith(".jpg"))
                {
                    return FileType.Img;
                }
                else if (name.EndsWith(".mp3") || name.EndsWith(".wma") || name.EndsWith(".wav") || name.EndsWith(".flac"))
                {
                    return FileType.Music;
                }
                else if (name.EndsWith(".doc") || name.EndsWith(".docx"))
                {
                    return FileType.Doc;
                }
                else if (name.EndsWith(".ppt") || name.EndsWith(".pptx"))
                {
                    return FileType.Ppt;
                }
                else if (name.EndsWith(".xls") || name.EndsWith(".xlsx"))
                {
                    return FileType.Xls;
                }
                else if (name.EndsWith(".pdf"))
                {
                    return FileType.Pdf;
                }
                else if (name.EndsWith(".rar") || name.EndsWith(".zip") || name.EndsWith(".7z"))
                {
                    return FileType.Rar;
                }
                else if (name.EndsWith(".exe"))
                {
                    return FileType.Exe;
                }
                else
                {
                    return FileType.Other;
                }
            }
            catch (Exception)
            {
                return FileType.Other;
            }

        }

        /// <summary>
        /// 文件大小单位转换
        /// </summary>
        /// <param name="size">文件字节大小</param>
        /// <returns></returns>
        public static string UnitConversion(double size)
        {

            string[] units = new string[] { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }
            return size.ToString("0.00") + units[i];
        }




        /// <summary>
        /// 获取文件类型描述
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetTypeStr(FileType type)
        {
            if (type == FileType.Img)
            {
                return "图片";
            }
            else if (type == FileType.Music)
            {
                return "音乐";
            }
            else if (type == FileType.Pdf)
            {
                return "PDF";
            }
            else if (type == FileType.Rar)
            {
                return "压缩包";
            }
            else if (type == FileType.Txt)
            {
                return "纯文本";
            }
            else if (type == FileType.Video)
            {
                return "视频";
            }
            else if (type == FileType.Doc)
            {
                return "文档";
            }
            else if (type == FileType.Xls)
            {
                return "表格";
            }
            else if (type == FileType.Ppt)
            {
                return "幻灯片";
            }
            else if (type == FileType.Exe)
            {
                return "可执行文件";
            }
            else if (type == FileType.Folder)
            {
                return "文件夹";
            }
            else
            {
                return "其他";
            }
        }

        /// <summary>
        /// 文件重命名
        /// </summary>
        /// <param name="localPath">本地文件路径</param>
        /// <param name="fileName">新文件名</param>
        public static void Rename(string localPath, string fileName)
        {
            if (File.Exists(localPath + ".downloading"))
            {
                //去掉下载后缀名
                myComputer.FileSystem.RenameFile(localPath + ".downloading", fileName);
            }
        }

    }
}
