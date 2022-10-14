using Sunny.UI;
using System;
using System.Net;
using System.Threading.Tasks;
using WebDisk_Client.BLL;
using WebDisk_Client.Model;
using WebDisk_Client.UI.Dialog;

namespace WebDisk_Client.UI
{
    public partial class LoginDialog : UIForm
    {
        private UserManager manager = new UserManager();
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                   
                    if (!Check())
                    {
                        return;
                    }
                    if (!this.IsHandleCreated)
                    {
                        return;
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.Login.Text = "登录中...";
                        this.Login.Enabled = false;
                    }));


                    User temp = new User();
                    temp.UserName = this.UserName.Text.Trim();
                    temp.Password = this.Password.Text;

                    User user = manager.UserLogin(temp);
                    if (user != null)
                    {
                        user.Credential = new NetworkCredential(user.UserName, user.Password);
                        this.Invoke(new Action(() =>
                        {
                            this.Hide();
                            new MainForm(user).Show();                          
                        }));
                    }
                }
                catch (Exception ex)
                {
                    ShowInfoTip(ex.Message);
                    this.Invoke(new Action(() =>
                    {
                        this.Login.Text = "登录";
                        this.Login.Enabled = true;
                    }));
                }
            });
        }

        private void Register_Click(object sender, EventArgs e)
        {
            new RegisterDialog(this).Show();
            this.Hide();
        }

        private bool Check()
        {
            this.UserName.Text = this.UserName.Text.Trim();
            this.Password.Text = this.Password.Text.Trim();

            if (this.UserName.Text == "")
            {
                ShowWarningTip("用户名不能为空");
                return false;
            }
            else if (this.Password.Text == "")
            {
                ShowWarningTip("密码不能为空");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            new ForgetPasswordDialog(this).Show();
            this.Hide();
        }
    }
}
