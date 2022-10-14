
namespace WebDisk_Client.UI
{
    partial class LoginDialog
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.Password = new Sunny.UI.UITextBox();
            this.Forget = new Sunny.UI.UILinkLabel();
            this.Register = new Sunny.UI.UIButton();
            this.Login = new Sunny.UI.UIButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.UserName = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(19, 56);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(98, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.StyleCustomMode = true;
            this.uiSymbolLabel1.Symbol = 62141;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel1.TabIndex = 11;
            this.uiSymbolLabel1.Text = "账户:";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(19, 106);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(98, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.StyleCustomMode = true;
            this.uiSymbolLabel2.Symbol = 57510;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Gray;
            this.uiSymbolLabel2.TabIndex = 22;
            this.uiSymbolLabel2.Text = "密码:";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FillColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Password.ForeColor = System.Drawing.Color.Gray;
            this.Password.Location = new System.Drawing.Point(124, 107);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Maximum = 2147483647D;
            this.Password.Minimum = -2147483648D;
            this.Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.RectColor = System.Drawing.Color.Gray;
            this.Password.Size = new System.Drawing.Size(223, 33);
            this.Password.Style = Sunny.UI.UIStyle.Custom;
            this.Password.StyleCustomMode = true;
            this.Password.TabIndex = 1;
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Forget
            // 
            this.Forget.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Forget.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Forget.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.Forget.LinkColor = System.Drawing.Color.Gray;
            this.Forget.Location = new System.Drawing.Point(352, 112);
            this.Forget.Name = "Forget";
            this.Forget.Size = new System.Drawing.Size(100, 23);
            this.Forget.Style = Sunny.UI.UIStyle.Custom;
            this.Forget.StyleCustomMode = true;
            this.Forget.TabIndex = 7;
            this.Forget.TabStop = true;
            this.Forget.Text = "忘记密码?";
            this.Forget.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Forget.Click += new System.EventHandler(this.uiLinkLabel1_Click);
            // 
            // Register
            // 
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Register.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Register.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Register.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Register.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Register.Location = new System.Drawing.Point(207, 182);
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
            this.Register.StyleCustomMode = true;
            this.Register.TabIndex = 9;
            this.Register.Text = "注册";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Login.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Login.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Login.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Login.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Login.Location = new System.Drawing.Point(320, 182);
            this.Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.Login.Name = "Login";
            this.Login.Radius = 33;
            this.Login.RectColor = System.Drawing.Color.Transparent;
            this.Login.RectDisableColor = System.Drawing.Color.Transparent;
            this.Login.RectHoverColor = System.Drawing.Color.Transparent;
            this.Login.RectPressColor = System.Drawing.Color.Transparent;
            this.Login.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Login.Size = new System.Drawing.Size(100, 35);
            this.Login.Style = Sunny.UI.UIStyle.Custom;
            this.Login.StyleCustomMode = true;
            this.Login.TabIndex = 10;
            this.Login.Text = "登录";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(-8, 147);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(487, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.StyleCustomMode = true;
            this.uiLine1.TabIndex = 12;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.FillColor = System.Drawing.Color.White;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.UserName.ForeColor = System.Drawing.Color.Gray;
            this.UserName.Location = new System.Drawing.Point(124, 58);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserName.Maximum = 2147483647D;
            this.UserName.Minimum = -2147483648D;
            this.UserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserName.Name = "UserName";
            this.UserName.RectColor = System.Drawing.Color.Gray;
            this.UserName.Size = new System.Drawing.Size(223, 33);
            this.UserName.Style = Sunny.UI.UIStyle.Custom;
            this.UserName.StyleCustomMode = true;
            this.UserName.TabIndex = 0;
            this.UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.Watermark = "用户名/邮箱";
            // 
            // LoginDialog
            // 
            this.AcceptButton = this.Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 236);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Forget);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiLine1);
            this.EscClose = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "SunnyCloud";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UILinkLabel Forget;
        private Sunny.UI.UIButton Register;
        private Sunny.UI.UIButton Login;
        private Sunny.UI.UILine uiLine1;
        public Sunny.UI.UITextBox UserName;
    }
}