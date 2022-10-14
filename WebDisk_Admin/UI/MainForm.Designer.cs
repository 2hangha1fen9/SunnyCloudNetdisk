
namespace WebDisk_Admin.UI
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("用户管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("分享管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("文件管理");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("传输");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.彻底关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserName = new Sunny.UI.UILinkLabel();
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
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.ForeColor = System.Drawing.Color.Gray;
            this.Header.Location = new System.Drawing.Point(2, 35);
            this.Header.MenuHoverColor = System.Drawing.Color.Transparent;
            this.Header.MenuSelectedColor = System.Drawing.Color.Transparent;
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.NodeInterval = 0;
            treeNode1.Name = "用户管理";
            treeNode1.Text = "用户管理";
            treeNode2.Name = "分享管理";
            treeNode2.Text = "分享管理";
            treeNode3.Name = "文件管理";
            treeNode3.Text = "文件管理";
            treeNode4.Name = "传输";
            treeNode4.Text = "传输";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.Header.NodeSize = new System.Drawing.Size(130, 100);
            this.Header.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Header.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Header.SelectedHighColorSize = 0;
            this.Header.SelectedIndex = 0;
            this.Header.Size = new System.Drawing.Size(946, 100);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.StyleCustomMode = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::WebDisk_Admin.Properties.Resources.line;
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
            // UserName
            // 
            this.UserName.ActiveLinkColor = System.Drawing.Color.Gray;
            this.UserName.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.UserName.LinkColor = System.Drawing.Color.Gray;
            this.UserName.Location = new System.Drawing.Point(0, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(126, 90);
            this.UserName.Style = Sunny.UI.UIStyle.Custom;
            this.UserName.StyleCustomMode = true;
            this.UserName.TabIndex = 13;
            this.UserName.TabStop = true;
            this.UserName.Text = "用户名";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
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
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Sunny.UI.UILinkLabel UserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 彻底关闭ToolStripMenuItem;
    }
}