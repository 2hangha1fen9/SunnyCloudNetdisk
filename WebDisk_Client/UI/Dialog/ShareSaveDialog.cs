using Sunny.UI;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.BLL;
using WebDisk_Client.Model;
using WebDisk_Client.Utils;

namespace WebDisk_Client.UI.Dialog
{
    public partial class ShareSaveDialog : UIForm
    {
        private string[] codes;
        private User user;
        private ShareManager manager = new ShareManager();
        private HomePanel home;
        public ShareSaveDialog(string code, User user, HomePanel home)
        {
            InitializeComponent();
            this.codes = code.Split(',');
            this.user = user;
            this.home = home;
        }

        private void ShareSaveDialog_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.listView1.BeginUpdate();

                this.listView1.Columns.Add("文件名");
                this.listView1.Columns.Add("文件类型");
                this.listView1.Columns.Add("文件大小");
                this.listView1.Columns.Add("分享者");
                try
                {
                    foreach (string code in codes)
                    {
                        //创建文件描述对象
                        ShareDescirbe share = manager.GetShareInfoEffective(code);
                        //创建条目
                        ListViewItem item = new ListViewItem(share.FileDescribe.Name, (int)share.FileDescribe.Type);
                        item.Name = share.Code;
                        item.SubItems.Add(FileHelper.GetTypeStr(share.FileDescribe.Type));
                        item.SubItems.Add(FileHelper.UnitConversion(share.FileDescribe.Size));
                        item.SubItems.Add(share.UserName);
                        item.Tag = share;
                        this.listView1.Items.Add(item);
                    }
                    AutoResizeColumnWidth(this.listView1);

                    this.listView1.EndUpdate();
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            });
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            PathSelectorDialog pathSelector = new PathSelectorDialog(user, this.Path);
            pathSelector.Show();
        }

        private void uiButton2_Click_1(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    this.Ok.Text = "保存中...";
                    this.Ok.Enabled = false;
                    int completed = 0;
                    int fail = 0;
                    foreach (ListViewItem item in this.listView1.Items)
                    {
                        ShareDescirbe share = item.Tag as ShareDescirbe;
                        if (manager.GetShareFile(share, user, this.Path.Text))
                        {
                            completed++;
                            share.Visited++;
                            manager.UpdateShareInfo(share);
                        }
                        else
                        {
                            fail++;
                        }
                    }
                    this.Hide();
                    ShowAskDialog("提示", $"{completed} 个文件保存成功,{fail} 个文件保存失败.", fail == 0 ? UIStyle.Green : UIStyle.Orange, false);
                    home.HomeForm_Load(null, null);
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.Ok.Text = "保存";
                this.Ok.Enabled = true;
            });
        }
    }
}
