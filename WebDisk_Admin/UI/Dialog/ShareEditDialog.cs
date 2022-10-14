using Sunny.UI;
using System;
using System.Data;
using System.Threading.Tasks;
using WebDisk_Admin.BLL;
using WebDisk_Admin.Model;

namespace WebDisk_Admin.UI.Dialog
{
    public partial class ShareEditDialog : UIForm
    {
        private string code;
        private ShareDescirbe describe;
        private ShareManager manager = new ShareManager();
        private DataSet set;
        public ShareEditDialog(string code, DataSet set)
        {
            InitializeComponent();
            this.code = code;
            this.set = set;
        }

        private void ShareEditDialog_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    describe = manager.GetShareInfo(code);
                    if (!this.IsHandleCreated)
                    {
                        return;
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.Count.IntValue = describe.MaxVisit;
                        this.EndTime.Value = describe.EndTime;
                        this.Text = describe.FileDescribe.Name;
                        if (describe.MaxVisit == 0)
                        {
                            this.Count.Text = "无限制";
                            this.Free.Checked = true;
                            this.Count.Enabled = false;
                        }
                        if (describe.EndTime.CompareTo(new DateTime(1900, 01, 01, 00, 00, 00)) == 0)
                        {
                            this.EndTime.Text = "永久有效";
                            this.EndTime.Enabled = false;
                            this.Never.Checked = true;
                        }
                    }));
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            });
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
                        this.Submit.Text = "提交中...";
                        this.Submit.Enabled = false;
                    }));                    
                    if (this.EndTime.Value.CompareTo(DateTime.Now) < 0 && (this.EndTime.Value.CompareTo(new DateTime(1900, 01, 01, 00, 00, 00)) != 0))
                    {
                        throw new Exception("结束日期不可以小于当前日期");
                    }

                    describe.EndTime = this.EndTime.Value;
                    describe.MaxVisit = this.Count.IntValue;
                    if (manager.UpdateShareInfo(describe))
                    {
                        manager.GetShareInfo(set);
                        this.Hide();
                        ShowAskDialog("提示", "修改成功", UIStyle.Green, false);
                    }
                }
                catch (Exception ex)
                {
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
                    this.Submit.Text = "修改";
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
