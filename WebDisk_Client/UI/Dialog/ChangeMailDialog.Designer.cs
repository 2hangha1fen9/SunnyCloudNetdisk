
namespace WebDisk_Client.UI.Dialog
{
    partial class ChangeMailDialog
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
            this.Mail = new Sunny.UI.UITextBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.CheckCode = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.SendCode = new Sunny.UI.UIButton();
            this.Submit = new Sunny.UI.UIButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Password = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.Transparent;
            this.Mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Mail.Enabled = false;
            this.Mail.FillColor = System.Drawing.Color.White;
            this.Mail.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Mail.ForeColor = System.Drawing.Color.Gray;
            this.Mail.Location = new System.Drawing.Point(144, 115);
            this.Mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mail.Maximum = 2147483647D;
            this.Mail.Minimum = -2147483648D;
            this.Mail.MinimumSize = new System.Drawing.Size(1, 1);
            this.Mail.Name = "Mail";
            this.Mail.RectColor = System.Drawing.Color.Gray;
            this.Mail.Size = new System.Drawing.Size(251, 33);
            this.Mail.Style = Sunny.UI.UIStyle.Custom;
            this.Mail.StyleCustomMode = true;
            this.Mail.TabIndex = 0;
            this.Mail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mail.Watermark = "最低6位\\字母、数字、下划线";
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(-10, 206);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(487, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.StyleCustomMode = true;
            this.uiLine1.TabIndex = 28;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(21, 115);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 57462;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel1.TabIndex = 31;
            this.uiSymbolLabel1.Text = "电子邮件:";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckCode
            // 
            this.CheckCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CheckCode.Enabled = false;
            this.CheckCode.FillColor = System.Drawing.Color.White;
            this.CheckCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CheckCode.Location = new System.Drawing.Point(144, 167);
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
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(21, 165);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(97, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 57608;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel2.TabIndex = 29;
            this.uiSymbolLabel2.Text = "验证码:";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SendCode
            // 
            this.SendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendCode.Enabled = false;
            this.SendCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.SendCode.Location = new System.Drawing.Point(302, 167);
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
            this.SendCode.TabIndex = 28;
            this.SendCode.Text = "获取验证码";
            this.SendCode.Click += new System.EventHandler(this.SendCode_Click);
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Submit.Location = new System.Drawing.Point(302, 231);
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
            this.Submit.TabIndex = 32;
            this.Submit.Text = "提交";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FillColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Password.ForeColor = System.Drawing.Color.Gray;
            this.Password.Location = new System.Drawing.Point(144, 63);
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
            this.Password.TabIndex = 33;
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password.Watermark = "最低6位\\字母、数字、下划线";
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(24, 61);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(98, 35);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.StyleCustomMode = true;
            this.uiSymbolLabel3.Symbol = 57510;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel3.TabIndex = 34;
            this.uiSymbolLabel3.Text = "密码:";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeMailDialog
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 277);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.CheckCode);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.SendCode);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.uiLine1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeMailDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "修改邮箱";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox Mail;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox CheckCode;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIButton SendCode;
        private Sunny.UI.UIButton Submit;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
    }
}