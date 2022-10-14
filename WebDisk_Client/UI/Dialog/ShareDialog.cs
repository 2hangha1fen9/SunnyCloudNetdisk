using Sunny.UI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.BLL;
using WebDisk_Client.Model;
using static System.Windows.Forms.ListView;

namespace WebDisk_Client.UI
{
    public partial class ShareDialog : UIForm
    {
        private User user;
        private SelectedListViewItemCollection items;
        private ShareManager shareManager = new ShareManager();
        public ShareDialog(User user, SelectedListViewItemCollection items)
        {
            InitializeComponent();
            this.user = user;
            this.items = items;
        }

        private void ShareDialog_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem i in items)
                {
                    this.listView1.Items.Add((ListViewItem)i.Clone());
                }
                this.EndTime.Value = DateTime.Now.AddDays(1);
            }
            catch (Exception)
            {
                ShowErrorTip("获取信息失败");
            }

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    if (!this.IsHandleCreated)
                    {
                        return;
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.Submit.Text = "处理中...";
                        this.Submit.Enabled = false;
                    }));
                    
                    if (this.EndTime.Value.CompareTo(DateTime.Now) < 0 && (this.EndTime.Value.CompareTo(new DateTime(1900, 01, 01, 00, 00, 00)) != 0))
                    {
                        throw new Exception("结束日期不可以小于当前日期");
                    }
                    foreach (ListViewItem item in this.listView1.Items)
                    {
                        shareManager.AddShareInfo(item.Tag as FileDescribe, user, this.EndTime.Value, this.Count.IntValue);
                    }
                    this.Hide();
                    ShowAskDialog("提示", "创建分享成功,可以在分享面板中查看分享码", UIStyle.Green, false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                if (!this.IsHandleCreated)
                {
                    return;
                }
                this.Invoke(new Action(() =>
                {
                    this.Submit.Text = "分享";
                    this.Submit.Enabled = true;
                }));              
            });
        }

        private void Free_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Free.Checked)
            {
                this.Count.Enabled = false;
                this.Count.Text = "无限制";
            }
            else
            {
                this.Count.Enabled = true;
                this.Count.IntValue = 1;
            }
        }

        private void Never_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Never.Checked)
            {
                this.EndTime.Enabled = false;
                this.EndTime.Value = new DateTime(1900, 01, 01, 00, 00, 00);
                this.EndTime.Text = "永久有效";
            }
            else
            {
                this.EndTime.Enabled = true;
                this.EndTime.Value = DateTime.Now.AddDays(1);
            }
        }
    }
}
