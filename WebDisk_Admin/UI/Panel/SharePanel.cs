using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Admin.BLL;
using WebDisk_Admin.Model;
using WebDisk_Admin.UI.Dialog;

namespace WebDisk_Admin.UI
{
    public partial class SharePanel : UIPage
    {
        private ShareManager manager = new ShareManager();
        public SharePanel()
        {
            InitializeComponent();
            this.ShareTable.AutoGenerateColumns = false;          
        }

        private void SharePanel_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    manager.GetShareInfo(this.DataSet);
                    this.ShareTable.DataSource = this.DataSet.Tables["Share"];
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            });
        }

        private void ShareTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

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
                    if (!ShowAskDialog("提示", $"是否删除该分享?", UIStyle.Red, false))
                    {
                        return;
                    }
                    foreach (DataGridViewRow row in this.ShareTable.SelectedRows)
                    {
                        manager.DeleteShareInfo(row.Cells["Code"].Value.ToString());
                    }
                    ShowSuccessTip("删除成功");
                    manager.GetShareInfo(this.DataSet);
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            });
        }

        private void EditShare_Click(object sender, EventArgs e)
        {
            if (this.ShareTable.SelectedRows.Count == 0)
            {
                ShowWarningTip("至少选择一项记录");
                return;
            }
            new ShareEditDialog(this.ShareTable.SelectedRows[0].Cells["Code"].Value.ToString(), this.DataSet).ShowDialog(this);
        }

        private void Find_TextChanged(object sender, EventArgs e)
        {
            DataView view = this.DataSet.Tables["Share"].DefaultView;
            view.RowFilter = $"User like '%{this.Find.Text}%' or FileName like '%{this.Find.Text}%' or Effective like '%{this.Find.Text}%' or FileType like '%{this.Find.Text}%'";
        }

        private void 编辑分享ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditShare_Click(null,null);
        }

        private void 删除分享ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelShare_Click(null,null);
        }
    }
}
