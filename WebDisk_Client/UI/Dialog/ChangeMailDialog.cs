using Sunny.UI;
using System;
using System.Threading.Tasks;
using WebDisk_Client.BLL;
using WebDisk_Client.Model;

namespace WebDisk_Client.UI.Dialog
{
    public partial class ChangeMailDialog : UIForm
    {
        private UserManager manager = new UserManager();
        private User user;
        public ChangeMailDialog(User user)
        {
            InitializeComponent();
            this.user = user;
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

        private int second = 30;
        private void SendCode_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {                 
                    if (Check(true))
                    {
                        this.Invoke(new Action(() =>
                        {
                            second = 30;
                            this.CheckCode.Text = "";
                            this.SendCode.Text = $"重试 ({second})";
                            this.SendCode.Enabled = false;
                            this.timer1.Enabled = true;
                        }));
                        VerificationCode code = new VerificationCode(user.UserName, this.Mail.Text, "验证邮箱", 300);
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

                    
                    user.Mail = this.Mail.Text;

                    if (manager.UpdateUser(user))
                    {
                        this.Invoke(new Action(() =>
                        {
                            ShowInfoDialog("提示", "修改邮箱成功", UIStyle.Green, false);
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
            this.CheckCode.Text = this.CheckCode.Text.Trim();

            if (manager.UserIsExist(this.Mail.Text))
            {
                ShowWarningTip("邮箱已存在");
                this.Invoke(new Action(() =>
                {
                    this.Mail.Text = "";
                }));
                return false;
            }

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
            return true;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (this.Password.Text == user.Password)
            {
                this.Mail.Enabled = true;
                this.CheckCode.Enabled = true;
                this.SendCode.Enabled = true;
            }
            else
            {
                this.Mail.Enabled = false;
                this.CheckCode.Enabled = false;
                this.SendCode.Enabled = false;
            }
        }
    }
}
