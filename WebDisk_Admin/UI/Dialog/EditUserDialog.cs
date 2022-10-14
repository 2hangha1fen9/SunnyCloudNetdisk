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

namespace WebDisk_Admin.UI
{
    public partial class EditUserDialog : UIForm
    {
        private UserManager manager = new UserManager();
        private DataSet set;
        private bool editMode;
        private string userName;
        private User user;

        public EditUserDialog(string userName,DataSet set,bool editMode)
        {
            InitializeComponent();
            this.userName = userName;
            this.set = set;
            this.editMode = editMode;
        }
        public EditUserDialog(DataSet set, bool editMode)
        {
            InitializeComponent();
            this.set = set;
            this.editMode = editMode;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            Task.Run(() => 
            {
                try
                {
                    if (editMode)
                    {
                        user = manager.GetUser(userName);

                        this.Reset.Visible = false;
                        this.UserName.Enabled = false;
                        this.UserName.Text = user.UserName;
                        this.Password.Text = user.Password;
                        this.Enable.Checked = user.Status == 1 ? true : false;
                        this.Unable.Checked = user.Status == 0 ? true : false;
                        this.Mail.Text = user.Mail;
                        this.ULBandwidth.IntValue = user.ULBandwidth;
                        this.DLBandwidth.IntValue = user.DLBandwidth;
                        this.QuotaSize.IntValue = (int)user.QuotaSize;
                        this.QuotaFiles.IntValue = user.QuotaFiles;

                        if (this.ULBandwidth.IntValue == 0)
                        {
                            this.ULFree.Checked = true;
                        }
                        if (this.DLBandwidth.IntValue == 0)
                        {
                            this.DLFree.Checked = true;
                        }
                        if (this.QuotaSize.IntValue == 0)
                        {
                            this.SizeFree.Checked = true;
                        }
                        if (this.QuotaFiles.IntValue == 0)
                        {
                            this.CountFree.Checked = true;
                        }

                        this.Text = $"正在编辑:{this.UserName.Text} 的信息";
                    }
                    else
                    {
                        this.UserName.Enabled = true;
                        this.Reset.Visible = true;
                        this.ULFree.Checked = true;
                        this.DLFree.Checked = true;
                        this.QuotaSize.IntValue = 5120;
                        this.CountFree.Checked = true;
                        this.Text = "添加用户";
                    }
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
                    this.Submit.Text = "提交中...";
                    this.Submit.Enabled = false;
                
                    if (editMode)
                    {
                        user.UserName = this.UserName.Text.Trim();
                        user.Password = this.Password.Text.Trim();
                        user.Status = this.Enable.Checked ? 1 : 0;
                        user.Mail = this.Mail.Text.Trim();
                        user.ULBandwidth = this.ULBandwidth.IntValue;
                        user.DLBandwidth = this.DLBandwidth.IntValue;
                        user.QuotaSize = this.QuotaSize.IntValue;
                        user.QuotaFiles = this.QuotaFiles.IntValue;

                        if (manager.UpdateUser(user))
                        {
                            ShowSuccessTip("更新成功");
                            manager.GetAllUsers(set);
                            this.Hide();
                        }
                        else
                        {
                            ShowErrorTip("更新失败");
                        }
                    }
                    else
                    {
                        User newUser = new User();

                        newUser.UserName = this.UserName.Text.Trim();
                        newUser.Password = this.Password.Text.Trim();
                        newUser.Status = this.Enable.Checked ? 1 : 0;
                        newUser.Mail = this.Mail.Text.Trim();
                        newUser.ULBandwidth = this.ULBandwidth.IntValue;
                        newUser.DLBandwidth = this.DLBandwidth.IntValue;
                        newUser.QuotaSize = this.QuotaSize.IntValue;
                        newUser.QuotaFiles = this.QuotaFiles.IntValue;

                        if (manager.AddUser(newUser))
                        {
                            if (ShowAskDialog("提示", "添加成功,是否继续添加?", UIStyle.Green, false))
                            {
                                this.UserName.Clear();
                                this.Password.Clear();
                                this.Mail.Clear();
                            }
                            else
                            {
                                this.Hide();
                            }
                            manager.GetAllUsers(this.set);
                        }
                        else
                        {
                            ShowErrorTip("添加失败");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                }
            }).ContinueWith((x) =>
            {
                this.Submit.Text = "提交";
                this.Submit.Enabled = true;
            });
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.UserName.Clear();
            this.Password.Clear();
            this.Enable.Checked = true;           
            this.Mail.Clear();
            this.ULFree.Checked = true;
            this.DLFree.Checked = true;
            this.QuotaSize.IntValue = 5120;
            this.CountFree.Checked = true;
        }

        private void ULFree_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ULFree.Checked)
            {
                this.ULBandwidth.Enabled = false;
                this.ULBandwidth.Text = "无限制";
            }
            else
            {
                this.ULBandwidth.Enabled = true;
                this.ULBandwidth.IntValue = 0;
            }
        }

        private void DLFree_CheckedChanged(object sender, EventArgs e)
        {
            if (this.DLFree.Checked)
            {
                this.DLBandwidth.Enabled = false;
                this.DLBandwidth.Text = "无限制";
            }
            else
            {
                this.DLBandwidth.Enabled = true;
                this.DLBandwidth.IntValue = 0;
            }
        }

        private void SizeFree_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SizeFree.Checked)
            {
                this.QuotaSize.Enabled = false;
                this.QuotaSize.Text = "无限制";
            }
            else
            {
                this.QuotaSize.Enabled = true;
                this.QuotaSize.IntValue = 0;
            }
        }

        private void CountFree_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CountFree.Checked)
            {
                this.QuotaFiles.Enabled = false;
                this.QuotaFiles.Text = "无限制";
            }
            else
            {
                this.QuotaFiles.Enabled = true;
                this.QuotaFiles.IntValue = 0;
            }
        }
    }
}
