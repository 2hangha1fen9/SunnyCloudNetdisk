using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WebDisk_Admin.DAL;
using WebDisk_Admin.Model;
using WebDisk_Admin.UI;
using WebDisk_Admin.Utils;
using TaskStatus = WebDisk_Admin.Model.TaskStatus;

namespace WebDisk_Admin.BLL
{
    /// <summary>
    /// 操作远程虚拟文件视图
    /// </summary>
    public class FileListView
    {
        //FTP操作类
        private FTPOperator Ftp { get; set; }
        public FileListView(User user)
        {
            Ftp = new FTPOperator(user);
        }
        /// <summary>
        /// 创建文件夹视图
        /// </summary>
        /// <param name="list">一个listview</param>
        /// <param name="path">集合形式的路径</param>
        public void CreateView(ListView list, LinkedList<string> path)
        {
            try
            {
                string cur = "";
                List<string> files = Ftp.GetFileList(cur = FileHelper.GetPath(path));
                //添加详细信息列
                if (files != null)
                {
                    list.Clear();
                    list.Columns.Add("文件名");
                    list.Columns.Add("文件大小");
                    list.Columns.Add("修改时间");
                    list.Columns.Add("文件类型");
                    list.Columns.Add("路径");
                }
                list.BeginUpdate();
                //创建视图
                foreach (string file in files)
                {
                    //创建文件描述对象
                    FileDescribe describe = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim(), cur);
                    //创建条目
                    ListViewItem item = new ListViewItem(describe.Name, (int)describe.Type);
                    item.Name = describe.Name;
                    item.SubItems.Add(FileHelper.UnitConversion(describe.Size));
                    item.SubItems.Add(describe.Time);
                    item.SubItems.Add(FileHelper.GetTypeStr(describe.Type));
                    item.SubItems.Add(describe.CurrentPath);
                    item.Tag = describe;
                    list.Items.Add(item);
                }
                if (list.View == View.Details)
                {
                    //调整列宽
                    AutoResizeColumnWidth(list);
                }
                list.EndUpdate();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 创建文件夹视图
        /// </summary>
        /// <param name="list">一个listview</param>
        /// <param name="path">集合形式的路径</param>
        /// <param name="label">需要刷新的Lable</param>
        public void CreateView(ListView list, LinkedList<string> path, Label label)
        {
            try
            {
                string cur = "";
                List<string> files = Ftp.GetFileList(cur = label.Text = FileHelper.GetPath(path));
                if (files != null)
                {
                    list.Clear();
                    list.Columns.Add("文件名");
                    list.Columns.Add("文件大小");
                    list.Columns.Add("修改时间");
                    list.Columns.Add("文件类型");
                    list.Columns.Add("路径");
                }
                list.BeginUpdate();
                foreach (string file in files)
                {
                    //创建文件描述对象
                    FileDescribe describe = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim(), cur);
                    //创建条目
                    ListViewItem item = new ListViewItem(describe.Name, (int)describe.Type);
                    item.Name = describe.Name;
                    item.SubItems.Add(FileHelper.UnitConversion(describe.Size));
                    item.SubItems.Add(describe.Time);
                    item.SubItems.Add(FileHelper.GetTypeStr(describe.Type));
                    item.SubItems.Add(describe.CurrentPath);
                    item.Tag = describe;
                    list.Items.Add(item);
                }

                if (list.View == View.Details)
                {
                    //调整列宽
                    AutoResizeColumnWidth(list);
                }
                list.EndUpdate();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 创建文件夹视图
        /// </summary>
        /// <param name="list">一个listview</param>
        /// <param name="p">字符串形式的路径</param>
        public void CreateView(ListView list, string path)
        {
            try
            {
                string cur = "";
                List<string> files = Ftp.GetFileList(cur = path);
                if (files != null)
                {
                    list.Clear();
                    list.Columns.Add("文件名");
                    list.Columns.Add("文件大小");
                    list.Columns.Add("修改时间");
                    list.Columns.Add("文件类型");
                    list.Columns.Add("路径");
                }
                list.BeginUpdate();
                foreach (string file in files)
                {
                    //创建文件描述对象
                    FileDescribe describe = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim(), cur);
                    //创建条目
                    ListViewItem item = new ListViewItem(describe.Name, (int)describe.Type);
                    item.Name = describe.Name;
                    item.SubItems.Add(FileHelper.UnitConversion(describe.Size));
                    item.SubItems.Add(describe.Time);
                    item.SubItems.Add(FileHelper.GetTypeStr(describe.Type));
                    item.SubItems.Add(describe.CurrentPath);
                    item.Tag = describe;
                    list.Items.Add(item);
                }

                if (list.View == View.Details)
                {
                    //调整列宽
                    AutoResizeColumnWidth(list);
                }
                list.EndUpdate();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 创建文件分类视图
        /// </summary>
        /// <param name="path"></param>
        public void  FileClassify(HomePanel home, string path)
        {
            try
            {
                List<string> files = Ftp.GetFileList(path);
                //删除该目录所有文件
                foreach (string file in files)
                {
                    FileDescribe describe = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim());
                    describe.CurrentPath = path + "/" + describe.Name;
                    //创建条目
                    ListViewItem item = new ListViewItem(describe.Name, (int)describe.Type);
                    item.SubItems.Add(FileHelper.UnitConversion(describe.Size));
                    item.SubItems.Add(describe.Time);
                    item.SubItems.Add(FileHelper.GetTypeStr(describe.Type));
                    item.SubItems.Add(describe.CurrentPath);
                    item.Tag = describe;

                    if (describe.Type == FileType.Img)
                    {
                        home.Picture.Items.Add(item);
                    }
                    else if (describe.Type == FileType.Video)
                    {
                        home.Video.Items.Add(item);
                    }
                    else if (describe.Type == FileType.Music)
                    {
                        home.Music.Items.Add(item);
                    }
                    else if (describe.Type == FileType.Pdf || describe.Type == FileType.Txt || describe.Type == FileType.Xls || describe.Type == FileType.Ppt || describe.Type == FileType.Doc)
                    {
                        home.Document.Items.Add(item);
                    }
                    else if (describe.Type == FileType.Folder)
                    {
                        FileClassify(home, path + "/" + describe.Name);
                    }
                    else
                    {
                        home.Other.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 查询文件
        /// </summary>
        /// <param name="path">当前路径</param>
        /// <param name="fileName">查询文件名</param>
        /// <param name="result">查询结果集</param>
        public void FindFile(string path, string fileName, ComboBox result)
        {
            try
            {
                List<string> files = Ftp.GetFileList(path);
                //删除该目录所有文件
                foreach (string file in files)
                {
                    FileDescribe describe = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim());
                    describe.CurrentPath = path + "/" + describe.Name;
                    if (describe.Name.ToLower().Contains(fileName.ToLower()) || FileHelper.GetTypeStr(describe.Type).Contains(fileName))
                    {
                        result.Items.Add($"[文件]{describe.CurrentPath}");
                    }
                    if (describe.Type == FileType.Folder)
                    {
                        FindFile(path + "/" + describe.Name, fileName, result);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="list"></param>
        /// <param name="path">当前路径</param>
        /// <param name="folderName">创建的文件夹名</param>
        /// <returns></returns>
        public void CreateFolder(LinkedList<string> path, string folder)
        {
            try
            {
                Ftp.CreatFolder(FileHelper.GetPath(path) + folder);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="list"></param>
        /// <param name="path">当前路径</param>
        /// <param name="folderName">创建的文件夹名</param>
        /// <returns></returns>
        public void CreateFolder(string path)
        {
            try
            {
                Ftp.CreatFolder(path);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="path">该文件的路径</param>
        public void DeleteFile(LinkedList<string> path, FileDescribe describe)
        {
            try
            {
                Ftp.RemoveFile(FileHelper.GetPath(path) + describe.Name);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="path">该文件的路径</param>
        public void DeleteFile(string path)
        {
            try
            {
                Ftp.RemoveFile(path);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="path">该文件的路径</param>
        public void DeleteFolder(LinkedList<string> path, FileDescribe describe)
        {
            try
            {
                //进入当前目录
                path.AddLast(describe.Name + "/");
                List<string> files = Ftp.GetFileList(FileHelper.GetPath(path));
                //删除该目录所有文件
                foreach (string file in files)
                {
                    FileDescribe des = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim());
                    if (des.Type == FileType.Folder)
                    {
                        //递归删除
                        DeleteFolder(new LinkedList<string>(path), des);
                    }
                    else
                    {
                        DeleteFile(new LinkedList<string>(path), des);
                    }
                }
                //删除该目录
                Ftp.RemoveFloder(FileHelper.GetPath(path));
                //回溯
                path.RemoveLast();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="path">该文件的路径</param>
        public void DeleteFolder(string path)
        {
            try
            {
                List<string> files = Ftp.GetFileList(path);
                //删除该目录所有文件
                foreach (string file in files)
                {
                    FileDescribe des = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim());
                    if (des.Type == FileType.Folder)
                    {
                        //递归删除
                        DeleteFolder(path + "/" + des.Name);
                    }
                    else
                    {
                        DeleteFile(path);
                    }
                }
                //删除该目录
                Ftp.RemoveFloder(path);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="path">当前路径</param>
        /// <param name="describe">当前文件</param>
        /// <param name="newName">新名字</param>
        public void RenameFile(LinkedList<string> path, FileDescribe describe, string newName)
        {
            try
            {
                string p;
                Ftp.RenameFile((p = FileHelper.GetPath(path)) + describe.Name, newName);
                describe.Name = newName;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="path">当前路径</param>
        /// <param name="describe">当前文件</param>
        /// <param name="newName">新名字</param>
        public void RenameFile(string path, string newName)
        {
            try
            {
                Ftp.RenameFile(path, newName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="task">一个下载任务</param>
        public void DownloadFile(TransTask task)
        {
            try
            {
                if (task.Status != TaskStatus.Completed)
                {
                    Ftp.Download(task);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 下载文件夹
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="task">传输任务</param>
        public void DownloadFolder(TransTask task)
        {
            try
            {
                foreach (TransTask transTask in task.SubTask)
                {
                    //如果这个任务没有被完成则刷新最新的状态
                    if (transTask.Status != TaskStatus.Completed)
                    {
                        transTask.Status = (task.ProcessBar.Tag as TransTask).Status;
                    }

                    if (transTask.Describe.Type == FileType.Folder)
                    {
                        DownloadFolder(transTask);
                    }
                    else
                    {
                        DownloadFile(transTask);
                    }

                    //更新子任务信息,根任务是全局更新,所以不包含在内
                    if (!task.IsRoot)
                    {
                        task.CompletedSize += transTask.CompletedSize;
                        task.CompletedTaskCount += transTask.CompletedTaskCount;

                        //如果为文件夹类型则全部任务完成为完成该任务
                        if (task.SubTaskCount == task.CompletedTaskCount)
                        {
                            task.Status = TaskStatus.Completed;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="task"></param>
        public void UploadFile(TransTask task)
        {
            try
            {
                if (task.Status != TaskStatus.Completed)
                {
                    Ftp.Upload(task);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 上传文件夹
        /// </summary>
        /// <param name="task"></param>
        public void UploadFolder(TransTask task)
        {
            try
            {
                foreach (TransTask transTask in task.SubTask)
                {
                    //如果这个任务没有被完成则刷新最新的状态
                    if (transTask.Status != TaskStatus.Completed)
                    {
                        transTask.Status = (task.ProcessBar.Tag as TransTask).Status;
                    }

                    if (transTask.Describe.Type == FileType.Folder)
                    {
                        UploadFolder(transTask);
                    }
                    else
                    {
                        UploadFile(transTask);
                    }

                    //更新子任务信息,根任务是全局更新,所以不包含在内
                    if (!task.IsRoot)
                    {
                        task.CompletedSize += transTask.CompletedSize;
                        task.CompletedTaskCount += transTask.CompletedTaskCount;

                        //如果为文件夹类型则全部任务完成为完成该任务
                        if (task.SubTaskCount == task.CompletedTaskCount)
                        {
                            task.Status = TaskStatus.Completed;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 创建该任务的子任务
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="task">传输任务</param>
        public void CreateDownloadSubTask(LinkedList<string> path, TransTask task)
        {
            try
            {
                //进入当前目录
                path.AddLast(task.Describe.Name + "/");
                List<string> files = Ftp.GetFileList(FileHelper.GetPath(path));

                foreach (string file in files)
                {
                    FileDescribe des = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim());
                    TransTask subTask = new TransTask(des, false, FileHelper.GetPath(path), task.TargetPath, des.Size, task.ProcessBar,task.trans);

                    //添加子任务
                    task.SubTask.Add(subTask);
                    //如果为文件夹继续寻找
                    if (des.Type == FileType.Folder)
                    {
                        //如果该任务为文件夹则创建文件夹
                        Directory.CreateDirectory(subTask.TargetPath);
                        CreateDownloadSubTask(new LinkedList<string>(path), subTask);
                        task.SubTaskCount += subTask.SubTaskCount; //创建完毕后累加子任务数量
                    }
                    else
                    {
                        task.SubTaskCount++;//累加子任务数量
                    }
                    task.TaskSize += subTask.TaskSize; //累加任务大小
                }

                //回溯
                path.RemoveLast();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 创建该任务的子任务
        /// </summary>
        /// <param name="path">根路径</param>
        /// <param name="task">根任务</param>
        public void CreateUploadSubTask(string path, TransTask task)
        {
            DirectoryInfo info = new DirectoryInfo(path);

            DirectoryInfo[] dirs = info.GetDirectories();
            FileInfo[] files = info.GetFiles();

            foreach (FileInfo file in files)
            {
                FileDescribe des = new FileDescribe(file);
                TransTask subTask = new TransTask(des, true, file.FullName, task.TargetPath, des.Size, task.ProcessBar,task.trans);

                task.SubTask.Add(subTask);
                task.SubTaskCount++;
                task.TaskSize += subTask.TaskSize;
            }
            foreach (DirectoryInfo dir in dirs)
            {
                FileDescribe des = new FileDescribe(dir);
                TransTask subTask = new TransTask(des, true, dir.FullName, task.TargetPath, des.Size, task.ProcessBar,task.trans);
                //如果该任务为文件夹则创建文件夹
                if (des.Type == FileType.Folder)
                {
                    CreateFolder(subTask.TargetPath);
                }

                task.SubTask.Add(subTask);
                CreateUploadSubTask(dir.FullName, subTask);
                task.SubTaskCount += subTask.SubTaskCount;
                task.TaskSize += subTask.TaskSize;
            }
        }

        /// <summary>
        /// 获取文件夹子文件个数
        /// </summary>
        /// <param name="path"></param>
        /// <param name="describe"></param>
        /// <returns></returns>
        public int GetFileCount(LinkedList<string> path, FileDescribe describe)
        {
            try
            {
                //进入当前目录
                path.AddLast(describe.Name + "/");
                List<string> files = Ftp.GetFileList(FileHelper.GetPath(path));

                //计算目录大小
                int count = 0;
                foreach (string file in files)
                {
                    FileDescribe des = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim());
                    if (des.Type == FileType.Folder)
                    {
                        //递归
                        count += GetFileCount(new LinkedList<string>(path), des);
                    }
                    else
                    {
                        //计算文件大小
                        count++;
                    }
                }
                //回溯
                path.RemoveLast();

                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 计算文件夹大小
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="describe">文件描述</param>
        /// <returns></returns>
        public long GetFolderSize(LinkedList<string> path, FileDescribe describe)
        {
            try
            {
                //进入当前目录
                path.AddLast(describe.Name + "/");
                List<string> files = Ftp.GetFileList(FileHelper.GetPath(path));

                //计算目录大小
                long size = 0;
                foreach (string file in files)
                {
                    FileDescribe des = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim());
                    if (des.Type == FileType.Folder)
                    {
                        //递归
                        size += GetFolderSize(new LinkedList<string>(path), des);
                    }
                    else
                    {
                        //计算文件大小
                        size += des.Size;
                    }
                }
                //回溯
                path.RemoveLast();

                return size;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 判断是否存在这个文件
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool RemoteExists(TransTask task)
        {
            try
            {
                List<string> files = Ftp.GetFileList(task.TargetPath.Substring(0, task.TargetPath.LastIndexOf("/")));
                foreach (string file in files)
                {
                    FileDescribe des = new FileDescribe(Regex.Split(file, "\\s+"), Regex.Split(file, "\\d{1,2}\\:\\d{1,2}")[1].Trim());
                    if (des.Name == task.Describe.Name || des.Name == task.Describe.Name + ".uploading")
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 自动调整详细视图的列宽
        /// </summary>
        /// <param name="lv"></param>
        public void AutoResizeColumnWidth(ListView lv)
        {
            int count = lv.Columns.Count;
            int MaxWidth = 0;
            Graphics graphics = lv.CreateGraphics();
            int width;
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            for (int i = 0; i < count; i++)
            {
                string str = lv.Columns[i].Text;
                MaxWidth = lv.Columns[i].Width;

                foreach (ListViewItem item in lv.Items)
                {
                    str = item.SubItems[i].Text;
                    width = (int)graphics.MeasureString(str, lv.Font).Width;
                    if (width > MaxWidth)
                    {
                        MaxWidth = width;
                    }
                }
                lv.Columns[i].Width = MaxWidth;
            }
        }
    }
}
