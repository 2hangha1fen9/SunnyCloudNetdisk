using Sunny.UI;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.BLL;
using WebDisk_Client.UI.Dialog;

namespace WebDisk_Client.UI
{
    public partial class SharePanel : UIPage
    {
        private MainForm main;
        private ShareManager manager = new ShareManager();

        public SharePanel(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            this.ShareTable.AutoGenerateColumns = false;
        }

        private void SharePanel_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    manager.GetShareInfo(this.DataSet, main.user);
                    this.ShareTable.DataSource = this.DataSet.Tables["Share"];
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            });
        }

        private void 复制分享码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyCode_Click(null, null);
        }

        private void 修改分享信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditShare_Click(null,null);
        }

        private void 取消分享ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelShare_Click(null,null);
        }

        private void ShareTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           
        }

        private void ShareTable_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Modifiers.CompareTo(Keys.Control) == 0 && e.KeyCode == Keys.C)
            {
                复制分享码ToolStripMenuItem_Click(null,null);
            }
        }

        private void EditShare_Click(object sender, EventArgs e)
        {
            if (this.ShareTable.SelectedRows.Count == 0)
            {
                ShowWarningTip("至少选择一项记录");
                return;
            }
            new ShareEditDialog(this.ShareTable.SelectedRows[0].Cells["Code"].Value.ToString(), this.DataSet, main.user).ShowDialog(this);
        }

        private void DelShare_Click(object sender, EventArgs e)
        {
            if (this.ShareTable.SelectedRows.Count == 0)
            {
                ShowWarningTip("至少选择一项记录");
                return;
            }
            Task.Run(() =>
            {
                try
                {
                    if (!ShowAskDialog("提示", $"是否取消分享?", UIStyle.Red, false))
                    {
                        return;
                    }
                    foreach (DataGridViewRow row in this.ShareTable.SelectedRows)
                    {
                        manager.DeleteShareInfo(row.Cells["Code"].Value.ToString());
                    }
                    manager.GetShareInfo(this.DataSet, main.user);
                    ShowSuccessTip("取消成功");
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            });
        }

        private void CopyCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ShareTable.SelectedRows.Count == 0)
                {
                    ShowWarningTip("至少选择一项记录");
                    return;
                }
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow row in this.ShareTable.SelectedRows)
                {
                    sb.Append(row.Cells["Code"].Value.ToString() + ",");
                }
                sb.Remove(sb.Length - 1, 1);
                Clipboard.SetText(sb.ToString());
                ShowSuccessTip("分享码已复制到剪贴板");
            }
            catch (Exception ex)
            {
                ShowErrorTip(ex.Message);
            }
        }
    }
}
