using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.Model;
using WebDisk_Client.Properties;
using WebDisk_Client.UI;
using WebDisk_Client.Utils;
using TaskStatus = WebDisk_Client.Model.TaskStatus;

namespace WebDisk_Client
{
    public partial class ProcessBar : UserControl
    {
        public long transSpeed = 0; //每秒传输字节数
        public long second = 0;     //经过时间
        public long curByte = 0;    //当前时间传输的字节数
        private MainForm main;
        public ProcessBar(MainForm main)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //取消线程调用检查

            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Dock = DockStyle.Top;
            this.Font = new Font("宋体", 7.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.Location = new Point(0, 0);
            this.Margin = new Padding(2);
            this.Size = new Size(649, 41);
            this.TabIndex = 1;
            this.main = main;
        }

        /// <summary>
        /// 取消任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void delete_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            if ((this.Tag as TransTask).Status != TaskStatus.Completed)
            {
                (this.Tag as TransTask).Status = TaskStatus.Interrupt;
            }

            //删除下载历史和控件
            main.trans.history.transTasks.Remove(this.Tag as TransTask);
            main.trans.Transing.Controls.Remove((this.Tag as TransTask).ProcessBar);
            main.trans.Completed.Controls.Remove((this.Tag as TransTask).ProcessBar);
        }

        public bool state = false;
        public void control_Click(object sender, EventArgs e)
        {
            if (state)
            {
                this.control.Symbol = 61516;
                (this.Tag as TransTask).Status = TaskStatus.Start;
                if ((this.Tag as TransTask).TaskType)
                {
                    //执行下载  
                    Task.Run(() =>
                    {
                        try
                        {
                            if ((this.Tag as TransTask).Describe.Type == FileType.Folder)//判断是否是文件夹,文件夹有自己的下载方法
                            {
                                main.home.view.UploadFolder(this.Tag as TransTask);
                                //结束根任务
                                (this.Tag as TransTask).EndTask();
                            }
                            else
                            {
                                main.home.view.UploadFile(this.Tag as TransTask);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }).ContinueWith((x) =>
                    {
                        ShowNotify();
                    });
                }
                else
                {
                    //执行下载  
                    Task.Run(() =>
                    {
                        try
                        {
                            if ((this.Tag as TransTask).Describe.Type == FileType.Folder)//判断是否是文件夹,文件夹有自己的下载方法
                            {
                                main.home.view.DownloadFolder(this.Tag as TransTask);
                                //结束根任务
                                (this.Tag as TransTask).EndTask();
                            }
                            else
                            {
                                main.home.view.DownloadFile(this.Tag as TransTask);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }).ContinueWith((x) =>
                    {
                        ShowNotify();
                    });
                }
            }
            else
            {
                this.control.Symbol = 61515;
                (this.Tag as TransTask).Status = TaskStatus.Stop;
            }
            state = !state;
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            transSpeed = curByte / second;
        }

        private void open_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                OpenFile((this.Tag as TransTask));
            });
        }

        /// <summary>
        /// 操作提示
        /// </summary>
        public void ShowNotify()
        {

            if (!this.IsHandleCreated)
            {
                return;
            }
            if ((this.Tag as TransTask).Status == TaskStatus.Completed)
            {
                if (Settings.Default.showSuccessTip)
                {
                    if ((this.Tag as TransTask).TaskType)
                    {
                        this.Invoke(new Action(() =>
                        {
                            main.trans.ShowSuccessNotifier($"{(this.Tag as TransTask).Describe.Name} 上传成功");
                        }));

                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            main.trans.ShowSuccessNotifier($"{(this.Tag as TransTask).Describe.Name} 下载成功");
                        }));

                    }
                }

                if (Settings.Default.playSuccessSound)
                {
                    HomePanel.sound.Play();
                }
            }
            else if ((this.Tag as TransTask).Status == TaskStatus.Error)
            {
                if (Settings.Default.showSuccessTip)
                {
                    if ((this.Tag as TransTask).TaskType)
                    {
                        this.Invoke(new Action(() =>
                        {
                            main.trans.ShowErrorNotifier($"{(this.Tag as TransTask).Describe.Name} 上传失败");
                        }));
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            main.trans.ShowErrorNotifier($"{(this.Tag as TransTask).Describe.Name} 下载失败");
                        }));
                    }
                }
            }
        }

        public void OpenFile(TransTask task)
        {

            if (!task.TaskType)
            {
                if (task.Describe.Type == FileType.Folder)
                {
                    CmdHelper.Execute($@"explorer ""{task.TargetPath}""", 10);
                }
                else
                {
                    CmdHelper.Execute($@"""{task.TargetPath}""", 10);
                }
            }
            else
            {
                main.home.view.CreateView(main.home.AllFile, task.TargetPath.Replace(task.Describe.Name, ""));
                FileHelper.PutPath(main.home.curPath,task.TargetPath);
                HomePanel.autoReload = false;
                main.SwitchPage(1);
                if(main.home.AllFile.Items[task.Describe.Name] != null)
                {
                    main.home.AllFile.Items[task.Describe.Name].Selected = true;
                    main.home.AllFile.Items[task.Describe.Name].Checked = true;
                }                   
            }          
        }
    }
}
