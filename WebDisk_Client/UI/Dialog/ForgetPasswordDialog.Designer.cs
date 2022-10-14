
namespace WebDisk_Client.UI.Dialog
{
    partial class ForgetPasswordDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CheckCode = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.SendCode = new Sunny.UI.UIButton();
            this.Account = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.Submit = new Sunny.UI.UIButton();
            this.Password = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CheckCode
            // 
            this.CheckCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CheckCode.FillColor = System.Drawing.Color.White;
            this.CheckCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CheckCode.Location = new System.Drawing.Point(125, 104);
            this.CheckCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckCode.Maximum = 2147483647D;
            this.CheckCode.Minimum = -2147483648D;
            this.CheckCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.CheckCode.Name = "CheckCode";
            this.CheckCode.RectColor = System.Drawing.Color.Gray;
            this.CheckCode.Size = new System.Drawing.Size(151, 30);
            this.CheckCode.Style = Sunny.UI.UIStyle.Custom;
            this.CheckCode.TabIndex = 1;
            this.CheckCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(28, 104);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.Symbol = 57608;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel5.TabIndex = 17;
            this.uiSymbolLabel5.Text = "验证码:";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SendCode
            // 
            this.SendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.SendCode.Location = new System.Drawing.Point(283, 104);
            this.SendCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.SendCode.Name = "SendCode";
            this.SendCode.Radius = 30;
            this.SendCode.RectColor = System.Drawing.Color.Transparent;
            this.SendCode.RectDisableColor = System.Drawing.Color.Transparent;
            this.SendCode.RectHoverColor = System.Drawing.Color.Transparent;
            this.SendCode.RectPressColor = System.Drawing.Color.Transparent;
            this.SendCode.RectSelectedColor = System.Drawing.Color.Transparent;
            this.SendCode.Size = new System.Drawing.Size(93, 31);
            this.SendCode.Style = Sunny.UI.UIStyle.Custom;
            this.SendCode.TabIndex = 16;
            this.SendCode.Text = "获取验证码";
            this.SendCode.Click += new System.EventHandler(this.SendCode_Click);
            // 
            // Account
            // 
            this.Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Account.FillColor = System.Drawing.Color.White;
            this.Account.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Account.Location = new System.Drawing.Point(125, 51);
            this.Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Account.Maximum = 2147483647D;
            this.Account.Minimum = -2147483648D;
            this.Account.MinimumSize = new System.Drawing.Size(1, 1);
            this.Account.Name = "Account";
            this.Account.RectColor = System.Drawing.Color.Gray;
            this.Account.Size = new System.Drawing.Size(251, 30);
            this.Account.Style = Sunny.UI.UIStyle.Custom;
            this.Account.TabIndex = 0;
            this.Account.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account.Watermark = "请输入用户名或邮箱";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(28, 51);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 62141;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel4.TabIndex = 14;
            this.uiSymbolLabel4.Text = "账户:";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(-22, 195);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(487, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.StyleCustomMode = true;
            this.uiLine1.TabIndex = 19;
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Submit.Location = new System.Drawing.Point(283, 221);
            this.Submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.Submit.Name = "Submit";
            this.Submit.Radius = 33;
            this.Submit.RectColor = System.Drawing.Color.Transparent;
            this.Submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.Submit.RectHoverColor = System.Drawing.Color.Transparent;
            this.Submit.RectPressColor = System.Drawing.Color.Transparent;
            this.Submit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Submit.Size = new System.Drawing.Size(100, 35);
            this.Submit.Style = Sunny.UI.UIStyle.Custom;
            this.Submit.TabIndex = 20;
            this.Submit.Text = "提交";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FillColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Password.ForeColor = System.Drawing.Color.Gray;
            this.Password.Location = new System.Drawing.Point(125, 156);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Maximum = 2147483647D;
            this.Password.Minimum = -2147483648D;
            this.Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.RectColor = System.Drawing.Color.Gray;
            this.Password.Size = new System.Drawing.Size(251, 33);
            this.Password.Style = Sunny.UI.UIStyle.Custom;
            this.Password.StyleCustomMode = true;
            this.Password.TabIndex = 2;
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password.Watermark = "最低6位\\字母、数字、下划线";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(28, 154);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(98, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.StyleCustomMode = true;
            this.uiSymbolLabel2.Symbol = 57510;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel2.TabIndex = 21;
            this.uiSymbolLabel2.Text = "新密码:";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ForgetPasswordDialog
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 269);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.CheckCode);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.SendCode);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiLine1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgetPasswordDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "找回密码";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgetPasswordDialog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox CheckCode;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UIButton SendCode;
        private Sunny.UI.UITextBox Account;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIButton Submit;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}