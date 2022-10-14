using Sunny.UI;
using System;
using System.Windows.Forms;
using WebDisk_Admin.BLL;
using WebDisk_Admin.Model;
using WebDisk_Admin.Properties;
using WebDisk_Admin.Utils;

namespace WebDisk_Admin.UI
{
    public partial class MainForm : UIHeaderMainFrame
    {
        public User user;
        public TransPanel trans;
        public HomePanel home;
        public SharePanel share;
        public SettingsDialog settings;
        public UserPanel userEditor;
        public ShareManager manager = new ShareManager();
        
        public MainForm(User u)
        {
            InitializeComponent();
            Header.TabControl = MainTabControl;
            //设置选项卡图标
            Header.SetNodeSymbol(Header.Nodes[0], 62140, 45);
            Header.SetNodeSymbol(Header.Nodes[1], 57609, 45);
            Header.SetNodeSymbol(Header.Nodes[2], 57578, 40);
            Header.SetNodeSymbol(Header.Nodes[3], 43, 45);

            user = u;
            this.UserName.Text = user.UserName;
            settings = new SettingsDialog();            
            userEditor = new UserPanel(this);
            share = new SharePanel();
            home = new HomePanel(this);
            trans = new TransPanel(this);
            share.Show();
            home.Show();
            trans.Show();

            AddPage(userEditor, 1);
            Header.SetNodePageIndex(Header.Nodes[0], 1);
            AddPage(share, 2);
            Header.SetNodePageIndex(Header.Nodes[1], 2);
            AddPage(home, 3);
            Header.SetNodePageIndex(Header.Nodes[2], 3);
            AddPage(trans, 4);
            Header.SetNodePageIndex(Header.Nodes[3], 4);
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {       
            if(flag)
            {
                trans.AllStop_Click(null, null);
                XmlHelper.ObjectToXml(trans.history, user.UserName);
            }
        }

        private bool flag = false;
        private bool exit = false;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exit)
            {
                Application.Exit();
                return;
            }
            if(Settings.Default.closeAction)
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
    }
}
