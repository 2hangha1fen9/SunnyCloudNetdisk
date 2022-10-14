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
using WebDisk_Admin.Utils;

namespace WebDisk_Admin.UI
{
    public partial class UserPanel : UIPage
    {
        private UserManager manager = new UserManager();
        private MainForm main;
        public UserPanel(MainForm main)
        {
            InitializeComponent();
            this.UserTable.AutoGenerateColumns = false;
            this.main = main;
        }

        private void UserEditorPanel_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                manager.GetAllUsers(this.DataSet);
                this.UserTable.DataSource = this.DataSet.Tables["Users"];
            });           
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            EditUserDialog add = new EditUserDialog(this.DataSet,false);
            add.Show();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if (this.UserTable.SelectedRows.Count == 0)
            {
                ShowWarningTip("至少选择一项记录");
                return;
            }
            EditUserDialog edit = new EditUserDialog(this.UserTable.SelectedRows[0].Cells["User"].Value.ToString(),this.DataSet,true);
            edit.Text = "正在编辑 " + this.UserTable.SelectedRows[0].Cells["User"].Value.ToString() + " 的用户信息";
            edit.Show();
        }

        private void DelUser_Click(object sender, EventArgs e)
        {
            if (this.UserTable.SelectedRows.Count == 0)
            {
                ShowWarningTip("至少选择一项记录");
                return;
            }
            Task.Run(() =>
            {
                try
                {
                    if (!ShowAskDialog("提示", $"是否删除该的用户信息?", UIStyle.Red, false))
                    {
                        return;
                    }
                    foreach(DataGridViewRow row in this.UserTable.SelectedRows)
                    {
                        manager.DeleteUser(row.Cells["User"].Value.ToString());
                    }
                    ShowSuccessTip("删除成功");
                    manager.GetAllUsers(this.DataSet);
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            });            
        }

        private void Find_TextChanged(object sender, EventArgs e)
        {
            DataView view = this.DataSet.Tables["Users"].DefaultView;
            view.RowFilter = $"User like '%{this.Find.Text}%' or Mail like '%{this.Find.Text}%' or status like '%{this.Find.Text}%'";
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser_Click(null,null);
        }

        private void 编辑用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser_Click(null,null);
        }

        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelUser_Click(null,null);
        }

        private void 查看文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetUserFIle_Click(null,null);
        }

        private void GetUserFIle_Click(object sender, EventArgs e)
        {
            if (this.UserTable.SelectedRows[0].Cells["User"].Value.ToString() == "Admin")
            {
                main.SwitchPage(3);
            }
            else
            {
                main.home.view.CreateView(main.home.AllFile, this.UserTable.SelectedRows[0].Cells["User"].Value.ToString());
                main.home.curPath.Clear();
                main.home.curPath.AddLast(main.home.path.Text =  this.UserTable.SelectedRows[0].Cells["User"].Value.ToString() + "/");
                HomePanel.autoReload = false;
                main.SwitchPage(3);
            }          
        }
    }
}
