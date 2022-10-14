using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using WebDisk_Client.Model;
using WebDisk_Client.Properties;
using TaskStatus = WebDisk_Client.Model.TaskStatus;

namespace WebDisk_Client.DAL
{
    /// <summary>
    /// 操作FTP服务器
    /// </summary>
    public class FTPOperator
    {
        private User user;      //当前用户
        private string UrlHeader { get; }       //ftp根路径
        private FtpWebRequest Request { get; set; }       //ftp请求
        private FtpWebResponse Response { get; set; }    //ftp响应

        /// <summary>
        /// 构造ftp客户端
        /// </summary>
        /// <param name="serverIP">ftp服务器ip</param>
        /// <param name="account">ftp账号</param>
        /// <param name="password">ftp密码</param>
        public FTPOperator(User user)
        {
            this.user = user;
            this.UrlHeader = $@"ftp://{Settings.Default.serverIp}/";
        }

        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <returns>文件列表集合</returns>
        public List<string> GetFileList(string path)
        {
            List<string> list = new List<string>();
            try
            {
                //创建ftp请求
                Request = (FtpWebRequest)FtpWebRequest.Create(new Uri(UrlHeader + HttpUtility.UrlEncode(path).Replace("+", "%20")));
                //设置请求凭据
                Request.Credentials = user.Credential;
                //设置获取文件详细信息的方法
                Request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                //发送请求并接受响应
                Response = (FtpWebResponse)Request.GetResponse();

                //读取数据
                using (StreamReader reader = new StreamReader(Response.GetResponseStream()))
                {
                    //读取数据
                    string detail = null;
                    while ((detail = reader.ReadLine()) != null)
                    {
                        //过滤多余内容
                        if (detail.EndsWith(".") || detail.EndsWith("..") || detail.EndsWith(".ftpquota"))
                        {
                            continue;
                        }
                        list.Add(detail);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("错误的路径:" + path);
                throw new Exception("目录获取失败:(");
            }
            finally
            {
                if (Response != null)
                {
                    Response.Close();
                }
            }
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="path">父路径</param>
        /// <returns>是否完成操作</returns>
        public void CreatFolder(string path)
        {
            try
            {
                //创建请求
                Request = (FtpWebRequest)FtpWebRequest.Create(new Uri(UrlHeader + HttpUtility.UrlEncode(path).Replace("+", "%20")));
                //设置凭证
                Request.Credentials = user.Credential;
                //设置请求方法
                Request.Method = WebRequestMethods.Ftp.MakeDirectory;
                //发送请求
                Response = (FtpWebResponse)Request.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("错误的路径:" + path);
                throw new Exception("创建文件夹失败:(");
            }
            finally
            {
                if (Response != null)
                {
                    Response.Close();
                }
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="path">被删除的文件路径</param>
        public void RemoveFile(string path)
        {
            try
            {
                //创建请求
                Request = (FtpWebRequest)FtpWebRequest.Create(new Uri(UrlHeader + HttpUtility.UrlEncode(path).Replace("+", "%20")));
                //设置凭证
                Request.Credentials = user.Credential;
                //设置请求方法
                Request.Method = WebRequestMethods.Ftp.DeleteFile;
                //发送请求
                Response = (FtpWebResponse)Request.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("错误的路径:" + path);
                throw new Exception("删除文件失败:(");
            }
            finally
            {
                if (Response != null)
                {
                    Response.Close();
                }
            }
        }

        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="path">被删除的文件夹路径</param>
        public void RemoveFloder(string path)
        {
            try
            {
                //创建请求
                Request = (FtpWebRequest)FtpWebRequest.Create(new Uri(UrlHeader + HttpUtility.UrlEncode(path).Replace("+", "%20")));

                //设置凭证
                Request.Credentials = user.Credential;
                //设置请求方法
                Request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                //发送请求
                Response = (FtpWebResponse)Request.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("错误的路径:" + path);
                throw new Exception("删除文件夹失败:(");
            }
            finally
            {
                if (Response != null)
                {
                    Response.Close();
                }
            }
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="path">目标文件路径</param>
        /// <param name="newName">新名字</param>
        public void RenameFile(string path, string newName)
        {
            try
            {
                //创建请求
                Request = (FtpWebRequest)FtpWebRequest.Create(new Uri(UrlHeader + HttpUtility.UrlEncode(path).Replace("+", "%20")));
                //设置凭证
                Request.Credentials = user.Credential;
                //设置请求方法
                Request.Method = WebRequestMethods.Ftp.Rename;
                //设置新名字
                Request.RenameTo = newName;
                //发送请求
                Response = (FtpWebResponse)Request.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("错误的路径:" + path);
                throw new Exception("重命名失败:(");

            }
            finally
            {
                if (Response != null)
                {
                    Response.Close();
                }
            }
        }

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="task">一个传输任务</param>
        public void Download(TransTask task)
        {
            if (task.Status == TaskStatus.Start)
            {
                if (task.IsRoot)
                {
                    task.ProcessBar.tip.Text = "请求下载中";
                }

                //创建请求
                FtpWebRequest request_sub = null;
                FtpWebResponse response_sub = null;
                try
                {
                    //创建请求
                    request_sub = (FtpWebRequest)FtpWebRequest.Create(new Uri(UrlHeader + HttpUtility.UrlEncode(task.SourcePath).Replace("+", "%20")));
                    //设置凭证
                    request_sub.Credentials = user.Credential;
                    //设置请求方法
                    request_sub.Method = WebRequestMethods.Ftp.DownloadFile;
                    //设置流偏移量
                    request_sub.ContentOffset = task.CompletedSize;
                    //发送请求
                    response_sub = (FtpWebResponse)request_sub.GetResponse();

                    //下载文件
                    using (BufferedStream reader = new BufferedStream(response_sub.GetResponseStream()),
                            writer = new BufferedStream(new FileStream(task.TargetPath + ".downloading", FileMode.Append, FileAccess.Write, FileShare.Delete)))
                    {
                        byte[] buffer = new byte[4096];
                        int length = 0;
                        while ((task.ProcessBar.Tag as TransTask).Status == TaskStatus.Start && (length = reader.Read(buffer, 0, buffer.Length)) > 0)//读取数据
                        {
                            writer.Write(buffer, 0, length); //写入数据
                            task.UpdateProcessBar(length); //更新进度条
                        }
                        writer.Flush();

                        //取消\暂停下载任务
                        if ((task.ProcessBar.Tag as TransTask).Status == TaskStatus.Interrupt || (task.ProcessBar.Tag as TransTask).Status == TaskStatus.Stop)
                        {
                            request_sub.Abort();
                        }
                    }
                }
                catch (Exception ex)
                {
                    (task.ProcessBar.Tag as TransTask).Status = TaskStatus.Error;
                    task.Status = TaskStatus.Error;
                    task.ProcessBar.tip.Text = "下载失败";
                    Console.WriteLine("错误的路径:" + task.SourcePath);
                    Console.WriteLine(ex);
                    throw new Exception("下载失败:(");
                }
                finally
                {
                    task.EndTask();
                    if (response_sub != null)
                    {
                        response_sub.Close();
                    }
                }
            }
        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="task">一个传输任务</param>
        public void Upload(TransTask task)
        {
            if (task.Status == TaskStatus.Start)
            {
                if (task.IsRoot)
                {
                    task.ProcessBar.tip.Text = "请求上传中";
                }

                //创建请求
                FtpWebRequest request_sub = null;
                try
                {
                    //创建请求
                    request_sub = (FtpWebRequest)FtpWebRequest.Create(new Uri(UrlHeader + HttpUtility.UrlEncode(task.TargetPath).Replace("+", "%20") + ".uploading"));
                    //设置凭证
                    request_sub.Credentials = user.Credential;
                    //设置请求方法
                    //判断是否是断点续传
                    if (task.CompletedSize == 0)
                    {
                        request_sub.Method = WebRequestMethods.Ftp.UploadFile;
                    }
                    else
                    {
                        request_sub.Method = WebRequestMethods.Ftp.AppendFile;
                    }

                    //下载文件
                    using (BufferedStream writer = new BufferedStream(request_sub.GetRequestStream()),
                            reader = new BufferedStream(new FileStream(task.SourcePath, FileMode.Open)))
                    {
                        //设置流的偏移量
                        reader.Seek(task.CompletedSize, SeekOrigin.Begin);

                        byte[] buffer = new byte[4096];
                        int length = 0;
                        while ((task.ProcessBar.Tag as TransTask).Status == TaskStatus.Start && (length = reader.Read(buffer, 0, buffer.Length)) > 0)//读取数据
                        {
                            writer.Write(buffer, 0, length); //写入数据
                            task.UpdateProcessBar(length); //更新进度条
                        }
                        writer.Flush();

                        //取消\暂停上传任务
                        if ((task.ProcessBar.Tag as TransTask).Status == TaskStatus.Interrupt || (task.ProcessBar.Tag as TransTask).Status == TaskStatus.Stop)
                        {
                            request_sub.Abort();
                        }
                    }
                }
                catch (Exception ex)
                {
                    (task.ProcessBar.Tag as TransTask).Status = TaskStatus.Error;
                    task.Status = TaskStatus.Error;
                    task.ProcessBar.tip.Text = "上传失败";
                    Console.WriteLine("错误的路径:" + task.SourcePath);
                    Console.WriteLine(ex);
                    throw new Exception("上传失败:(");
                }
                finally
                {
                    task.EndTask();
                }
            }
        }
    }
}
