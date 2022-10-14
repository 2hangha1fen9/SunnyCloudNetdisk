using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WebDisk_Client.Model;
using WebDisk_Client.Utils;
using TaskStatus = WebDisk_Client.Model.TaskStatus;

namespace WebDisk_Client.UI
{
    public partial class TransPanel : UIPage
    {
        //传输历史
        public TransHistory history;
        //主面板引用
        public MainForm main;

        public TransPanel(MainForm main)
        {
            try
            {
                InitializeComponent();
                CheckForIllegalCrossThreadCalls = false; //取消线程调用检查
                this.main = main;
                //加载下载历史
                history = (TransHistory)XmlHelper.XmlToObject(typeof(TransHistory), main.user.UserName);
                RestoreProcessBar(history.transTasks);
            }
            catch (Exception ex)
            {
                history = new TransHistory();
                Console.WriteLine(ex);
            }
        }

        public ProcessBar ProcessBar
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// 创建进度条
        /// </summary>
        /// <param name="descibe"></param>
        /// <param name="task"></param>
        public void AddProcessBar(TransTask task)
        {
            //创建任务的进度条
            ProcessBar bar = new ProcessBar(main);
            //因为下载任务需要遍历远程目录,所以des的文件名不可修改,会导致找不到目录,所以只可以从路径中提取文件名
            bar.fileName.Text = Path.GetFileName(task.TargetPath);
            bar.fileName.Symbol = task.TaskType ? 61698 : 61699;
            bar.subtask.Text = $"({task.CompletedTaskCount}/{task.SubTaskCount})";

            //双向绑定
            bar.Tag = task;
            task.ProcessBar = bar;
            task.trans = this;

            //判断是否显示子任务进度
            if (task.Describe.Type != FileType.Folder)
            {
                task.ProcessBar.subtask.Visible = false;
            }

            //获取初始值
            task.UpdateProcessBar(0);

            //状态标识
            if (task.Status == TaskStatus.Stop)
            {
                task.ProcessBar.tip.Text = "暂停中";
                task.ProcessBar.timer1.Enabled = !task.ProcessBar.timer1.Enabled;
            }
            else if (task.Status == TaskStatus.Completed)
            {
                if (task.TaskType)
                {
                    task.ProcessBar.tip.Text = "上传成功";
                }
                else
                {
                    task.ProcessBar.tip.Text = "下载成功";
                }
                task.ProcessBar.control.Visible = false;
                task.ProcessBar.timer1.Enabled = false;
                task.ProcessBar.open.Visible = true;
            }
            else if (task.Status == TaskStatus.Error)
            {
                if (task.TaskType)
                {
                    task.ProcessBar.tip.Text = "上传失败";
                }
                else
                {
                    task.ProcessBar.tip.Text = "下载失败";
                }
            }

            //添加到窗体
            if (task.Status != TaskStatus.Completed)
            {
                this.Transing.Controls.Add(bar);
            }
            else
            {
                this.Completed.Controls.Add(bar);
            }
        }

        /// <summary>
        /// 创建历史任务的进度条
        /// </summary>
        public void RestoreProcessBar(List<TransTask> tasks)
        {
            foreach (TransTask task in tasks)
            {
                //为历史任务添加进度条
                AddProcessBar(task);
                task.trans = this;
                task.ProcessBar.state = !task.ProcessBar.state;
                task.ProcessBar.control.Symbol = 61515;
                ExtendsProcessBar(task, task.ProcessBar);
            }
        }

        /// <summary>
        /// 扩散根任务的进度条对象引用
        /// </summary>
        private void ExtendsProcessBar(TransTask subTask, ProcessBar bar)
        {
            foreach (TransTask task in subTask.SubTask)
            {
                task.ProcessBar = bar;
                task.trans = this;
                if (task.Describe.Type == FileType.Folder)
                {
                    ExtendsProcessBar(task, bar);
                }
            }
        }
        private void TransPanel_Load(object sender, EventArgs e)
        {
        }
        public void AllStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (Transing.Controls.Count == 0)
                {
                    return;
                }
                foreach (Control bar in Transing.Controls)
                {
                    if (((bar as ProcessBar).Tag as TransTask).Status == TaskStatus.Start)
                    {
                        (bar as ProcessBar).control_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorTip(ex.Message);
            }
        }
        public void AllStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Transing.Controls.Count == 0)
                {
                    return;
                }
                foreach (Control bar in Transing.Controls)
                {
                    if (((bar as ProcessBar).Tag as TransTask).Status != TaskStatus.Start)
                    {
                        (bar as ProcessBar).control_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorTip(ex.Message);
            }
        }
        public void AllCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Transing.Controls.Count == 0)
                {
                    return;
                }
                if (ShowAskDialog("提示", "是否取消所有传输任务?", UIStyle.Orange, false))
                {
                    for (int i = Transing.Controls.Count - 1; i >= 0; i--)
                    {
                        (Transing.Controls[i] as ProcessBar).delete_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorTip(ex.Message);
            }
        }
        private void AllDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Completed.Controls.Count == 0)
                {
                    return;
                }
                for (int i = Completed.Controls.Count - 1; i >= 0; i--)
                {
                    (Completed.Controls[i] as ProcessBar).delete_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ShowErrorTip(ex.Message);
            }
        }
    }
}
