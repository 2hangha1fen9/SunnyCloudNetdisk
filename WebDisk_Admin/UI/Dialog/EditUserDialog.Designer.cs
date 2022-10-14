
namespace WebDisk_Admin.UI
{
    partial class EditUserDialog
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
            this.Mail = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.Password = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.Enable = new Sunny.UI.UIRadioButton();
            this.Unable = new Sunny.UI.UIRadioButton();
            this.ULBandwidth = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.DLBandwidth = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.QuotaFiles = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.QuotaSize = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.Submit = new Sunny.UI.UIButton();
            this.UserName = new Sunny.UI.UITextBox();
            this.Reset = new Sunny.UI.UIButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.ULFree = new System.Windows.Forms.CheckBox();
            this.DLFree = new System.Windows.Forms.CheckBox();
            this.SizeFree = new System.Windows.Forms.CheckBox();
            this.CountFree = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Mail
            // 
            this.Mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Mail.FillColor = System.Drawing.Color.White;
            this.Mail.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Mail.Location = new System.Drawing.Point(128, 178);
            this.Mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mail.Maximum = 2147483647D;
            this.Mail.Minimum = -2147483648D;
            this.Mail.MinimumSize = new System.Drawing.Size(1, 1);
            this.Mail.Name = "Mail";
            this.Mail.RectColor = System.Drawing.Color.Gray;
            this.Mail.Size = new System.Drawing.Size(286, 30);
            this.Mail.Style = Sunny.UI.UIStyle.Custom;
            this.Mail.StyleCustomMode = true;
            this.Mail.TabIndex = 2;
            this.Mail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel4.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel4.Location = new System.Drawing.Point(21, 184);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.StyleCustomMode = true;
            this.uiLabel4.TabIndex = 12;
            this.uiLabel4.Text = "电子邮箱:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FillColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Password.Location = new System.Drawing.Point(128, 97);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Maximum = 2147483647D;
            this.Password.Minimum = -2147483648D;
            this.Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.Password.Name = "Password";
            this.Password.RectColor = System.Drawing.Color.Gray;
            this.Password.Size = new System.Drawing.Size(286, 30);
            this.Password.Style = Sunny.UI.UIStyle.Custom;
            this.Password.StyleCustomMode = true;
            this.Password.TabIndex = 1;
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Location = new System.Drawing.Point(21, 104);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 10;
            this.uiLabel2.Text = "密码:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel1.Location = new System.Drawing.Point(21, 64);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "用户名:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel5.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel5.Location = new System.Drawing.Point(21, 142);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.StyleCustomMode = true;
            this.uiLabel5.TabIndex = 15;
            this.uiLabel5.Text = "状态:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Enable
            // 
            this.Enable.Checked = true;
            this.Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enable.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Enable.ForeColor = System.Drawing.Color.Gray;
            this.Enable.Location = new System.Drawing.Point(128, 141);
            this.Enable.MinimumSize = new System.Drawing.Size(1, 1);
            this.Enable.Name = "Enable";
            this.Enable.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.Enable.RadioButtonColor = System.Drawing.Color.Gray;
            this.Enable.Size = new System.Drawing.Size(78, 29);
            this.Enable.Style = Sunny.UI.UIStyle.Custom;
            this.Enable.StyleCustomMode = true;
            this.Enable.TabIndex = 16;
            this.Enable.Text = "启用";
            // 
            // Unable
            // 
            this.Unable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Unable.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Unable.ForeColor = System.Drawing.Color.Gray;
            this.Unable.Location = new System.Drawing.Point(212, 141);
            this.Unable.MinimumSize = new System.Drawing.Size(1, 1);
            this.Unable.Name = "Unable";
            this.Unable.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.Unable.RadioButtonColor = System.Drawing.Color.Gray;
            this.Unable.Size = new System.Drawing.Size(78, 29);
            this.Unable.Style = Sunny.UI.UIStyle.Custom;
            this.Unable.StyleCustomMode = true;
            this.Unable.TabIndex = 17;
            this.Unable.Text = "禁用";
            // 
            // ULBandwidth
            // 
            this.ULBandwidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ULBandwidth.FillColor = System.Drawing.Color.White;
            this.ULBandwidth.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.ULBandwidth.HasMaximum = true;
            this.ULBandwidth.Location = new System.Drawing.Point(128, 227);
            this.ULBandwidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ULBandwidth.Maximum = 2147483647D;
            this.ULBandwidth.MaximumEnabled = true;
            this.ULBandwidth.Minimum = 0D;
            this.ULBandwidth.MinimumSize = new System.Drawing.Size(1, 1);
            this.ULBandwidth.Name = "ULBandwidth";
            this.ULBandwidth.RectColor = System.Drawing.Color.Gray;
            this.ULBandwidth.Size = new System.Drawing.Size(155, 30);
            this.ULBandwidth.Style = Sunny.UI.UIStyle.Custom;
            this.ULBandwidth.StyleCustomMode = true;
            this.ULBandwidth.TabIndex = 3;
            this.ULBandwidth.Text = "0";
            this.ULBandwidth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ULBandwidth.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel6.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel6.Location = new System.Drawing.Point(21, 233);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.StyleCustomMode = true;
            this.uiLabel6.TabIndex = 18;
            this.uiLabel6.Text = "上行带宽:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DLBandwidth
            // 
            this.DLBandwidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DLBandwidth.FillColor = System.Drawing.Color.White;
            this.DLBandwidth.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.DLBandwidth.HasMaximum = true;
            this.DLBandwidth.HasMinimum = true;
            this.DLBandwidth.Location = new System.Drawing.Point(128, 276);
            this.DLBandwidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DLBandwidth.Maximum = 2147483647D;
            this.DLBandwidth.MaximumEnabled = true;
            this.DLBandwidth.Minimum = 0D;
            this.DLBandwidth.MinimumEnabled = true;
            this.DLBandwidth.MinimumSize = new System.Drawing.Size(1, 1);
            this.DLBandwidth.Name = "DLBandwidth";
            this.DLBandwidth.RectColor = System.Drawing.Color.Gray;
            this.DLBandwidth.Size = new System.Drawing.Size(155, 30);
            this.DLBandwidth.Style = Sunny.UI.UIStyle.Custom;
            this.DLBandwidth.StyleCustomMode = true;
            this.DLBandwidth.TabIndex = 4;
            this.DLBandwidth.Text = "0";
            this.DLBandwidth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DLBandwidth.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel7.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel7.Location = new System.Drawing.Point(21, 282);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(100, 23);
            this.uiLabel7.StyleCustomMode = true;
            this.uiLabel7.TabIndex = 20;
            this.uiLabel7.Text = "下行带宽:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuotaFiles
            // 
            this.QuotaFiles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuotaFiles.FillColor = System.Drawing.Color.White;
            this.QuotaFiles.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.QuotaFiles.HasMinimum = true;
            this.QuotaFiles.Location = new System.Drawing.Point(128, 376);
            this.QuotaFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuotaFiles.Maximum = 2147483647D;
            this.QuotaFiles.Minimum = 0D;
            this.QuotaFiles.MinimumEnabled = true;
            this.QuotaFiles.MinimumSize = new System.Drawing.Size(1, 1);
            this.QuotaFiles.Name = "QuotaFiles";
            this.QuotaFiles.RectColor = System.Drawing.Color.Gray;
            this.QuotaFiles.Size = new System.Drawing.Size(155, 30);
            this.QuotaFiles.Style = Sunny.UI.UIStyle.Custom;
            this.QuotaFiles.StyleCustomMode = true;
            this.QuotaFiles.TabIndex = 6;
            this.QuotaFiles.Text = "0";
            this.QuotaFiles.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuotaFiles.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel8.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel8.Location = new System.Drawing.Point(21, 382);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(100, 23);
            this.uiLabel8.StyleCustomMode = true;
            this.uiLabel8.TabIndex = 24;
            this.uiLabel8.Text = "最大文件:";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuotaSize
            // 
            this.QuotaSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuotaSize.FillColor = System.Drawing.Color.White;
            this.QuotaSize.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.QuotaSize.HasMaximum = true;
            this.QuotaSize.HasMinimum = true;
            this.QuotaSize.Location = new System.Drawing.Point(128, 327);
            this.QuotaSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuotaSize.Maximum = 2147483647D;
            this.QuotaSize.MaximumEnabled = true;
            this.QuotaSize.Minimum = 0D;
            this.QuotaSize.MinimumEnabled = true;
            this.QuotaSize.MinimumSize = new System.Drawing.Size(1, 1);
            this.QuotaSize.Name = "QuotaSize";
            this.QuotaSize.RectColor = System.Drawing.Color.Gray;
            this.QuotaSize.Size = new System.Drawing.Size(155, 30);
            this.QuotaSize.Style = Sunny.UI.UIStyle.Custom;
            this.QuotaSize.StyleCustomMode = true;
            this.QuotaSize.TabIndex = 5;
            this.QuotaSize.Text = "0";
            this.QuotaSize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuotaSize.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel9.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel9.Location = new System.Drawing.Point(21, 333);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(100, 23);
            this.uiLabel9.StyleCustomMode = true;
            this.uiLabel9.TabIndex = 22;
            this.uiLabel9.Text = "最大容量:";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel10.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel10.Location = new System.Drawing.Point(290, 227);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(51, 23);
            this.uiLabel10.StyleCustomMode = true;
            this.uiLabel10.TabIndex = 26;
            this.uiLabel10.Text = "KB/s";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel11.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel11.Location = new System.Drawing.Point(290, 282);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(51, 23);
            this.uiLabel11.StyleCustomMode = true;
            this.uiLabel11.TabIndex = 27;
            this.uiLabel11.Text = "KB/s";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel12.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel12.Location = new System.Drawing.Point(290, 327);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(51, 23);
            this.uiLabel12.StyleCustomMode = true;
            this.uiLabel12.TabIndex = 28;
            this.uiLabel12.Text = "MB";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Submit.Location = new System.Drawing.Point(347, 442);
            this.Submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.Submit.Name = "Submit";
            this.Submit.Radius = 33;
            this.Submit.RectColor = System.Drawing.Color.Transparent;
            this.Submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.Submit.RectHoverColor = System.Drawing.Color.Transparent;
            this.Submit.RectPressColor = System.Drawing.Color.Transparent;
            this.Submit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Submit.Size = new System.Drawing.Size(103, 35);
            this.Submit.Style = Sunny.UI.UIStyle.Custom;
            this.Submit.StyleCustomMode = true;
            this.Submit.TabIndex = 30;
            this.Submit.Text = "提交";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // UserName
            // 
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.FillColor = System.Drawing.Color.White;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.UserName.Location = new System.Drawing.Point(128, 57);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserName.Maximum = 2147483647D;
            this.UserName.Minimum = -2147483648D;
            this.UserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserName.Name = "UserName";
            this.UserName.RectColor = System.Drawing.Color.Gray;
            this.UserName.Size = new System.Drawing.Size(286, 30);
            this.UserName.Style = Sunny.UI.UIStyle.Custom;
            this.UserName.StyleCustomMode = true;
            this.UserName.TabIndex = 0;
            this.UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Reset
            // 
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Reset.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Reset.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Reset.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Reset.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Reset.Location = new System.Drawing.Point(241, 442);
            this.Reset.MinimumSize = new System.Drawing.Size(1, 1);
            this.Reset.Name = "Reset";
            this.Reset.Radius = 33;
            this.Reset.RectColor = System.Drawing.Color.Transparent;
            this.Reset.RectDisableColor = System.Drawing.Color.Transparent;
            this.Reset.RectHoverColor = System.Drawing.Color.Transparent;
            this.Reset.RectPressColor = System.Drawing.Color.Transparent;
            this.Reset.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Reset.Size = new System.Drawing.Size(103, 35);
            this.Reset.Style = Sunny.UI.UIStyle.Custom;
            this.Reset.StyleCustomMode = true;
            this.Reset.TabIndex = 32;
            this.Reset.Text = "重置";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(-6, 413);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(490, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.StyleCustomMode = true;
            this.uiLine1.TabIndex = 33;
            // 
            // ULFree
            // 
            this.ULFree.AutoSize = true;
            this.ULFree.Location = new System.Drawing.Point(347, 230);
            this.ULFree.Name = "ULFree";
            this.ULFree.Size = new System.Drawing.Size(77, 26);
            this.ULFree.TabIndex = 34;
            this.ULFree.Text = "无限制";
            this.ULFree.UseVisualStyleBackColor = true;
            this.ULFree.CheckedChanged += new System.EventHandler(this.ULFree_CheckedChanged);
            // 
            // DLFree
            // 
            this.DLFree.AutoSize = true;
            this.DLFree.Location = new System.Drawing.Point(347, 279);
            this.DLFree.Name = "DLFree";
            this.DLFree.Size = new System.Drawing.Size(77, 26);
            this.DLFree.TabIndex = 35;
            this.DLFree.Text = "无限制";
            this.DLFree.UseVisualStyleBackColor = true;
            this.DLFree.CheckedChanged += new System.EventHandler(this.DLFree_CheckedChanged);
            // 
            // SizeFree
            // 
            this.SizeFree.AutoSize = true;
            this.SizeFree.Location = new System.Drawing.Point(347, 326);
            this.SizeFree.Name = "SizeFree";
            this.SizeFree.Size = new System.Drawing.Size(77, 26);
            this.SizeFree.TabIndex = 36;
            this.SizeFree.Text = "无限制";
            this.SizeFree.UseVisualStyleBackColor = true;
            this.SizeFree.CheckedChanged += new System.EventHandler(this.SizeFree_CheckedChanged);
            // 
            // CountFree
            // 
            this.CountFree.AutoSize = true;
            this.CountFree.Location = new System.Drawing.Point(347, 379);
            this.CountFree.Name = "CountFree";
            this.CountFree.Size = new System.Drawing.Size(77, 26);
            this.CountFree.TabIndex = 37;
            this.CountFree.Text = "无限制";
            this.CountFree.UseVisualStyleBackColor = true;
            this.CountFree.CheckedChanged += new System.EventHandler(this.CountFree_CheckedChanged);
            // 
            // EditUserDialog
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 494);
            this.Controls.Add(this.CountFree);
            this.Controls.Add(this.SizeFree);
            this.Controls.Add(this.DLFree);
            this.Controls.Add(this.ULFree);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.QuotaFiles);
            this.Controls.Add(this.DLBandwidth);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.QuotaSize);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.ULBandwidth);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.Unable);
            this.Controls.Add(this.Enable);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUserDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "EditUserForm";
            this.TextAlignment = System.Drawing.StringAlignment.Far;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox Mail;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIRadioButton Enable;
        private Sunny.UI.UIRadioButton Unable;
        private Sunny.UI.UITextBox ULBandwidth;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox DLBandwidth;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox QuotaFiles;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox QuotaSize;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIButton Submit;
        private Sunny.UI.UITextBox UserName;
        private Sunny.UI.UIButton Reset;
        private Sunny.UI.UILine uiLine1;
        private System.Windows.Forms.CheckBox ULFree;
        private System.Windows.Forms.CheckBox DLFree;
        private System.Windows.Forms.CheckBox SizeFree;
        private System.Windows.Forms.CheckBox CountFree;
    }
}