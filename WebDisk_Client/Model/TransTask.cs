using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using WebDisk_Client.Properties;
using WebDisk_Client.UI;
using WebDisk_Client.Utils;

namespace WebDisk_Client.Model
{
    /// <summary>
    /// 该对象描述了一个传输任务
    /// </summary>
    [Serializable]
    public class TransTask
    {
        [XmlElement(ElementName = "Describe")]
        public FileDescribe Describe { get; set; }     //文件信息

        [XmlElement(ElementName = "IsRoot")]
        public bool IsRoot { get; set; }            //是否为根任务

        [XmlElement(ElementName = "TaskType")]
        public bool TaskType { get; set; }              //任务类型 true上传任务 false下载任务

        [XmlElement(ElementName = "Status")]
        public TaskStatus Status { get; set; } = TaskStatus.Stop;     //任务状态

        [XmlElement(ElementName = "SourcePath")]
        public string SourcePath { get; set; }        //源路径(read路径)

        [XmlElement(ElementName = "TargetPath")]
        public string TargetPath { get; set; }       //目标路径(write路径)

        [XmlElement(ElementName = "TaskSize")]
        public long TaskSize { get; set; }              //任务大小

        [XmlElement(ElementName = "CompletedSize")]
        public long CompletedSize { get; set; }      //已完成大小

        [XmlElement(ElementName = "SubTaskCount")]
        public int SubTaskCount { get; set; }     //子任务数量

        [XmlElement(ElementName = "CompletedTaskCount")]
        public int CompletedTaskCount { get; set; }  //已完成子任务数量

        [XmlArray(ElementName = "SubTask")]
        public List<TransTask> SubTask { get; set; } = new List<TransTask>();   //子任务

        [XmlIgnore]
        public ProcessBar ProcessBar { get; set; }         //进度条
        [XmlIgnore]
        public TransPanel trans;

        public TransTask() { }

        /// <summary>
        /// 实例化传输任务
        /// </summary>
        /// <param name="describe">远程文件描述</param>
        /// <param name="taskType">任务类型 true上传任务 false下载任务</param>
        /// <param name="sourcePath">源路径(read路径)</param>
        /// <param name="taskSize">任务大小</param>
        public TransTask(FileDescribe describe, bool taskType, string sourcePath, long taskSize, TransPanel trans)
        {
            if (taskType) //上传任务
            {
                this.Describe = describe;
                this.TaskType = taskType;
                this.SourcePath = sourcePath;
                this.TargetPath = describe.Name;
                this.TaskSize = taskSize;
            }
            else //下载任务
            {
                this.Describe = describe;
                this.TaskType = taskType;
                this.SourcePath = sourcePath + describe.Name;
                this.TargetPath = Settings.Default.downloadPath + "/" + describe.Name;
                this.TaskSize = taskSize;
            }
            this.trans = trans;
        }

        /// <summary>
        /// 实例化传输任务
        /// </summary>
        /// <param name="describe">远程文件描述</param>
        /// <param name="taskType">任务类型 true上传任务 false下载任务</param>
        /// <param name="sourcePath">源路径(read路径)</param>
        /// <param name="targetPath">目标路径(write路径)</param>
        /// <param name="taskSize">任务大小</param>
        public TransTask(FileDescribe describe, bool taskType, string sourcePath, string targetPath, long taskSize, TransPanel trans)
        {
            if (taskType) //上传任务
            {
                this.Describe = describe;
                this.TaskType = taskType;
                this.SourcePath = sourcePath;
                this.TargetPath = targetPath + "/" + sourcePath.Substring(sourcePath.LastIndexOf(describe.Name));
                this.TaskSize = taskSize;
            }
            else //下载任务
            {
                this.Describe = describe;
                this.TaskType = taskType;
                this.SourcePath = sourcePath + describe.Name;
                this.TargetPath = targetPath + "/" + describe.Name;
                this.TaskSize = taskSize;
            }
            this.trans = trans;
        }

        /// <summary>
        /// 实例化传输任务(带进度条)
        /// </summary>
        /// <param name="describe">远程文件描述</param>
        /// <param name="taskType">任务类型 true上传任务 false下载任务</param>
        /// <param name="sourcePath">源路径(read路径)</param>
        /// <param name="taskSize">任务大小</param>
        /// <param name="processBar">进度条</param>
        public TransTask(FileDescribe describe, bool taskType, string sourcePath, long taskSize, ProcessBar processBar, TransPanel trans) : this(describe, taskType, sourcePath, taskSize, trans)
        {
            this.ProcessBar = processBar;
        }

        /// <summary>
        /// 实例化传输任务(带进度条)
        /// </summary>
        /// <param name="describe">远程文件描述</param>
        /// <param name="taskType">任务类型 true上传任务 false下载任务</param>
        /// <param name="sourcePath">源路径(read路径)</param>
        /// <param name="targetPath">目标路径(write路径)</param>
        /// <param name="taskSize">任务大小</param>
        /// <param name="processBar">进度条</param>
        public TransTask(FileDescribe describe, bool taskType, string sourcePath, string targetPath, long taskSize, ProcessBar processBar, TransPanel trans) : this(describe, taskType, sourcePath, targetPath, taskSize, trans)
        {
            this.ProcessBar = processBar;
        }

        /// <summary>
        /// 更新进度条
        /// </summary>
        /// <param name="size">完成的字节数</param>
        public void UpdateProcessBar(long size)
        {
            //不为根任务更新全局进度
            if (!this.IsRoot)
            {
                (this.ProcessBar.Tag as TransTask).CompletedSize += size;
            }

            //更新当前任务
            this.CompletedSize += size;
            //刷新进度条
            this.ProcessBar.curByte += size;
            this.ProcessBar.process.Value = (int)((this.ProcessBar.Tag as TransTask).CompletedSize / (double)(this.ProcessBar.Tag as TransTask).TaskSize * 100);
            this.ProcessBar.tip.Text = $"{FileHelper.UnitConversion((this.ProcessBar.Tag as TransTask).CompletedSize)}/{FileHelper.UnitConversion((this.ProcessBar.Tag as TransTask).TaskSize)}\n" +
                $"{FileHelper.UnitConversion(this.ProcessBar.transSpeed)}/s";
        }

        /// <summary>
        /// 文件自动重命名,自动检测文件是否重名,并修改文件名
        /// </summary>
        /// <param name="task">待检测的任务</param>
        public void AutoRename()
        {
            string newPath = this.TargetPath;
            int count = 0;
            if (this.TaskType) //上传任务重命名方法
            {
                while (true)
                {
                    //判断文件类型,文件夹有另外的方法判断
                    if (this.Describe.Type != FileType.Folder)
                    {
                        if (trans.main.home.view.RemoteExists(this))
                        {
                            newPath = this.TargetPath.Insert(this.TargetPath.LastIndexOf("."), $"({++count})");
                            this.Describe.Name = newPath.Substring(newPath.LastIndexOf("/") + 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (trans.main.home.view.RemoteExists(this))
                        {
                            newPath = this.TargetPath + $"({++count})";
                            this.Describe.Name = newPath.Substring(newPath.LastIndexOf("/") + 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else //下载任务重命名方法
            {
                while (true)
                {
                    //判断文件类型,文件夹有另外的方法判断
                    if (this.Describe.Type != FileType.Folder)
                    {
                        if (File.Exists(newPath) || File.Exists(newPath + ".downloading"))
                        {
                            newPath = this.TargetPath.Insert(this.TargetPath.LastIndexOf("."), $"({++count})");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (Directory.Exists(newPath))
                        {
                            newPath = this.TargetPath + $"({++count})";
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            this.TargetPath = newPath;
        }

        /// <summary>
        /// 结束任务时调用的方法
        /// </summary>
        public void EndTask()
        {
            if (TaskType) //上传文件结束方法
            {
                //检测异常任务状态码
                if ((this.ProcessBar.Tag as TransTask).Status == TaskStatus.Interrupt) //取消下载,删除该文件
                {
                    if (this.IsRoot && this.Describe.Type != FileType.Folder &&trans.main.home.view.RemoteExists(this))
                    {
                        trans.main.home.view.DeleteFile(this.TargetPath + ".uploading");
                    }
                    return;
                }

                //暂停更新状态
                if ((this.ProcessBar.Tag as TransTask).Status == TaskStatus.Stop)
                {
                    this.Status = TaskStatus.Stop;
                    return;
                }

                //完成任务操作
                if (this.TaskSize == this.CompletedSize)
                {
                    this.Status = TaskStatus.Completed;
                    if (this.IsRoot)
                    {
                        this.ProcessBar.tip.Text = "上传成功";
                        this.ProcessBar.control.Visible = false;
                        this.ProcessBar.timer1.Enabled = false;

                        //移动控件位置
                        trans.Transing.BeginInvoke(new Action(() =>
                        {
                            trans.Transing.Controls.Remove(this.ProcessBar);
                        }));
                        trans.Completed.BeginInvoke(new Action(() =>
                        {
                            trans.Completed.Controls.Add(this.ProcessBar);
                            this.ProcessBar.open.Visible = true;
                        }));
                    }
                    else
                    {
                        //完成任务记录
                        this.CompletedTaskCount++;
                        (this.ProcessBar.Tag as TransTask).CompletedTaskCount++;
                    }

                    //更新根任务信息
                    this.ProcessBar.subtask.Text = $"({(this.ProcessBar.Tag as TransTask).CompletedTaskCount}/{(this.ProcessBar.Tag as TransTask).SubTaskCount})";

                    if (this.Describe.Type != FileType.Folder && trans.main.home.view.RemoteExists(this))
                    {
                        //恢复文件名
                        trans.main.home.view.RenameFile(this.TargetPath + ".uploading", this.Describe.Name.Replace(".uploading", ""));
                    }
                }
            }
            else //下载文件结束方法
            {
                //检测异常任务状态码
                if ((this.ProcessBar.Tag as TransTask).Status == TaskStatus.Interrupt) //取消下载,删除该文件
                {
                    if ((this.ProcessBar.Tag as TransTask).Describe.Type == FileType.Folder)
                    {
                        if (Directory.Exists((this.ProcessBar.Tag as TransTask).TargetPath))
                        {
                            Directory.Delete((this.ProcessBar.Tag as TransTask).TargetPath, true);
                        }
                    }
                    else
                    {
                        if (File.Exists((this.ProcessBar.Tag as TransTask).TargetPath + ".downloading"))
                        {
                            File.Delete((this.ProcessBar.Tag as TransTask).TargetPath + ".downloading");
                        }
                    }
                    return;
                }

                //暂停更新状态
                if ((this.ProcessBar.Tag as TransTask).Status == TaskStatus.Stop)
                {
                    this.Status = TaskStatus.Stop;
                    return;
                }

                //完成任务操作
                if (this.TaskSize == this.CompletedSize)
                {
                    this.Status = TaskStatus.Completed;
                    if (this.IsRoot)
                    {
                        this.ProcessBar.tip.Text = "下载成功";
                        this.ProcessBar.control.Visible = false;
                        this.ProcessBar.timer1.Enabled = false;

                        //移动控件位置
                        trans.Transing.BeginInvoke(new Action(() =>
                        {
                            trans.Transing.Controls.Remove(this.ProcessBar);
                        }));
                        trans.Completed.BeginInvoke(new Action(() =>
                        {
                            trans.Completed.Controls.Add(this.ProcessBar);
                            this.ProcessBar.open.Visible = true;
                        }));
                    }
                    else
                    {
                        //完成任务记录
                        this.CompletedTaskCount++;
                        (this.ProcessBar.Tag as TransTask).CompletedTaskCount++;
                    }

                    //更新根任务信息
                    this.ProcessBar.subtask.Text = $"({(this.ProcessBar.Tag as TransTask).CompletedTaskCount}/{(this.ProcessBar.Tag as TransTask).SubTaskCount})";

                    if (this.Describe.Type != FileType.Folder && File.Exists(this.TargetPath + ".downloading"))
                    {
                        //恢复文件名
                        FileHelper.Rename(this.TargetPath, this.TargetPath.Substring(this.TargetPath.LastIndexOf("/") + 1));
                    }
                }
            }
        }
    }
}
