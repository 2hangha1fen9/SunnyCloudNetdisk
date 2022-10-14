
namespace WebDisk_Client.UI
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("首页");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("传输");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("分享");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.find = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Submit = new Sunny.UI.UISymbolButton();
            this.UserName = new Sunny.UI.UILinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.彻底关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoScroll = true;
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.UserName);
            this.Header.Controls.Add(this.find);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.Submit);
            this.Header.ForeColor = System.Drawing.Color.Gray;
            this.Header.Location = new System.Drawing.Point(2, 35);
            this.Header.MenuHoverColor = System.Drawing.Color.Transparent;
            this.Header.MenuSelectedColor = System.Drawing.Color.Transparent;
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.NodeInterval = 400;
            treeNode1.Name = "home";
            treeNode1.Text = "首页";
            treeNode2.Name = "trans";
            treeNode2.Text = "传输";
            treeNode3.Name = "share";
            treeNode3.Text = "分享";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.Header.NodeSize = new System.Drawing.Size(130, 100);
            this.Header.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Header.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Header.SelectedHighColorSize = 0;
            this.Header.SelectedIndex = 0;
            this.Header.Size = new System.Drawing.Size(946, 100);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.StyleCustomMode = true;
            // 
            // find
            // 
            this.find.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.find.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.find.FormattingEnabled = true;
            this.find.Location = new System.Drawing.Point(583, 36);
            this.find.MaxDropDownItems = 5;
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(290, 26);
            this.find.TabIndex = 11;
            this.find.SelectedIndexChanged += new System.EventHandler(this.find_SelectedIndexChanged);
            this.find.KeyUp += new System.Windows.Forms.KeyEventHandler(this.find_KeyUp);
            this.find.MouseClick += new System.Windows.Forms.MouseEventHandler(this.find_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::WebDisk_Client.Properties.Resources.line;
            this.pictureBox1.Location = new System.Drawing.Point(0, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(946, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "SunnyCloud已最小化到托盘";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SunnyCloud";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Submit
            // 
            this.Submit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FillColor = System.Drawing.Color.Gainsboro;
            this.Submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Submit.Location = new System.Drawing.Point(872, 36);
            this.Submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.Submit.Name = "Submit";
            this.Submit.Radius = 25;
            this.Submit.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.Submit.RectColor = System.Drawing.Color.Gainsboro;
            this.Submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.Submit.RectHoverColor = System.Drawing.Color.Transparent;
            this.Submit.RectPressColor = System.Drawing.Color.Transparent;
            this.Submit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Submit.Size = new System.Drawing.Size(55, 26);
            this.Submit.Style = Sunny.UI.UIStyle.Custom;
            this.Submit.Symbol = 61442;
            this.Submit.TabIndex = 12;
            this.Submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // UserName
            // 
            this.UserName.ActiveLinkColor = System.Drawing.Color.Gray;
            this.UserName.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.UserName.LinkColor = System.Drawing.Color.Gray;
            this.UserName.Location = new System.Drawing.Point(0, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(178, 90);
            this.UserName.Style = Sunny.UI.UIStyle.Custom;
            this.UserName.StyleCustomMode = true;
            this.UserName.TabIndex = 13;
            this.UserName.TabStop = true;
            this.UserName.Text = "用户名";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.彻底关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 彻底关闭ToolStripMenuItem
            // 
            this.彻底关闭ToolStripMenuItem.Name = "彻底关闭ToolStripMenuItem";
            this.彻底关闭ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.彻底关闭ToolStripMenuItem.Text = "彻底关闭";
            this.彻底关闭ToolStripMenuItem.Click += new System.EventHandler(this.彻底关闭ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoClosePage = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.CloseAskString = "";
            this.ExtendBox = true;
            this.ExtendSymbol = 261829;
            this.ExtendSymbolOffset = new System.Drawing.Point(0, 2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "SunnyCloud";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ExtendBoxClick += new System.EventHandler(this.MainForm_ExtendBoxClick);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox find;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Sunny.UI.UISymbolButton Submit;
        private Sunny.UI.UILinkLabel UserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 彻底关闭ToolStripMenuItem;
    }
}