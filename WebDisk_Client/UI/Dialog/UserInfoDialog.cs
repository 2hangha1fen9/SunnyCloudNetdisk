using Sunny.UI;
using System;
using WebDisk_Client.Model;
using WebDisk_Client.Utils;

namespace WebDisk_Client.UI.Dialog
{
    public partial class UserInfoDialog : UIForm
    {
        private User user;
        public UserInfoDialog(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UserInfoDialog_Load(object sender, EventArgs e)
        {
            this.UserName.Text = user.UserName;
            this.Status.Text = user.Status == 1 ? "可用" : "不可用";
            this.Mail.Text = user.Mail;
            if(user.QuotaSize == 0)
            {
                this.Capacity.Text = $"{FileHelper.UnitConversion(HomePanel.size)}/无限制";
            }
            else
            {
                this.Capacity.Text = $"{FileHelper.UnitConversion(HomePanel.size)}/{FileHelper.UnitConversion(user.QuotaSize * 1024 * 1024)}";
            }
            

            if (user.QuotaFiles == 0)
            {
                this.FileCount.Text = $"{HomePanel.count}/无限制";
            }
            else
            {
                this.FileCount.Text = $"{HomePanel.count}/{user.QuotaFiles}";
            }
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            new ForgetPasswordDialog(user).ShowDialog();
        }

        private void Mail_Click(object sender, EventArgs e)
        {

            new ChangeMailDialog(user).ShowDialog();
        }
    }
}
