
namespace WebDisk_Client.UI
{
    partial class RegisterDialog
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.UserName = new Sunny.UI.UITextBox();
            this.Password = new Sunny.UI.UITextBox();
            this.Passwordd = new Sunny.UI.UITextBox();
            this.Mail = new Sunny.UI.UITextBox();
            this.SendCode = new Sunny.UI.UIButton();
            this.CheckCode = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.Register = new Sunny.UI.UIButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(17, 55);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62141;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel1.TabIndex = 11;
            this.uiSymbolLabel1.Text = "用户名:";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(17, 105);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 57510;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel2.TabIndex = 22;
            this.uiSymbolLabel2.Text = "密码:";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(17, 155);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 57510;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel3.TabIndex = 33;
            this.uiSymbolLabel3.Text = "确认密码:";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(17, 208);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 57462;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel4.TabIndex = 44;
            this.uiSymbolLabel4.Text = "电子邮件:";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserName
            // 
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.FillColor = System.Drawing.Color.White;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserName.Location = new System.Drawing.Point(130, 55);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserName.Maximum = 2147483647D;
            this.UserName.Minimum = -2147483648D;
            this.UserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserName.Name = "UserName";
            this.UserName.RectColor = System.Drawing.Color.Gray;
            this.UserName.Size = new System.Drawing.Size(251, 30);
            this.UserName.Style = Sunny.UI.UIStyle.Custom;
            this.UserName.TabIndex = 0;
            this.UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.Watermark = "最低6位\\字母、数字、下划线";
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FillColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Password.Location = new System.Drawing.Point(130, 105);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Maximum = 2147483647D;
            this.Password.Minimum = -2147483648D;
            this.Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.RectColor = System.Drawing.Color.Gray;
            this.Password.Size = new System.Drawing.Size(251, 30);
            this.Password.Style = Sunny.UI.UIStyle.Custom;
            this.Password.TabIndex = 1;
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password.Watermark = "最低6位\\字母、数字、下划线";
            // 
            // Passwordd
            // 
            this.Passwordd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordd.FillColor = System.Drawing.Color.White;
            this.Passwordd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Passwordd.Location = new System.Drawing.Point(130, 160);
            this.Passwordd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Passwordd.Maximum = 2147483647D;
            this.Passwordd.Minimum = -2147483648D;
            this.Passwordd.MinimumSize = new System.Drawing.Size(1, 1);
            this.Passwordd.Name = "Passwordd";
            this.Passwordd.PasswordChar = '●';
            this.Passwordd.RectColor = System.Drawing.Color.Gray;
            this.Passwordd.Size = new System.Drawing.Size(251, 30);
            this.Passwordd.Style = Sunny.UI.UIStyle.Custom;
            this.Passwordd.TabIndex = 2;
            this.Passwordd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Mail
            // 
            this.Mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Mail.FillColor = System.Drawing.Color.White;
            this.Mail.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Mail.Location = new System.Drawing.Point(130, 212);
            this.Mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mail.Maximum = 2147483647D;
            this.Mail.Minimum = -2147483648D;
            this.Mail.MinimumSize = new System.Drawing.Size(1, 1);
            this.Mail.Name = "Mail";
            this.Mail.RectColor = System.Drawing.Color.Gray;
            this.Mail.Size = new System.Drawing.Size(251, 30);
            this.Mail.Style = Sunny.UI.UIStyle.Custom;
            this.Mail.TabIndex = 3;
            this.Mail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SendCode
            // 
            this.SendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.SendCode.Location = new System.Drawing.Point(288, 264);
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
            this.SendCode.TabIndex = 6;
            this.SendCode.Text = "获取验证码";
            this.SendCode.Click += new System.EventHandler(this.SendCode_Click);
            // 
            // CheckCode
            // 
            this.CheckCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CheckCode.FillColor = System.Drawing.Color.White;
            this.CheckCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CheckCode.Location = new System.Drawing.Point(130, 265);
            this.CheckCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckCode.Maximum = 2147483647D;
            this.CheckCode.Minimum = -2147483648D;
            this.CheckCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.CheckCode.Name = "CheckCode";
            this.CheckCode.RectColor = System.Drawing.Color.Gray;
            this.CheckCode.Size = new System.Drawing.Size(151, 30);
            this.CheckCode.Style = Sunny.UI.UIStyle.Custom;
            this.CheckCode.TabIndex = 4;
            this.CheckCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(17, 261);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.Symbol = 57608;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel5.TabIndex = 55;
            this.uiSymbolLabel5.Text = "验证码:";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Register
            // 
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Register.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Register.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Register.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Register.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Register.Location = new System.Drawing.Point(285, 329);
            this.Register.MinimumSize = new System.Drawing.Size(1, 1);
            this.Register.Name = "Register";
            this.Register.Radius = 33;
            this.Register.RectColor = System.Drawing.Color.Transparent;
            this.Register.RectDisableColor = System.Drawing.Color.Transparent;
            this.Register.RectHoverColor = System.Drawing.Color.Transparent;
            this.Register.RectPressColor = System.Drawing.Color.Transparent;
            this.Register.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Register.Size = new System.Drawing.Size(100, 35);
            this.Register.Style = Sunny.UI.UIStyle.Custom;
            this.Register.TabIndex = 9;
            this.Register.Text = "注册";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(-21, 302);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(487, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.StyleCustomMode = true;
            this.uiLine1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RegisterDialog
            // 
            this.AcceptButton = this.Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 378);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.CheckCode);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.SendCode);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Passwordd);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiLine1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "用户注册";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterDialog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox UserName;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UITextBox Passwordd;
        private Sunny.UI.UITextBox Mail;
        private Sunny.UI.UIButton SendCode;
        private Sunny.UI.UITextBox CheckCode;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UIButton Register;
        private Sunny.UI.UILine uiLine1;
        private System.Windows.Forms.Timer timer1;
    }
}