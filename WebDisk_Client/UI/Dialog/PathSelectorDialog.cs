using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.BLL;
using WebDisk_Client.Model;
using WebDisk_Client.Utils;

namespace WebDisk_Client.UI
{
    public partial class PathSelectorDialog : UIForm
    {
        #region 初始化
        //当前路径
        public LinkedList<string> curPath = new LinkedList<string>();
        //操作虚拟文件夹视图对象
        public static FileListView view;
        //是否自动加载页面
        public static bool autoReload = true;
        //当前用户
        private User user;
        //分享管理
        private ShareManager manager = new ShareManager();

        private UITextBox text;
        private UILabel label;

        public PathSelectorDialog(User user, UITextBox text)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //取消线程调用检查      
            this.全部文件.BackColor = System.Drawing.Color.White;
            this.fileSelector.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.user = user;
            view = new FileListView(user);
            this.text = text;
        }
        public PathSelectorDialog(User user, UILabel label)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //取消线程调用检查      
            this.全部文件.BackColor = System.Drawing.Color.White;
            this.fileSelector.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.user = user;
            view = new FileListView(user);
            this.label = label;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeForm_Load(object sender, EventArgs e)
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
                    }
                    else
                    {
                        autoReload = true;
                    }
                }
                catch (Exception ex)
                {
                    ShowInfoTip(ex.Message);
                }
            }).ContinueWith((x) => //加载完毕后取消加载图标 
            {
                this.loading.Visible = false;
            });
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
                    ShowInfoTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
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
                this.loading.Visible = true;
                this.back.Enabled = false;
                try
                {
                    if (curPath.Count > 0)
                    {
                        curPath.RemoveLast();
                        view.CreateView(this.AllFile, curPath, this.path);
                    }
                }
                catch (Exception ex)
                {
                    ShowInfoTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
                this.back.Enabled = true;
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
                this.loading.Visible = true;
                try
                {
                    this.curPath.Clear();
                    this.path.Text = "";
                    view.CreateView(this.AllFile, "");
                }
                catch (Exception ex)
                {
                    ShowInfoTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
            });
        }

        /// <summary>
        /// 打开操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((this.AllFile.SelectedItems[0].Tag as FileDescribe).Type == FileType.Folder)
            {
                listView1_MouseDoubleClick(null, null);
            }
        }

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
                    //刷新页面
                    flush_Click(null, null);
                    ShowSuccessTip("移动成功");
                }
            }
            catch (Exception)
            {
                ShowInfoTip("移动文件失败");
                this.移动ToolStripMenuItem.Text = "移动";
                if (this.fileOperator.Tag != null)
                {
                    this.fileOperator.Tag = null;
                }
            }
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
                }
                catch (Exception ex)
                {
                    ShowInfoTip(ex.Message);
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
                    ShowInfoTip(ex.Message);
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
                    ShowInfoTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
            });
        }

        /// <summary>
        /// 新建文件夹提示框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createFolder_Click(object sender, EventArgs e)
        {
            ShowInfoTip("输入文件夹名称并按回车键提交");
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
                            ShareDescirbe share = manager.GetShareInfo(user.UserName, (item.Tag as FileDescribe).Name);
                            if (share != null)
                            {
                                manager.DeleteShareInfo(share.Code);
                            }
                        }
                        ShowSuccessTip("删除成功");
                    }
                }
                catch (Exception ex)
                {
                    ShowInfoTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.loading.Visible = false;
            });
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
                    this.AllFile.SelectedItems[0].Text = curName;
                    ShowInfoTip(ex.Message);
                }
            });
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
                this.AllFile.SelectedItems[0].BeginEdit();
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
            if (this.AllFile.SelectedItems.Count != 0)
            {
                this.AllFile.SelectedItems[0].BeginEdit();
            }
        }

        /// <summary>
        /// 开启编辑模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            curName = this.AllFile.SelectedItems[0].Text;
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
            this.AllFile.View = View.LargeIcon;
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
            this.AllFile.View = View.SmallIcon;
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
            this.AllFile.View = View.Details;
            view.AutoResizeColumnWidth(this.AllFile);
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
            this.AllFile.View = View.List;
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
            this.AllFile.View = View.Tile;
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
            this.fileOperator.Items["新建文件夹ToolStripMenuItem"].Visible = true;
            if (this.AllFile.SelectedItems.Count == 0)
            {
                this.fileOperator.Items["打开ToolStripMenuItem"].Visible = false;
                this.fileOperator.Items["重命名ToolStripMenuItem"].Visible = false;
                this.fileOperator.Items["删除ToolStripMenuItem"].Visible = false;
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
                this.fileOperator.Items["打开ToolStripMenuItem"].Visible = true;
                this.fileOperator.Items["重命名ToolStripMenuItem"].Visible = true;
                this.fileOperator.Items["删除ToolStripMenuItem"].Visible = true;
                this.fileOperator.Items["移动ToolStripMenuItem"].Visible = true;
            }
        }
        #endregion

        private void Enter_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                text.Text = FileHelper.GetPath(curPath);
            }
            if (label != null)
            {
                label.Text = FileHelper.GetPath(curPath);
            }
            this.Hide();
        }
    }
}
