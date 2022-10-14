using Sunny.UI;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.BLL;
using WebDisk_Client.Model;

namespace WebDisk_Client.UI.Dialog
{
    public partial class ForgetPasswordDialog : UIForm
    {
        private UserManager manager = new UserManager();
        private LoginDialog login;
        private User user;

        public ForgetPasswordDialog(LoginDialog login)
        {
            InitializeComponent();
            this.Account.Text = login.UserName.Text;
            this.login = login;           
        }
        public ForgetPasswordDialog(User user)
        {
            InitializeComponent();
            this.user = user;
            this.Account.Text = user.UserName;
            this.Account.Tag = user;
            this.Account.Enabled = false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    if (!Check(false))
                    {
                        return;
                    }
                    if (!this.IsHandleCreated)
                    {
                        return;
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.Submit.Text = "提交中...";
                        this.Submit.Enabled = false;
                    }));

                    user.Password = this.Password.Text;

                    if (manager.UpdateUser(user))
                    {
                        this.Invoke(new Action(() =>
                        {
                            ShowInfoDialog("提示", "修改密码成功", UIStyle.Green, false);
                            if (login != null)
                            {
                                login.UserName.Text = this.Account.Text;
                                login.Show();
                            }
                            this.Hide();
                        }));

                    }
                    else
                    {
                        ShowErrorTip("修改失败");
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                    this.Invoke(new Action(() =>
                    {
                        this.Submit.Text = "提交";
                        this.Submit.Enabled = true;
                    }));
                }
            });
        }

        private bool Check(bool ignoreCode)
        {
            this.Account.Text = this.Account.Text.Trim();
            this.CheckCode.Text = this.CheckCode.Text.Trim();
            this.Password.Text = this.Password.Text.Trim();

            if ((this.Account.Tag = manager.GetUser(this.Account.Text)) == null)
            {
                ShowErrorTip("该用户不存在");
                return false;
            }
            if(user == null)
            {
                user = this.Account.Tag as User;
            }

            if (!ignoreCode)
            {
                if (this.CheckCode.Text == "")
                {
                    ShowWarningTip("验证码不能为空");
                    return false;
                }
                else if (!(this.CheckCode.Tag as VerificationCode).CheckCode(this.CheckCode.Text, (this.Account.Tag as User).Mail))
                {
                    ShowWarningTip("验证码输入错误");
                    return false;
                }
                else if (this.Password.Text == "")
                {
                    ShowWarningTip("密码不能为空");
                    return false;
                }
                else if (!Regex.IsMatch(this.Password.Text, "^[a-zA-Z0-9_]{6,}$"))
                {
                    ShowWarningTip("密码格式不正确");
                    return false;
                }
            }
            return true;
        }

        private void ForgetPasswordDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (login != null)
            {
                login.Show();
            }
            this.Hide();
        }

        private int second = 30;
        private void SendCode_Click(object sender, EventArgs e)
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
                        second = 30;
                        this.CheckCode.Text = "";
                        this.SendCode.Text = $"重试 ({second})";
                        this.SendCode.Enabled = false;
                        this.timer1.Enabled = true;
                    }));
                    if (Check(true))
                    {
                        VerificationCode code = new VerificationCode((this.Account.Tag as User).UserName, (this.Account.Tag as User).Mail, "修改密码", 300);
                        this.CheckCode.Tag = code;
                        code.SendCode();
                    }
                    else
                    {
                        if (!this.IsHandleCreated)
                        {
                            return;
                        }    
                        this.Invoke(new Action(() =>
                        {
                            second = 30;
                            this.CheckCode.Text = "";
                            this.SendCode.Text = $"获取验证码";
                            this.SendCode.Enabled = true;
                            this.timer1.Enabled = false;
                        }));
                    }
                }
                catch (Exception ex)
                {
                    if (!this.IsHandleCreated)
                    {
                        return;
                    }
                    this.Invoke(new Action(() =>
                    {
                        second = 30;
                        this.CheckCode.Text = "";
                        this.SendCode.Text = $"获取验证码";
                        this.SendCode.Enabled = true;
                        this.timer1.Enabled = false;
                        ShowErrorTip(ex.Message);
                    }));
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (!this.IsHandleCreated)
                {
                    return;
                }
                this.Invoke(new Action(() =>
                {
                    this.SendCode.Text = $"重试 ({--second})";
                    if (second == 0)
                    {
                        this.SendCode.Text = "获取验证码";
                        this.SendCode.Enabled = true;
                        this.timer1.Enabled = false;
                    }
                }));
            });
        }
    }
}
