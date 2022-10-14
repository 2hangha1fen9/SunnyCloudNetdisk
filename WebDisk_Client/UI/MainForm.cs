using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.BLL;
using WebDisk_Client.Model;
using WebDisk_Client.Properties;
using WebDisk_Client.UI.Dialog;
using WebDisk_Client.Utils;

namespace WebDisk_Client.UI
{
    public partial class MainForm : UIHeaderMainFrame
    {
        public User user;
        public TransPanel trans;
        public HomePanel home;
        public SharePanel share;
        public SettingsDialog settings;
        public ShareManager manager = new ShareManager();

        public MainForm(User u)
        {
            InitializeComponent();
            Header.TabControl = MainTabControl;
            //设置选项卡图标
            Header.SetNodeSymbol(Header.Nodes[0], 57578, 50);
            Header.SetNodeSymbol(Header.Nodes[1], 43, 50);
            Header.SetNodeSymbol(Header.Nodes[2], 62048, 50);

            user = u;
            this.UserName.Text = user.UserName;
            settings = new SettingsDialog();
            trans = new TransPanel(this);
            home = new HomePanel(this);
            share = new SharePanel(this);
            share.Show();
            trans.Show();

            AddPage(home, 1);
            Header.SetNodePageIndex(Header.Nodes[0], 1);
            AddPage(trans, 2);
            Header.SetNodePageIndex(Header.Nodes[1], 2);
            AddPage(share, 3);
            Header.SetNodePageIndex(Header.Nodes[2], 3);
        }
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width <= 950 && this.Height <= 600)
            {
                this.Width = 950;
                this.Height = 600;
            }
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
        /// 跳转所选的结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void find_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.find.Text.StartsWith("[文件]"))
            {
                string info = this.find.Text.Replace("[文件]", "");               
                home.view.CreateView(home.AllFile, home.path.Text = info.Replace(Path.GetFileName(info), ""));
                FileHelper.PutPath(home.curPath, info);
                HomePanel.autoReload = false;
                SwitchPage(1);
                home.AllFile.Items[Path.GetFileName(this.find.Text)].Selected = true;
                home.AllFile.Items[Path.GetFileName(this.find.Text)].Checked = true;
            }
            if (this.find.Text.StartsWith("[分享]") || this.find.Text.StartsWith("[保存所有]"))
            {
                string code = this.find.Text.Substring(this.find.Text.IndexOf(':') + 1);
                new ShareSaveDialog(code, user, home).ShowDialog(this);
            }
        }

        /// <summary>
        /// 设置页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_ExtendBoxClick(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        /// <summary>
        /// 切换页面
        /// </summary>
        /// <param name="pageNum"></param>
        public void SwitchPage(int pageNum)
        {
            this.SelectPage(pageNum);
            Header.SelectedIndex = pageNum - 1;
        }

        /// <summary>
        /// 清除搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void find_MouseClick(object sender, MouseEventArgs e)
        {
            this.find.Text = "";
        }

        /// <summary>
        /// 搜索事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    ShowInfoTip("正在查询中...");
                    this.find.Items.Clear();
                    this.find.DroppedDown = true;
                    //分享文件搜索
                    string[] codes = this.find.Text.Split(',');
                    if (codes.Length != 0)
                    {
                        int count = 0;
                        foreach (string code in codes)
                        {
                            ShareDescirbe share = manager.GetShareInfoEffective(code);
                            if (share != null && share.UserName != user.UserName)
                            {
                                this.find.Items.Add($"[分享]{share.FileDescribe.Name}:{code}");
                                count++;
                            }
                        }
                        if (count > 1)
                        {
                            this.find.Items.Add($"[保存所有]SaveAll:{this.find.Text}");
                        }
                    }

                    home.view.FindFile("", this.find.Text, this.find);                   

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

        private void find_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit_Click(null, null);
            }
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            new UserInfoDialog(user).ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                trans.AllStop_Click(null, null);
                XmlHelper.ObjectToXml(trans.history, user.UserName);
            }
        }

        private bool flag = false;
        private bool exit = false;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
                return;
            }
            if (Settings.Default.closeAction)
            {
                if (flag)
                {
                    return;
                }
                if (ShowAskDialog("提示", "是否要关闭此程序,将停止一切传输", UIStyle.Gray))
                {
                    flag = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void 彻底关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit = true;
            trans.AllStop_Click(null, null);
            XmlHelper.ObjectToXml(trans.history, user.UserName);
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        public TransPanel TransPanel
        {
            get => default;
            set
            {
            }
        }
    }
}
