
namespace WebDisk_Client.UI
{
    partial class PathSelectorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathSelectorDialog));
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.全部文件 = new System.Windows.Forms.TabPage();
            this.Enter = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.loading = new Sunny.UI.UIProgressIndicator();
            this.createFolder = new Sunny.UI.UITextBox();
            this.path = new Sunny.UI.UILabel();
            this.flush = new Sunny.UI.UISymbolButton();
            this.home = new Sunny.UI.UISymbolButton();
            this.back = new Sunny.UI.UISymbolButton();
            this.AllFile = new System.Windows.Forms.ListView();
            this.fileOperator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.big = new System.Windows.Forms.ImageList(this.components);
            this.small = new System.Windows.Forms.ImageList(this.components);
            this.uiLine1 = new Sunny.UI.UILine();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pathSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSelector = new WebDisk_Client.UI.OpenFileDialogEx();
            this.uiTabControlMenu1.SuspendLayout();
            this.全部文件.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.fileOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.全部文件);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTabControlMenu1.ImageList = this.imageList1;
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 1);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 35);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(800, 423);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControlMenu1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabIndex = 0;
            this.uiTabControlMenu1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabSelectedForeColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabSelectedHighColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // 全部文件
            // 
            this.全部文件.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.全部文件.Controls.Add(this.Enter);
            this.全部文件.Controls.Add(this.uiPanel1);
            this.全部文件.Controls.Add(this.AllFile);
            this.全部文件.Controls.Add(this.uiLine1);
            this.全部文件.Location = new System.Drawing.Point(2, 0);
            this.全部文件.Name = "全部文件";
            this.全部文件.Size = new System.Drawing.Size(798, 423);
            this.全部文件.TabIndex = 1;
            this.全部文件.Text = "全部文件";
            // 
            // Enter
            // 
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Enter.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Enter.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Enter.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Enter.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Enter.Location = new System.Drawing.Point(682, 376);
            this.Enter.MinimumSize = new System.Drawing.Size(1, 1);
            this.Enter.Name = "Enter";
            this.Enter.Radius = 33;
            this.Enter.RectColor = System.Drawing.Color.Transparent;
            this.Enter.RectDisableColor = System.Drawing.Color.Transparent;
            this.Enter.RectHoverColor = System.Drawing.Color.Transparent;
            this.Enter.RectPressColor = System.Drawing.Color.Transparent;
            this.Enter.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Enter.Size = new System.Drawing.Size(100, 35);
            this.Enter.Style = Sunny.UI.UIStyle.Custom;
            this.Enter.TabIndex = 2;
            this.Enter.Text = "确定";
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.loading);
            this.uiPanel1.Controls.Add(this.createFolder);
            this.uiPanel1.Controls.Add(this.path);
            this.uiPanel1.Controls.Add(this.flush);
            this.uiPanel1.Controls.Add(this.home);
            this.uiPanel1.Controls.Add(this.back);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(798, 36);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loading
            // 
            this.loading.Dock = System.Windows.Forms.DockStyle.Right;
            this.loading.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.loading.Location = new System.Drawing.Point(644, 0);
            this.loading.MinimumSize = new System.Drawing.Size(1, 1);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(38, 36);
            this.loading.Style = Sunny.UI.UIStyle.White;
            this.loading.StyleCustomMode = true;
            this.loading.TabIndex = 18;
            this.loading.Text = "uiProgressIndicator1";
            // 
            // createFolder
            // 
            this.createFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.createFolder.FillColor = System.Drawing.Color.White;
            this.createFolder.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.createFolder.Location = new System.Drawing.Point(682, 0);
            this.createFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createFolder.Maximum = 2147483647D;
            this.createFolder.Minimum = -2147483648D;
            this.createFolder.MinimumSize = new System.Drawing.Size(1, 1);
            this.createFolder.Name = "createFolder";
            this.createFolder.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.createFolder.RectColor = System.Drawing.Color.Transparent;
            this.createFolder.Size = new System.Drawing.Size(116, 36);
            this.createFolder.Style = Sunny.UI.UIStyle.Custom;
            this.createFolder.StyleCustomMode = true;
            this.createFolder.Symbol = 111;
            this.createFolder.TabIndex = 17;
            this.createFolder.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.createFolder.Watermark = "新建文件夹";
            this.createFolder.DoEnter += new System.EventHandler(this.createFolder_DoEnter);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path.AutoEllipsis = true;
            this.path.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.Location = new System.Drawing.Point(123, 0);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(525, 36);
            this.path.Style = Sunny.UI.UIStyle.Custom;
            this.path.TabIndex = 7;
            this.path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flush
            // 
            this.flush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flush.Dock = System.Windows.Forms.DockStyle.Left;
            this.flush.FillColor = System.Drawing.Color.Transparent;
            this.flush.FillDisableColor = System.Drawing.Color.Transparent;
            this.flush.FillHoverColor = System.Drawing.Color.Transparent;
            this.flush.FillPressColor = System.Drawing.Color.Transparent;
            this.flush.FillSelectedColor = System.Drawing.Color.Transparent;
            this.flush.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flush.ForeColor = System.Drawing.Color.Gray;
            this.flush.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.flush.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.flush.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.flush.Location = new System.Drawing.Point(82, 0);
            this.flush.MinimumSize = new System.Drawing.Size(1, 1);
            this.flush.Name = "flush";
            this.flush.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.flush.RectColor = System.Drawing.Color.Transparent;
            this.flush.RectDisableColor = System.Drawing.Color.Transparent;
            this.flush.RectHoverColor = System.Drawing.Color.Transparent;
            this.flush.RectPressColor = System.Drawing.Color.Transparent;
            this.flush.RectSelectedColor = System.Drawing.Color.Transparent;
            this.flush.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.flush.Size = new System.Drawing.Size(41, 36);
            this.flush.Style = Sunny.UI.UIStyle.Custom;
            this.flush.StyleCustomMode = true;
            this.flush.Symbol = 61712;
            this.flush.SymbolSize = 25;
            this.flush.TabIndex = 6;
            this.flush.Click += new System.EventHandler(this.flush_Click);
            // 
            // home
            // 
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Dock = System.Windows.Forms.DockStyle.Left;
            this.home.FillColor = System.Drawing.Color.Transparent;
            this.home.FillDisableColor = System.Drawing.Color.Transparent;
            this.home.FillHoverColor = System.Drawing.Color.Transparent;
            this.home.FillPressColor = System.Drawing.Color.Transparent;
            this.home.FillSelectedColor = System.Drawing.Color.Transparent;
            this.home.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.home.ForeColor = System.Drawing.Color.Gray;
            this.home.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.home.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.home.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.home.Location = new System.Drawing.Point(41, 0);
            this.home.MinimumSize = new System.Drawing.Size(1, 1);
            this.home.Name = "home";
            this.home.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.home.RectColor = System.Drawing.Color.Transparent;
            this.home.RectDisableColor = System.Drawing.Color.Transparent;
            this.home.RectHoverColor = System.Drawing.Color.Transparent;
            this.home.RectPressColor = System.Drawing.Color.Transparent;
            this.home.RectSelectedColor = System.Drawing.Color.Transparent;
            this.home.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.home.Size = new System.Drawing.Size(41, 36);
            this.home.Style = Sunny.UI.UIStyle.Custom;
            this.home.StyleCustomMode = true;
            this.home.Symbol = 57353;
            this.home.SymbolSize = 28;
            this.home.TabIndex = 2;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.FillColor = System.Drawing.Color.Transparent;
            this.back.FillDisableColor = System.Drawing.Color.Transparent;
            this.back.FillHoverColor = System.Drawing.Color.Transparent;
            this.back.FillPressColor = System.Drawing.Color.Transparent;
            this.back.FillSelectedColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.back.ForeColor = System.Drawing.Color.Gray;
            this.back.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.back.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.back.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.MinimumSize = new System.Drawing.Size(1, 1);
            this.back.Name = "back";
            this.back.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.back.RectColor = System.Drawing.Color.Transparent;
            this.back.RectDisableColor = System.Drawing.Color.Transparent;
            this.back.RectHoverColor = System.Drawing.Color.Transparent;
            this.back.RectPressColor = System.Drawing.Color.Transparent;
            this.back.RectSelectedColor = System.Drawing.Color.Transparent;
            this.back.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.back.Size = new System.Drawing.Size(41, 36);
            this.back.Style = Sunny.UI.UIStyle.Custom;
            this.back.StyleCustomMode = true;
            this.back.Symbol = 52;
            this.back.SymbolSize = 40;
            this.back.TabIndex = 0;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AllFile
            // 
            this.AllFile.AllowColumnReorder = true;
            this.AllFile.AllowDrop = true;
            this.AllFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllFile.BackColor = System.Drawing.Color.White;
            this.AllFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllFile.ContextMenuStrip = this.fileOperator;
            this.AllFile.FullRowSelect = true;
            this.AllFile.HideSelection = false;
            this.AllFile.LabelEdit = true;
            this.AllFile.LargeImageList = this.big;
            this.AllFile.Location = new System.Drawing.Point(0, 39);
            this.AllFile.Name = "AllFile";
            this.AllFile.ShowItemToolTips = true;
            this.AllFile.Size = new System.Drawing.Size(798, 324);
            this.AllFile.SmallImageList = this.small;
            this.AllFile.TabIndex = 1;
            this.AllFile.UseCompatibleStateImageBehavior = false;
            this.AllFile.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.AllFile.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.AllFile.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.AllFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            this.AllFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // fileOperator
            // 
            this.fileOperator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fileOperator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.重命名ToolStripMenuItem,
            this.新建文件夹ToolStripMenuItem,
            this.移动ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.显示ToolStripMenuItem});
            this.fileOperator.Name = "fileOperator";
            this.fileOperator.Size = new System.Drawing.Size(137, 158);
            this.fileOperator.Opening += new System.ComponentModel.CancelEventHandler(this.fileOperator_Opening);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            this.新建文件夹ToolStripMenuItem.Click += new System.EventHandler(this.新建文件夹ToolStripMenuItem_Click);
            // 
            // 移动ToolStripMenuItem
            // 
            this.移动ToolStripMenuItem.Name = "移动ToolStripMenuItem";
            this.移动ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.移动ToolStripMenuItem.Text = "移动";
            this.移动ToolStripMenuItem.Click += new System.EventHandler(this.移动ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.详细信息ToolStripMenuItem,
            this.列表ToolStripMenuItem});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示ToolStripMenuItem.Text = "查看";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Checked = true;
            this.大图标ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.大图标ToolStripMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.小图标ToolStripMenuItem_Click);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.详细信息ToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.列表ToolStripMenuItem_Click);
            // 
            // big
            // 
            this.big.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("big.ImageStream")));
            this.big.TransparentColor = System.Drawing.SystemColors.Control;
            this.big.Images.SetKeyName(0, "FolderTypeBig.png");
            this.big.Images.SetKeyName(1, "TxtTypeBig.png");
            this.big.Images.SetKeyName(2, "ImgTypeBig.png");
            this.big.Images.SetKeyName(3, "MusicTypeBig.png");
            this.big.Images.SetKeyName(4, "VideoTypeBig.png");
            this.big.Images.SetKeyName(5, "DocTypeBig.png");
            this.big.Images.SetKeyName(6, "PptTypeBig.png");
            this.big.Images.SetKeyName(7, "XlsTypeBig.png");
            this.big.Images.SetKeyName(8, "PdfTypeBig.png");
            this.big.Images.SetKeyName(9, "RarTypeBig.png");
            this.big.Images.SetKeyName(10, "ExeTypeBig.png");
            this.big.Images.SetKeyName(11, "OtherTypeBig.png");
            // 
            // small
            // 
            this.small.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("small.ImageStream")));
            this.small.TransparentColor = System.Drawing.SystemColors.Control;
            this.small.Images.SetKeyName(0, "FolderType.png");
            this.small.Images.SetKeyName(1, "TxtType.png");
            this.small.Images.SetKeyName(2, "ImgType.png");
            this.small.Images.SetKeyName(3, "MusicType.png");
            this.small.Images.SetKeyName(4, "VideoType.png");
            this.small.Images.SetKeyName(5, "DocType.png");
            this.small.Images.SetKeyName(6, "PptType.png");
            this.small.Images.SetKeyName(7, "XlsType.png");
            this.small.Images.SetKeyName(8, "PdfType.png");
            this.small.Images.SetKeyName(9, "RarType.png");
            this.small.Images.SetKeyName(10, "ExeType.png");
            this.small.Images.SetKeyName(11, "OtherType.png");
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(-2, 352);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(800, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.StyleCustomMode = true;
            this.uiLine1.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file.png");
            this.imageList1.Images.SetKeyName(1, "img.png");
            this.imageList1.Images.SetKeyName(2, "movie.png");
            this.imageList1.Images.SetKeyName(3, "music.png");
            this.imageList1.Images.SetKeyName(4, "doc.png");
            this.imageList1.Images.SetKeyName(5, "other.png");
            // 
            // pathSelector
            // 
            this.pathSelector.Description = "下载到...";
            // 
            // fileSelector
            // 
            this.fileSelector.FileNames = null;
            this.fileSelector.Filer = "";
            this.fileSelector.InitialDirectory = "";
            this.fileSelector.SelectPath = null;
            // 
            // PathSelectorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.uiTabControlMenu1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathSelectorDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "请选择路径";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.全部文件.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.fileOperator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private Sunny.UI.UIPanel uiPanel1;
        public System.Windows.Forms.ListView AllFile;
        private System.Windows.Forms.ImageList small;
        private System.Windows.Forms.ImageList big;
        private System.Windows.Forms.ImageList imageList1;
        private Sunny.UI.UISymbolButton back;
        private Sunny.UI.UISymbolButton home;
        private Sunny.UI.UILabel path;
        private Sunny.UI.UISymbolButton flush;
        private System.Windows.Forms.ContextMenuStrip fileOperator;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog pathSelector;
        private OpenFileDialogEx fileSelector;
        public System.Windows.Forms.TabPage 全部文件;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private Sunny.UI.UIProgressIndicator loading;
        private Sunny.UI.UITextBox createFolder;
        private System.Windows.Forms.ToolStripMenuItem 移动ToolStripMenuItem;
#pragma warning disable CS0108 // 成员隐藏继承的成员；缺少关键字 new
        private Sunny.UI.UIButton Enter;
        private Sunny.UI.UILine uiLine1;
#pragma warning restore CS0108 // 成员隐藏继承的成员；缺少关键字 new
    }
}