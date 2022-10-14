using Sunny.UI;
using System;
using System.Net;
using System.Threading.Tasks;
using WebDisk_Admin.BLL;
using WebDisk_Admin.Model;

namespace WebDisk_Admin.UI
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
                        user.Credential = new NetworkCredential(user.UserName,user.Password);
                        this.Invoke(new Action(() =>
                        {
                            new MainForm(user).Show();
                            this.Hide();
                        }));
                    }
                }
                catch (Exception ex)
                {
                    ShowInfoTip(ex.Message);
                }
            }).ContinueWith((x) => 
            {
                this.Invoke(new Action(() =>
                {
                    this.Login.Text = "登录";
                    this.Login.Enabled = true;
                }));                
            });       
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
    }
}
