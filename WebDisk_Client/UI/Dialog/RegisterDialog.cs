using Sunny.UI;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.BLL;
using WebDisk_Client.Model;

namespace WebDisk_Client.UI
{
    public partial class RegisterDialog : UIForm
    {
        UserManager manager = new UserManager();
        LoginDialog login;

        public RegisterDialog(LoginDialog login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Register_Click(object sender, EventArgs e)
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
                        this.Register.Text = "提交中...";
                        this.Register.Enabled = false;
                    }));
                
                    User user = new User();
                    user.UserName = this.UserName.Text.Trim();
                    user.Password = this.Password.Text.Trim();
                    user.Mail = this.Mail.Text.Trim();

                    if (manager.AddUser(user))
                    {
                        this.Invoke(new Action(() =>
                        {
                            ShowInfoDialog("提示", "注册成功", UIStyle.Green, false);
                            login.UserName.Text = this.UserName.Text;
                            login.Show();
                            this.Hide();
                        }));
                    }
                    else
                    {
                        ShowErrorTip("注册失败");
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.Message);
                    if (!this.IsHandleCreated)
                    {
                        return;
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.Register.Text = "注册";
                        this.Register.Enabled = true;
                    }));
                }
            });
        }

        private void RegisterDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private bool Check(bool ignoreCode)
        {
            this.UserName.Text = this.UserName.Text.Trim();
            this.Password.Text = this.Password.Text.Trim();
            this.Passwordd.Text = this.Passwordd.Text.Trim();
            this.Mail.Text = this.Mail.Text.Trim();
            this.CheckCode.Text = this.CheckCode.Text.Trim();

            if (!ignoreCode)
            {
                if (this.CheckCode.Text == "")
                {
                    ShowWarningTip("验证码不能为空");
                    return false;
                }
                else if (!(this.CheckCode.Tag as VerificationCode).CheckCode(this.CheckCode.Text, this.Mail.Text))
                {
                    ShowWarningTip("验证码输入错误");
                    return false;
                }
            }

            if (this.UserName.Text == "")
            {
                ShowWarningTip("用户名不能为空");
                return false;
            }
            else if (!Regex.IsMatch(this.UserName.Text, "^[a-zA-Z0-9_]{6,}$"))
            {
                ShowWarningTip("账号格式不正确");
                return false;
            }
            else if (manager.UserIsExist(this.UserName.Text))
            {
                ShowWarningTip("该用户已存在");
                this.Invoke(new Action(() =>
                {
                    this.UserName.Text = "";
                }));
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
            else if (this.Passwordd.Text != this.Password.Text)
            {
                ShowWarningTip("两次密码输入不一致");
                return false;
            }
            else if (this.Mail.Text == "")
            {
                ShowWarningTip("邮箱不能为空");
                return false;
            }
            else if (!Regex.IsMatch(this.Mail.Text, "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$"))
            {
                ShowWarningTip("邮箱格式不正确");
                return false;
            }
            else if (manager.UserIsExist(this.Mail.Text))
            {
                ShowWarningTip("邮箱已存在");
                this.Invoke(new Action(() =>
                {
                    this.Mail.Text = "";
                }));
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SendCode_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() =>
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
                        VerificationCode code = new VerificationCode(this.UserName.Text, this.Mail.Text, "用户注册", 300);
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
                });
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
        }

        private int second = 30;
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
