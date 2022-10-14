using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Admin.BLL;
using WebDisk_Admin.Model;
using WebDisk_Admin.Properties;
using WebDisk_Admin.Utils;
using TaskStatus = WebDisk_Admin.Model.TaskStatus;

namespace WebDisk_Admin.UI
{
    public partial class HomePanel : UIPage
    {
        #region 初始化
        //当前路径
        public LinkedList<string> curPath = new LinkedList<string>();
        //操作虚拟文件夹视图对象
        public FileListView view;
        //主窗体引用
        private MainForm main;
        //是否自动加载页面
        public static bool autoReload = true;
        //分享管理器
        private ShareManager manager = new ShareManager();
        //提示音
        public static SoundPlayer sound = new SoundPlayer(Resources.Completed);

        public HomePanel(MainForm main)
        {
            InitializeComponent();
            this.全部文件.BackColor = System.Drawing.Color.White;
            CheckForIllegalCrossThreadCalls = false; //取消线程调用检查      
            this.fileSelector.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.main = main;
            view = new FileListView(main.user);    
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HomeForm_Load(object sender, EventArgs e)
        {
            //使用线程加载视图
            Task.Run(() =>
            {
                try
                {
                    if (autoReload)
                    {
                        //显示加载图标
                        this.loading.Visible = true;
                        view.CreateView(this.AllFile, curPath);
                        Classfiy();
                    }
                    else
                    {
                        autoReload = true;
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) => //加载完毕后取消加载图标 
            {
                this.loading.Visible = false;
            });
        }

        /// <summary>
        /// 文件分类
        /// </summary>
        private void Classfiy()
        {
            try
            {
                Picture.BeginUpdate();
                Video.BeginUpdate();
                Music.BeginUpdate();
                Document.BeginUpdate();
                Other.BeginUpdate();

                Picture.Items.Clear();
                Video.Items.Clear();
                Music.Items.Clear();
                Document.Items.Clear();
                Other.Items.Clear();

                Picture.EndUpdate();
                Video.EndUpdate();
                Music.EndUpdate();
                Document.EndUpdate();
                Other.EndUpdate();
                view.FileClassify(this, "");
            }
            catch (Exception ex)
            {
                ShowInfoTip(ex.Message);
            }
        }
        #endregion

        #region 文件导航
        /// <summary>
        /// 获取鼠标上当前的文件夹名字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            e.Item.ToolTipText = (e.Item.Tag as FileDescribe).ToString();
        }

        /// <summary>
        /// 文件夹双击进入下一级目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    this.loading.Visible = true;
                    //判断是否是文件夹
                    if ((this.AllFile.SelectedItems[0].Tag as FileDescribe).Type != FileType.Folder)
                    {
                        return;
                    }
                    curPath.AddLast((this.AllFile.SelectedItems[0].Tag as FileDescribe).Name + '/');//获取跳转路径
                    view.CreateView(this.AllFile, curPath, this.path);//刷新视图
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
                AllFile_MouseUp(null, null);
            });
        }

        /// <summary>
        /// 返回上一级目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {              
                try
                {
                    this.back.Enabled = false;
                    if (curPath.Count > 0)
                    {
                        curPath.RemoveLast();
                        view.CreateView(this.AllFile, curPath, this.path);
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
                this.back.Enabled = true;
                AllFile_MouseUp(null, null);
            });
        }

        /// <summary>
        /// 返回主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void home_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {               
                try
                {
                    this.loading.Visible = true;
                    this.curPath.Clear();
                    this.path.Text = "";
                    view.CreateView(this.AllFile, "");
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
                AllFile_MouseUp(null,null);
            });
        }

        /// <summary>
        /// 打开操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断listview类型
            if (uiTabControlMenu1.SelectedIndex != 0)
            {
            }
            else
            {
                if ((this.AllFile.SelectedItems[0].Tag as FileDescribe).Type == FileType.Folder)
                {
                    listView1_MouseDoubleClick(null, null);
                }
            }
        }      
        #endregion

        #region 移动文件
        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 移动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fileOperator.Tag == null)
                {
                    ShowInfoTip("选择目标位置后选择移动到这里");
                    //获取选中文件
                    List<FileDescribe> describes = new List<FileDescribe>();
                    foreach (ListViewItem item in this.AllFile.SelectedItems)
                    {
                        describes.Add((item.Tag as FileDescribe));
                    }
                    //保存选中文件
                    this.fileOperator.Tag = describes;
                    this.移动ToolStripMenuItem.Text = "移动到这里";
                    this.取消ToolStripMenuItem.Visible = true;
                }
                else
                {
                    //获取选中的文件
                    List<FileDescribe> describes = (this.fileOperator.Tag as List<FileDescribe>);
                    foreach (FileDescribe des in describes) //移动文件
                    {
                        view.RenameFile(des.CurrentPath, "/" + FileHelper.GetPath(curPath) + des.Name);
                    }
                    //清空所选文件
                    this.fileOperator.Tag = null;
                    this.移动ToolStripMenuItem.Text = "移动";
                    this.取消ToolStripMenuItem.Visible = false;
                    //刷新页面
                    flush_Click(null, null);
                    ShowSuccessTip("移动成功");
                }
            }
            catch (Exception)
            {
                ShowErrorTip("移动文件失败");
                this.移动ToolStripMenuItem.Text = "移动";
                if (this.fileOperator.Tag != null)
                {
                    this.fileOperator.Tag = null;
                }
            }
        }

        /// <summary>
        /// 移动文件取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fileOperator.Tag = null;
            this.移动ToolStripMenuItem.Text = "移动";
            this.取消ToolStripMenuItem.Visible = false;
        }
        #endregion

        #region 刷新视图
        /// <summary>
        /// 刷新当前文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flush_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    this.loading.Visible = true;
                    view.CreateView(this.AllFile, curPath);
                    Classfiy();
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
            });
        }

        /// <summary>
        /// 右键菜单刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flush_Click(null, null);
        }
        #endregion

        #region 新建文件夹
        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createFolder_DoEnter(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.loading.Visible = true;
                try
                {
                    string name = this.createFolder.Text.Trim();
                    if (Regex.IsMatch(name, "^\\s\\/:\\*\\?\"<>\\|[^\\s\\/:\\?\"<>\\|\\.]$"))
                    {
                        throw new Exception();
                    }
                    view.CreateFolder(curPath, name);
                    this.createFolder.Text = "";
                    flush_Click(null, null);
                    ShowSuccessTip("新建文件夹成功");
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
            });
        }

        /// <summary>
        /// 右键菜单新建文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.loading.Visible = true;
                try
                {
                    view.CreateFolder(curPath, "新建文件夹");
                    //添加listview条目
                    ListViewItem item = new ListViewItem("新建文件夹", (int)FileType.Folder);
                    FileDescribe info = new FileDescribe(FileType.Folder, 4026, "now", "新建文件夹");
                    item.SubItems.Add(FileHelper.UnitConversion(info.Size));
                    item.SubItems.Add(DateTime.Now.ToShortDateString());
                    item.SubItems.Add(FileHelper.GetTypeStr(info.Type));
                    item.Tag = info;
                    this.AllFile.Items.Add(item);
                    //重命名
                    item.Selected = true;
                    重命名ToolStripMenuItem_Click(null, null);
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
            });
        }

        /// <summary>
        /// 新建文件夹文件提示框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createFolder_Enter(object sender, EventArgs e)
        {
            ShowInfoTip("输入文件名按回车键提交");
        }
        #endregion

        #region 删除文件
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断listview类型
            if (uiTabControlMenu1.SelectedIndex != 0)
            {
                ListView selected = (uiTabControlMenu1.SelectedTab.Controls[0] as ListView);
                Task.Run(() =>
                {
                    this.loading.Visible = true;
                    try
                    {
                        if (ShowAskDialog("提示", "确定要删除该文件吗?", UIStyle.Gray, false))
                        {
                            foreach (ListViewItem item in selected.SelectedItems)
                            {
                                view.DeleteFile((item.Tag as FileDescribe).CurrentPath);
                                item.Remove();
                            }
                            ShowSuccessTip("删除成功");
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowErrorTip(ex.Message);
                    }
                }).ContinueWith((x) =>
                {
                    this.loading.Visible = false;
                });
            }
            else
            {
                Task.Run(() =>
                {
                    this.loading.Visible = true;
                    try
                    {
                        if (ShowAskDialog("提示", "确定要删除该文件吗?", UIStyle.Gray, false))
                        {
                            foreach (ListViewItem item in this.AllFile.SelectedItems)
                            {
                                FileDescribe des = item.Tag as FileDescribe;
                                if (des.Type == FileType.Folder)//判断是否是文件夹,文件夹有自己的删除方法
                                {
                                    view.DeleteFolder(new LinkedList<string>(curPath), des);
                                }
                                else
                                {
                                    view.DeleteFile(curPath, des);
                                }
                                item.Remove();                            
                            }
                            ShowSuccessTip("删除成功");
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowErrorTip(ex.Message);
                    }
                }).ContinueWith((x) =>
                {
                    this.loading.Visible = false;
                });
            }
        }
        #endregion

        #region 重命名
        /// <summary>
        /// 重命名前获取当前文件名
        /// </summary>
        private static string curName = "";

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            //判断listview类型
            if (uiTabControlMenu1.SelectedIndex != 0)
            {
                Task.Run(() =>
                {
                    ListView selected = (uiTabControlMenu1.SelectedTab.Controls[0] as ListView);
                    try
                    {
                        string newName = selected.SelectedItems[0].Text.Trim();
                        if (curName != newName)//如果文件名没有被修改则不请求服务器
                        {
                            //文件名合法检测
                            if (Regex.IsMatch(newName, "^\\s\\/:\\*\\?\"<>\\|[^\\s\\/:\\?\"<>\\|]$"))
                            {
                                throw new Exception();
                            }
                            view.RenameFile((selected.SelectedItems[0].Tag as FileDescribe).CurrentPath, newName);//重命名
                        }
                        ShowSuccessTip("重命名成功");
                    }
                    catch (Exception ex)
                    {
                        selected.SelectedItems[0].Text = curName;
                        ShowErrorTip(ex.Message);
                    }
                });
            }
            else
            {
                Task.Run(() =>
                {
                    try
                    {
                        string newName = this.AllFile.SelectedItems[0].Text.Trim();
                        if (curName != newName)//如果文件名没有被修改则不请求服务器
                        {
                            //文件名合法检测
                            if (Regex.IsMatch(newName, "^\\s\\/:\\*\\?\"<>\\|[^\\s\\/:\\?\"<>\\|]$"))
                            {
                                throw new Exception();
                            }
                            view.RenameFile(curPath, this.AllFile.SelectedItems[0].Tag as FileDescribe, newName);//重命名
                        }
                    }
                    catch (Exception ex)
                    {                      
                        if(this.AllFile.SelectedItems.Count != 0)
                        {
                            this.AllFile.SelectedItems[0].Text = curName;
                        }
                        ShowInfoTip(ex.Message);
                    }
                });
            }
        }

        /// <summary>
        /// 重命名F2快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //判断listview类型
                if (uiTabControlMenu1.SelectedIndex != 0)
                {
                    ListView selected = (uiTabControlMenu1.SelectedTab.Controls[0] as ListView);
                    selected.SelectedItems[0].BeginEdit();
                }
                else
                {
                    this.AllFile.SelectedItems[0].BeginEdit();
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                删除ToolStripMenuItem_Click(null, null);
            }
        }

        /// <summary>
        /// 重命名右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断listview类型
            if (uiTabControlMenu1.SelectedIndex != 0)
            {
                ListView selected = (uiTabControlMenu1.SelectedTab.Controls[0] as ListView);
                if (selected.SelectedItems.Count != 0)
                {
                    selected.SelectedItems[0].BeginEdit();
                }
            }
            else
            {
                if (this.AllFile.SelectedItems.Count != 0)
                {
                    this.AllFile.SelectedItems[0].BeginEdit();
                }
            }
        }

        /// <summary>
        /// 开启编辑模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            //判断listview类型
            if (uiTabControlMenu1.SelectedIndex != 0)
            {
                ListView selected = (uiTabControlMenu1.SelectedTab.Controls[0] as ListView);
                curName = selected.SelectedItems[0].Text;
            }
            else
            {
                curName = this.AllFile.SelectedItems[0].Text;
            }
        }
        #endregion

        #region 视图切换
        /// <summary>
        /// 大图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AllFile.View = this.Picture.View = this.Video.View = this.Music.View = this.Document.View = this.Other.View = View.LargeIcon;
            this.大图标ToolStripMenuItem.Checked = true;
            this.小图标ToolStripMenuItem.Checked = false;
            this.详细信息ToolStripMenuItem.Checked = false;
            this.列表ToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// 小图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AllFile.View = this.Picture.View = this.Video.View = this.Music.View = this.Document.View = this.Other.View = View.SmallIcon;
            this.小图标ToolStripMenuItem.Checked = true;
            this.大图标ToolStripMenuItem.Checked = false;
            this.详细信息ToolStripMenuItem.Checked = false;
            this.列表ToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// 详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AllFile.View = this.Picture.View = this.Video.View = this.Music.View = this.Document.View = this.Other.View = View.Details;
            view.AutoResizeColumnWidth(this.AllFile);
            view.AutoResizeColumnWidth(this.Picture);
            view.AutoResizeColumnWidth(this.Video);
            view.AutoResizeColumnWidth(this.Music);
            view.AutoResizeColumnWidth(this.Document);
            view.AutoResizeColumnWidth(this.Other);
            this.详细信息ToolStripMenuItem.Checked = true;
            this.小图标ToolStripMenuItem.Checked = false;
            this.大图标ToolStripMenuItem.Checked = false;
            this.列表ToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AllFile.View = this.Picture.View = this.Video.View = this.Music.View = this.Document.View = this.Other.View = View.List;
            this.列表ToolStripMenuItem.Checked = true;
            this.小图标ToolStripMenuItem.Checked = false;
            this.详细信息ToolStripMenuItem.Checked = false;
            this.大图标ToolStripMenuItem.Checked = false;
        }

        /// <summary>
        ///平铺
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AllFile.View = this.Picture.View = this.Video.View = this.Music.View = this.Document.View = this.Other.View = View.Tile;
            this.列表ToolStripMenuItem.Checked = false;
            this.小图标ToolStripMenuItem.Checked = false;
            this.详细信息ToolStripMenuItem.Checked = false;
            this.大图标ToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// 上下文菜单项控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileOperator_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //判断listview类型
            if (uiTabControlMenu1.SelectedIndex != 0)
            {
                ListView selected = (uiTabControlMenu1.SelectedTab.Controls[0] as ListView);
                this.fileOperator.Items["新建文件夹ToolStripMenuItem"].Visible = false;
                this.fileOperator.Items["移动ToolStripMenuItem"].Visible = false;
                this.fileOperator.Items["上传ToolStripMenuItem"].Visible = false;
                if (selected.SelectedItems.Count == 0)
                {
                    this.fileOperator.Items["重命名ToolStripMenuItem"].Visible = false;
                    this.fileOperator.Items["删除ToolStripMenuItem"].Visible = false;
                    this.fileOperator.Items["下载ToolStripMenuItem"].Visible = false;
                    this.fileOperator.Items["下载到ToolStripMenuItem"].Visible = false;
                }
                else
                {
                    this.fileOperator.Items["重命名ToolStripMenuItem"].Visible = true;
                    this.fileOperator.Items["删除ToolStripMenuItem"].Visible = true;
                    this.fileOperator.Items["下载ToolStripMenuItem"].Visible = true;
                    this.fileOperator.Items["下载到ToolStripMenuItem"].Visible = true;
                }
            }
            else
            {
                this.fileOperator.Items["新建文件夹ToolStripMenuItem"].Visible = true;
                this.fileOperator.Items["上传ToolStripMenuItem"].Visible = true;
                if (this.AllFile.SelectedItems.Count == 0)
                {
                    this.fileOperator.Items["重命名ToolStripMenuItem"].Visible = false;
                    this.fileOperator.Items["删除ToolStripMenuItem"].Visible = false;
                    this.fileOperator.Items["下载ToolStripMenuItem"].Visible = false;
                    this.fileOperator.Items["下载到ToolStripMenuItem"].Visible = false;
                    if (this.fileOperator.Tag != null)
                    {
                        this.fileOperator.Items["移动ToolStripMenuItem"].Visible = true;
                    }
                    else
                    {
                        this.fileOperator.Items["移动ToolStripMenuItem"].Visible = false;
                    }
                }
                else
                {
                    this.fileOperator.Items["重命名ToolStripMenuItem"].Visible = true;
                    this.fileOperator.Items["删除ToolStripMenuItem"].Visible = true;
                    this.fileOperator.Items["下载ToolStripMenuItem"].Visible = true;
                    this.fileOperator.Items["下载到ToolStripMenuItem"].Visible = true;
                    this.fileOperator.Items["移动ToolStripMenuItem"].Visible = true;
                }
            }
        }

        /// <summary>
        /// 按钮显示控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllFile_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.AllFile.SelectedItems.Count == 0)
            {
                this.download.Visible = false;
            }
            else
            {
                this.download.Visible = true;
            }
        }
        #endregion

        #region 下载文件
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void download_Click(object sender, EventArgs e)
        {
            if (uiTabControlMenu1.SelectedIndex != 0)
            {
                ListView selected = (uiTabControlMenu1.SelectedTab.Controls[0] as ListView);
                if (selected.SelectedItems.Count == 0)
                {
                    ShowWarningTip("至少选择一项文件");
                    return;
                }
                else
                {
                    main.SwitchPage(4);
                }
                //遍历选中的条目
                foreach (ListViewItem item in selected.SelectedItems)
                {
                    //获取文件描述
                    FileDescribe des = item.Tag as FileDescribe;
                    //创建传输任务
                    TransTask task = new TransTask(des, false, FileHelper.GetPath(curPath), des.Size,main.trans);
                    task.SourcePath = des.CurrentPath;
                    task.AutoRename();
                    task.IsRoot = true;//设置为根任务
                    task.Status = TaskStatus.Start;

                    //创建进度条
                    main.trans.AddProcessBar(task);
                    //添加历史记录
                    main.trans.history.transTasks.Add(task);
                    
                    //执行下载  
                    Task.Run(() =>
                    {
                        try
                        {
                            view.DownloadFile(task);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            ShowInfoTip(ex.Message);
                            task.ProcessBar.tip.Text = ex.Message;
                        }
                    }).ContinueWith((x) =>
                    {
                        task.ProcessBar.ShowNotify();
                    });
                }
            }
            else
            {
                if (this.AllFile.SelectedItems.Count == 0)
                {
                    ShowWarningTip("至少选择一项文件");
                    return;
                }
                else
                {
                    main.SwitchPage(2);
                }
                //遍历选中的条目
                foreach (ListViewItem item in this.AllFile.SelectedItems)
                {
                    //获取文件描述
                    FileDescribe des = item.Tag as FileDescribe;
                    //创建传输任务
                    TransTask task = new TransTask(des, false, FileHelper.GetPath(curPath), des.Size, main.trans);
                    task.AutoRename();
                    //如果该任务为文件夹则创建文件夹
                    if (des.Type == FileType.Folder)
                    {
                        Directory.CreateDirectory(task.TargetPath);
                    }
                    task.IsRoot = true;//设置为根任务
                    task.Status = TaskStatus.Start;

                    //创建进度条
                    main.trans.AddProcessBar(task);
                    //添加历史记录
                    main.trans.history.transTasks.Add(task);
                    //执行下载  
                    Task.Run(() =>
                    {
                        try
                        {
                            if (des.Type == FileType.Folder)//判断是否是文件夹,文件夹有自己的下载方法
                            {
                                task.ProcessBar.tip.Text = "正在计算文件夹";
                                view.CreateDownloadSubTask(new LinkedList<string>(curPath), task);
                                task.ProcessBar.subtask.Text = $"({task.CompletedTaskCount}/{task.SubTaskCount})";
                                task.ProcessBar.second = 0;
                                view.DownloadFolder(task);

                                //结束根任务
                                task.EndTask();
                            }
                            else
                            {
                                view.DownloadFile(task);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }).ContinueWith((x) =>
                    {
                        task.ProcessBar.ShowNotify();
                    });
                }
            }
        }

        /// <summary>
        /// 右键菜单下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            download_Click(null, null);
        }

        /// <summary>
        /// 重定向下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 下载到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //分类页下载文件操作
                if (uiTabControlMenu1.SelectedIndex != 0)
                {
                    ListView selected = (uiTabControlMenu1.SelectedTab.Controls[0] as ListView);

                    //未选中任何一行
                    if (selected.SelectedItems.Count == 0)
                    {
                        throw new Exception("至少选择一项文件");
                    }

                    string selectedPath = null;
                    if (this.pathSelector.ShowDialog(this) == DialogResult.OK)
                    {
                        selectedPath = this.pathSelector.SelectedPath;
                        main.SwitchPage(2);
                    }
                    else
                    {
                        return;
                    }

                    //遍历选中的条目
                    foreach (ListViewItem item in selected.SelectedItems)
                    {
                        //获取文件描述
                        FileDescribe des = item.Tag as FileDescribe;
                        //创建传输任务
                        TransTask task = new TransTask(des, false, FileHelper.GetPath(curPath), selectedPath, des.Size, main.trans);
                        task.SourcePath = des.CurrentPath;
                        task.AutoRename();
                        task.IsRoot = true;//设置为根任务
                        task.Status = TaskStatus.Start;

                        //创建进度条
                        main.trans.AddProcessBar(task);
                        //添加历史记录
                        main.trans.history.transTasks.Add(task);
                        //执行下载  
                        Task.Run(() =>
                        {
                            try
                            {
                                view.DownloadFile(task);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                        }).ContinueWith((x) =>
                        {
                            task.ProcessBar.ShowNotify();
                        });
                    }
                }
                else//普通页下载文件操作
                {
                    //未选中任何一行
                    if (this.AllFile.SelectedItems.Count == 0)
                    {
                        throw new Exception("至少选择一项文件");
                    }

                    string selectedPath = null;
                    if (this.pathSelector.ShowDialog(this) == DialogResult.OK)
                    {
                        selectedPath = this.pathSelector.SelectedPath;
                        main.SwitchPage(2);
                    }
                    else
                    {
                        return;
                    }

                    //遍历选中的条目
                    foreach (ListViewItem item in this.AllFile.SelectedItems)
                    {
                        //获取文件描述
                        FileDescribe des = item.Tag as FileDescribe;
                        //创建传输任务
                        TransTask task = new TransTask(des, false, FileHelper.GetPath(curPath), selectedPath, des.Size, main.trans);
                        task.AutoRename();
                        task.IsRoot = true;//设置为根任务
                        task.Status = TaskStatus.Start;
                        //创建进度条
                        main.trans.AddProcessBar(task);
                        //添加历史记录
                        main.trans.history.transTasks.Add(task);
                        //执行下载  
                        Task.Run(() =>
                        {
                            try
                            {
                                if (des.Type == FileType.Folder)//判断是否是文件夹,文件夹有自己的下载方法
                                {
                                    task.ProcessBar.tip.Text = "正在计算文件夹";
                                    view.CreateDownloadSubTask(new LinkedList<string>(curPath), task);
                                    task.ProcessBar.subtask.Text = $"({task.CompletedTaskCount}/{task.SubTaskCount})";
                                    view.DownloadFolder(task);

                                    //结束根任务
                                    task.EndTask();
                                }
                                else
                                {
                                    view.DownloadFile(task);
                                }
                            }
                            catch (Exception) { }
                        }).ContinueWith((x) =>
                        {
                            task.ProcessBar.ShowNotify();
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                ShowInfoTip(ex.Message);
            }
        }
        #endregion

        #region 上传文件
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upload_Click(object sender, EventArgs e)
        {
            if (this.fileSelector.ShowDialog(this) == DialogResult.OK)
            {
                main.SwitchPage(4);
                for (int i = 0; i < this.fileSelector.FileNames.Count; i++)
                {
                    try
                    {
                        Console.WriteLine(this.fileSelector.SelectPath + "/" + this.fileSelector.FileNames[i]);
                        //获取依赖类
                        DirectoryInfo info = new DirectoryInfo(this.fileSelector.SelectPath + "/" + this.fileSelector.FileNames[i]);
                        //创建任务
                        FileDescribe des = new FileDescribe(info);
                        TransTask task = new TransTask(des, true, info.FullName, FileHelper.GetPath(curPath), des.Size, main.trans);
                        //重名判断,并修改文件名
                        task.AutoRename();
                        //为目录时创建目录
                        if (des.Type == FileType.Folder)
                        {
                            view.CreateFolder(task.TargetPath);
                        }

                        //设置任务状态
                        task.IsRoot = true;
                        task.Status = TaskStatus.Start;
                        //创建进度条
                        main.trans.AddProcessBar(task);
                        //添加历史记录
                        main.trans.history.transTasks.Add(task);

                        //执行任务
                        Task.Run(() =>
                        {
                            try
                            {
                                if (des.Type == FileType.Folder)
                                {
                                    task.ProcessBar.tip.Text = "正在计算文件夹";
                                    view.CreateUploadSubTask(info.FullName, task);
                                    task.ProcessBar.subtask.Text = $"({task.CompletedTaskCount}/{task.SubTaskCount})";
                                    task.ProcessBar.second = 0;
                                    view.UploadFolder(task);

                                    //结束根任务
                                    task.EndTask();
                                }
                                else
                                {
                                    view.UploadFile(task);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                                ShowInfoTip(ex.Message);
                                task.ProcessBar.tip.Text = ex.Message;
                            }
                        }).ContinueWith((x) =>
                        {
                            task.ProcessBar.ShowNotify();
                        });
                    }
                    catch (Exception)
                    {
                        ShowInfoTip("获取本地文件失败");
                    }
                }
            }
        }

        /// <summary>
        /// 上传快捷菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 上传ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upload_Click(null, null);
        }
        #endregion

        #region 搜索
        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    view.FindFile("", this.find.Text, this.find);

                    //显示结果
                    AdjustComboBoxDropDownListWidth(this.find);
                    this.find.DroppedDown = true;
                    Cursor.Current = Cursors.IBeam;
                    Cursor = Cursors.Default;
                    ShowSuccessTip("查询成功");
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            });
        }

        /// <summary>
        /// 调整combox宽度
        /// </summary>
        /// <param name="comboBox"></param>
        private void AdjustComboBoxDropDownListWidth(object comboBox)
        {
            Graphics g = null;
            Font font = null;
            try
            {
                ComboBox senderComboBox = null;
                if (comboBox is ComboBox)
                    senderComboBox = (ComboBox)comboBox;
                else if (comboBox is ToolStripComboBox)
                    senderComboBox = ((ToolStripComboBox)comboBox).ComboBox;
                else
                    return;

                int width = senderComboBox.Width;
                g = senderComboBox.CreateGraphics();
                font = senderComboBox.Font;

                //checks if a scrollbar will be displayed.
                //If yes, then get its width to adjust the size of the drop down list.
                int vertScrollBarWidth =
                    (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

                int newWidth;
                foreach (object s in senderComboBox.Items)  //Loop through list items and check size of each items.
                {
                    if (s != null)
                    {
                        newWidth = (int)g.MeasureString(s.ToString().Trim(), font).Width
                            + vertScrollBarWidth;
                        if (width < newWidth)
                            width = newWidth;   //set the width of the drop down list to the width of the largest item.
                    }
                }
                senderComboBox.DropDownWidth = width;
            }
            catch
            { }
            finally
            {
                if (g != null)
                    g.Dispose();
            }
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void find_MouseClick(object sender, MouseEventArgs e)
        {
            this.find.Text = "";
        }

        /// <summary>
        /// 跳转所选文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void find_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.find.Text.StartsWith("[文件]"))
            {
                string info = this.find.Text.Replace("[文件]", "");
                view.CreateView(AllFile,path.Text =  info.Replace(Path.GetFileName(info), ""));
                FileHelper.PutPath(curPath,info);
                autoReload = false;
                AllFile.Items[Path.GetFileName(this.find.Text)].Selected = true;
                AllFile.Items[Path.GetFileName(this.find.Text)].Checked = true;
            }
        }

        /// <summary>
        /// 搜索快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void find_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit_Click(null, null);
            }
        }
        #endregion
    }
}
