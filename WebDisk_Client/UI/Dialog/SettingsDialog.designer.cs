
namespace WebDisk_Client.UI
{
    partial class SettingsDialog
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.DownLoadPath = new Sunny.UI.UITextBox();
            this.edit = new Sunny.UI.UIButton();
            this.uiButton7 = new Sunny.UI.UIButton();
            this.pathSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.reset = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.ShowSuccessTip = new Sunny.UI.UISwitch();
            this.PlaySuccessSound = new Sunny.UI.UISwitch();
            this.uiLine1 = new Sunny.UI.UILine();
            this.CloseAction = new Sunny.UI.UISwitch();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel1.Location = new System.Drawing.Point(34, 63);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(116, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "默认下载路径:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DownLoadPath
            // 
            this.DownLoadPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DownLoadPath.Enabled = false;
            this.DownLoadPath.FillColor = System.Drawing.Color.White;
            this.DownLoadPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownLoadPath.Location = new System.Drawing.Point(146, 59);
            this.DownLoadPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownLoadPath.Maximum = 2147483647D;
            this.DownLoadPath.Minimum = -2147483648D;
            this.DownLoadPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.DownLoadPath.Name = "DownLoadPath";
            this.DownLoadPath.RectColor = System.Drawing.Color.Gray;
            this.DownLoadPath.Size = new System.Drawing.Size(281, 30);
            this.DownLoadPath.Style = Sunny.UI.UIStyle.Custom;
            this.DownLoadPath.StyleCustomMode = true;
            this.DownLoadPath.TabIndex = 5;
            this.DownLoadPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edit
            // 
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.edit.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.edit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.edit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.edit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.edit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(434, 59);
            this.edit.MinimumSize = new System.Drawing.Size(1, 1);
            this.edit.Name = "edit";
            this.edit.Radius = 30;
            this.edit.RectColor = System.Drawing.Color.Transparent;
            this.edit.Size = new System.Drawing.Size(75, 30);
            this.edit.Style = Sunny.UI.UIStyle.Custom;
            this.edit.StyleCustomMode = true;
            this.edit.TabIndex = 6;
            this.edit.Text = "修改";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // uiButton7
            // 
            this.uiButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiButton7.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiButton7.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiButton7.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiButton7.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiButton7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton7.Location = new System.Drawing.Point(455, 257);
            this.uiButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton7.Name = "uiButton7";
            this.uiButton7.Radius = 30;
            this.uiButton7.RectColor = System.Drawing.Color.Transparent;
            this.uiButton7.Size = new System.Drawing.Size(67, 33);
            this.uiButton7.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton7.StyleCustomMode = true;
            this.uiButton7.TabIndex = 21;
            this.uiButton7.Text = "确定";
            this.uiButton7.Click += new System.EventHandler(this.uiButton7_Click);
            // 
            // reset
            // 
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.reset.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.reset.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.reset.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.reset.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(382, 257);
            this.reset.MinimumSize = new System.Drawing.Size(1, 1);
            this.reset.Name = "reset";
            this.reset.Radius = 30;
            this.reset.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.reset.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.reset.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.reset.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.reset.Size = new System.Drawing.Size(67, 33);
            this.reset.Style = Sunny.UI.UIStyle.Custom;
            this.reset.StyleCustomMode = true;
            this.reset.TabIndex = 23;
            this.reset.Text = "重置";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Location = new System.Drawing.Point(34, 108);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(116, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 24;
            this.uiLabel2.Text = "传输提示音:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel3.Location = new System.Drawing.Point(34, 155);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(116, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.StyleCustomMode = true;
            this.uiLabel3.TabIndex = 25;
            this.uiLabel3.Text = "传输提示框:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowSuccessTip
            // 
            this.ShowSuccessTip.Active = true;
            this.ShowSuccessTip.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowSuccessTip.ActiveText = "开启";
            this.ShowSuccessTip.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ShowSuccessTip.InActiveText = "关闭";
            this.ShowSuccessTip.Location = new System.Drawing.Point(146, 155);
            this.ShowSuccessTip.MinimumSize = new System.Drawing.Size(1, 1);
            this.ShowSuccessTip.Name = "ShowSuccessTip";
            this.ShowSuccessTip.Size = new System.Drawing.Size(67, 25);
            this.ShowSuccessTip.Style = Sunny.UI.UIStyle.Custom;
            this.ShowSuccessTip.StyleCustomMode = true;
            this.ShowSuccessTip.TabIndex = 26;
            this.ShowSuccessTip.Text = "uiSwitch1";
            // 
            // PlaySuccessSound
            // 
            this.PlaySuccessSound.Active = true;
            this.PlaySuccessSound.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PlaySuccessSound.ActiveText = "开启";
            this.PlaySuccessSound.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PlaySuccessSound.InActiveText = "关闭";
            this.PlaySuccessSound.Location = new System.Drawing.Point(146, 108);
            this.PlaySuccessSound.MinimumSize = new System.Drawing.Size(1, 1);
            this.PlaySuccessSound.Name = "PlaySuccessSound";
            this.PlaySuccessSound.Size = new System.Drawing.Size(67, 25);
            this.PlaySuccessSound.Style = Sunny.UI.UIStyle.Custom;
            this.PlaySuccessSound.StyleCustomMode = true;
            this.PlaySuccessSound.TabIndex = 27;
            this.PlaySuccessSound.Text = "uiSwitch2";
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(3, 232);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(551, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.StyleCustomMode = true;
            this.uiLine1.TabIndex = 28;
            // 
            // CloseAction
            // 
            this.CloseAction.Active = true;
            this.CloseAction.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CloseAction.ActiveText = "正常关闭";
            this.CloseAction.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.CloseAction.InActiveText = "最小化";
            this.CloseAction.Location = new System.Drawing.Point(146, 199);
            this.CloseAction.MinimumSize = new System.Drawing.Size(1, 1);
            this.CloseAction.Name = "CloseAction";
            this.CloseAction.Size = new System.Drawing.Size(87, 25);
            this.CloseAction.Style = Sunny.UI.UIStyle.Custom;
            this.CloseAction.StyleCustomMode = true;
            this.CloseAction.TabIndex = 30;
            this.CloseAction.Text = "uiSwitch1";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel4.Location = new System.Drawing.Point(34, 199);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(116, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.StyleCustomMode = true;
            this.uiLabel4.TabIndex = 29;
            this.uiLabel4.Text = "应用关闭:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.uiButton7;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 300);
            this.Controls.Add(this.CloseAction);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.PlaySuccessSound);
            this.Controls.Add(this.ShowSuccessTip);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.uiButton7);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.DownLoadPath);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLine1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "设置";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox DownLoadPath;
        private Sunny.UI.UIButton edit;
        private Sunny.UI.UIButton uiButton7;
        private System.Windows.Forms.FolderBrowserDialog pathSelector;
        private Sunny.UI.UIButton reset;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private new Sunny.UI.UISwitch ShowSuccessTip;
        private Sunny.UI.UISwitch PlaySuccessSound;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISwitch CloseAction;
        private Sunny.UI.UILabel uiLabel4;
    }
}