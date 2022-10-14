﻿
using System.Windows.Forms;

namespace WebDisk_Client.UI
{
    partial class HomePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.全部文件 = new System.Windows.Forms.TabPage();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.loading = new Sunny.UI.UIProgressIndicator();
            this.createFolder = new Sunny.UI.UITextBox();
            this.sharing = new Sunny.UI.UISymbolButton();
            this.path = new Sunny.UI.UILabel();
            this.flush = new Sunny.UI.UISymbolButton();
            this.upload = new Sunny.UI.UISymbolButton();
            this.download = new Sunny.UI.UISymbolButton();
            this.home = new Sunny.UI.UISymbolButton();
            this.back = new Sunny.UI.UISymbolButton();
            this.AllFile = new System.Windows.Forms.ListView();
            this.fileOperator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.上传ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分享ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.big = new System.Windows.Forms.ImageList(this.components);
            this.small = new System.Windows.Forms.ImageList(this.components);
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.Capacity = new Sunny.UI.UIProcessBar();
            this.CapacityInfo = new Sunny.UI.UILabel();
            this.文档 = new System.Windows.Forms.TabPage();
            this.Document = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.图片 = new System.Windows.Forms.TabPage();
            this.Picture = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifyTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.视频 = new System.Windows.Forms.TabPage();
            this.Video = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.音乐 = new System.Windows.Forms.TabPage();
            this.Music = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.其他 = new System.Windows.Forms.TabPage();
            this.Other = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pathSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSelector = new WebDisk_Client.UI.OpenFileDialogEx();
            this.uiTabControlMenu1.SuspendLayout();
            this.全部文件.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.fileOperator.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.文档.SuspendLayout();
            this.图片.SuspendLayout();
            this.视频.SuspendLayout();
            this.音乐.SuspendLayout();
            this.其他.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.全部文件);
            this.uiTabControlMenu1.Controls.Add(this.文档);
            this.uiTabControlMenu1.Controls.Add(this.图片);
            this.uiTabControlMenu1.Controls.Add(this.视频);
            this.uiTabControlMenu1.Controls.Add(this.音乐);
            this.uiTabControlMenu1.Controls.Add(this.其他);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTabControlMenu1.ImageList = this.imageList1;
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 150);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(800, 450);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControlMenu1.StyleCustomMode = true;
            this.uiTabControlMenu1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabIndex = 0;
            this.uiTabControlMenu1.TabSelectedColor = System.Drawing.Color.Azure;
            this.uiTabControlMenu1.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiTabControlMenu1.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiTabControlMenu1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.uiTabControlMenu1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // 全部文件
            // 
            this.全部文件.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.全部文件.Controls.Add(this.uiPanel1);
            this.全部文件.Controls.Add(this.AllFile);
            this.全部文件.Controls.Add(this.uiPanel2);
            this.全部文件.ImageIndex = 0;
            this.全部文件.Location = new System.Drawing.Point(151, 0);
            this.全部文件.Name = "全部文件";
            this.全部文件.Size = new System.Drawing.Size(649, 450);
            this.全部文件.TabIndex = 1;
            this.全部文件.Text = "全部文件";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.White;
            this.uiPanel1.Controls.Add(this.loading);
            this.uiPanel1.Controls.Add(this.createFolder);
            this.uiPanel1.Controls.Add(this.sharing);
            this.uiPanel1.Controls.Add(this.path);
            this.uiPanel1.Controls.Add(this.flush);
            this.uiPanel1.Controls.Add(this.upload);
            this.uiPanel1.Controls.Add(this.download);
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
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(649, 36);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loading
            // 
            this.loading.Dock = System.Windows.Forms.DockStyle.Right;
            this.loading.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.loading.Location = new System.Drawing.Point(270, 0);
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
            this.createFolder.Location = new System.Drawing.Point(308, 0);
            this.createFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createFolder.Maximum = 2147483647D;
            this.createFolder.Minimum = -2147483648D;
            this.createFolder.MinimumSize = new System.Drawing.Size(1, 1);
            this.createFolder.Name = "createFolder";
            this.createFolder.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.createFolder.RectColor = System.Drawing.Color.Transparent;
            this.createFolder.Size = new System.Drawing.Size(116, 41);
            this.createFolder.Style = Sunny.UI.UIStyle.Custom;
            this.createFolder.StyleCustomMode = true;
            this.createFolder.Symbol = 111;
            this.createFolder.TabIndex = 17;
            this.createFolder.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.createFolder.Watermark = "新建文件夹";
            this.createFolder.DoEnter += new System.EventHandler(this.createFolder_DoEnter);
            this.createFolder.Enter += new System.EventHandler(this.createFolder_Enter);
            // 
            // sharing
            // 
            this.sharing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sharing.Dock = System.Windows.Forms.DockStyle.Right;
            this.sharing.FillColor = System.Drawing.Color.Transparent;
            this.sharing.FillDisableColor = System.Drawing.Color.Transparent;
            this.sharing.FillHoverColor = System.Drawing.Color.Transparent;
            this.sharing.FillPressColor = System.Drawing.Color.Transparent;
            this.sharing.FillSelectedColor = System.Drawing.Color.Transparent;
            this.sharing.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharing.ForeColor = System.Drawing.Color.Gray;
            this.sharing.ForeDisableColor = System.Drawing.Color.White;
            this.sharing.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sharing.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sharing.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sharing.Location = new System.Drawing.Point(424, 0);
            this.sharing.MinimumSize = new System.Drawing.Size(1, 1);
            this.sharing.Name = "sharing";
            this.sharing.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.sharing.RectColor = System.Drawing.Color.Transparent;
            this.sharing.RectDisableColor = System.Drawing.Color.Transparent;
            this.sharing.RectHoverColor = System.Drawing.Color.Transparent;
            this.sharing.RectPressColor = System.Drawing.Color.Transparent;
            this.sharing.RectSelectedColor = System.Drawing.Color.Transparent;
            this.sharing.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.sharing.Size = new System.Drawing.Size(75, 36);
            this.sharing.Style = Sunny.UI.UIStyle.Custom;
            this.sharing.StyleCustomMode = true;
            this.sharing.Symbol = 57387;
            this.sharing.SymbolSize = 25;
            this.sharing.TabIndex = 15;
            this.sharing.Text = "分享";
            this.sharing.Visible = false;
            this.sharing.Click += new System.EventHandler(this.sharing_Click);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path.AutoEllipsis = true;
            this.path.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.Location = new System.Drawing.Point(123, 0);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(376, 36);
            this.path.Style = Sunny.UI.UIStyle.Custom;
            this.path.StyleCustomMode = true;
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
            this.flush.ForeDisableColor = System.Drawing.Color.White;
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
            // upload
            // 
            this.upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upload.Dock = System.Windows.Forms.DockStyle.Right;
            this.upload.FillColor = System.Drawing.Color.Transparent;
            this.upload.FillDisableColor = System.Drawing.Color.Transparent;
            this.upload.FillHoverColor = System.Drawing.Color.Transparent;
            this.upload.FillPressColor = System.Drawing.Color.Transparent;
            this.upload.FillSelectedColor = System.Drawing.Color.Transparent;
            this.upload.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.Color.Gray;
            this.upload.ForeDisableColor = System.Drawing.Color.White;
            this.upload.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.upload.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.upload.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.upload.Location = new System.Drawing.Point(499, 0);
            this.upload.MinimumSize = new System.Drawing.Size(1, 1);
            this.upload.Name = "upload";
            this.upload.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.upload.RectColor = System.Drawing.Color.Transparent;
            this.upload.RectDisableColor = System.Drawing.Color.Transparent;
            this.upload.RectHoverColor = System.Drawing.Color.Transparent;
            this.upload.RectPressColor = System.Drawing.Color.Transparent;
            this.upload.RectSelectedColor = System.Drawing.Color.Transparent;
            this.upload.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.upload.Size = new System.Drawing.Size(75, 36);
            this.upload.Style = Sunny.UI.UIStyle.Custom;
            this.upload.StyleCustomMode = true;
            this.upload.Symbol = 57347;
            this.upload.SymbolSize = 30;
            this.upload.TabIndex = 4;
            this.upload.Text = "上传";
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // download
            // 
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.Dock = System.Windows.Forms.DockStyle.Right;
            this.download.FillColor = System.Drawing.Color.Transparent;
            this.download.FillDisableColor = System.Drawing.Color.Transparent;
            this.download.FillHoverColor = System.Drawing.Color.Transparent;
            this.download.FillPressColor = System.Drawing.Color.Transparent;
            this.download.FillSelectedColor = System.Drawing.Color.Transparent;
            this.download.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.ForeColor = System.Drawing.Color.Gray;
            this.download.ForeDisableColor = System.Drawing.Color.White;
            this.download.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.download.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.download.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.download.Location = new System.Drawing.Point(574, 0);
            this.download.MinimumSize = new System.Drawing.Size(1, 1);
            this.download.Name = "download";
            this.download.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.download.RectColor = System.Drawing.Color.Transparent;
            this.download.RectDisableColor = System.Drawing.Color.Transparent;
            this.download.RectHoverColor = System.Drawing.Color.Transparent;
            this.download.RectPressColor = System.Drawing.Color.Transparent;
            this.download.RectSelectedColor = System.Drawing.Color.Transparent;
            this.download.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.download.Size = new System.Drawing.Size(75, 36);
            this.download.Style = Sunny.UI.UIStyle.Custom;
            this.download.StyleCustomMode = true;
            this.download.Symbol = 57348;
            this.download.SymbolSize = 30;
            this.download.TabIndex = 3;
            this.download.Text = "下载";
            this.download.Visible = false;
            this.download.Click += new System.EventHandler(this.download_Click);
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
            this.home.ForeDisableColor = System.Drawing.Color.White;
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
            this.back.ForeDisableColor = System.Drawing.Color.White;
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
            this.AllFile.Size = new System.Drawing.Size(649, 383);
            this.AllFile.SmallImageList = this.small;
            this.AllFile.TabIndex = 1;
            this.AllFile.UseCompatibleStateImageBehavior = false;
            this.AllFile.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.AllFile.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.AllFile.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.AllFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            this.AllFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.AllFile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AllFile_MouseUp);
            // 
            // fileOperator
            // 
            this.fileOperator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fileOperator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上传ToolStripMenuItem,
            this.下载ToolStripMenuItem,
            this.下载到ToolStripMenuItem,
            this.分享ToolStripMenuItem,
            this.移动ToolStripMenuItem,
            this.重命名ToolStripMenuItem,
            this.新建文件夹ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.显示ToolStripMenuItem});
            this.fileOperator.Name = "fileOperator";
            this.fileOperator.Size = new System.Drawing.Size(211, 404);
            this.fileOperator.Opening += new System.ComponentModel.CancelEventHandler(this.fileOperator_Opening);
            // 
            // 上传ToolStripMenuItem
            // 
            this.上传ToolStripMenuItem.Name = "上传ToolStripMenuItem";
            this.上传ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.上传ToolStripMenuItem.Text = "上传";
            this.上传ToolStripMenuItem.Click += new System.EventHandler(this.上传ToolStripMenuItem_Click);
            // 
            // 下载ToolStripMenuItem
            // 
            this.下载ToolStripMenuItem.Name = "下载ToolStripMenuItem";
            this.下载ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.下载ToolStripMenuItem.Text = "下载";
            this.下载ToolStripMenuItem.Click += new System.EventHandler(this.下载ToolStripMenuItem_Click);
            // 
            // 下载到ToolStripMenuItem
            // 
            this.下载到ToolStripMenuItem.Name = "下载到ToolStripMenuItem";
            this.下载到ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.下载到ToolStripMenuItem.Text = "下载到...";
            this.下载到ToolStripMenuItem.Click += new System.EventHandler(this.下载到ToolStripMenuItem_Click);
            // 
            // 分享ToolStripMenuItem
            // 
            this.分享ToolStripMenuItem.Name = "分享ToolStripMenuItem";
            this.分享ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.分享ToolStripMenuItem.Text = "分享";
            this.分享ToolStripMenuItem.Click += new System.EventHandler(this.分享ToolStripMenuItem_Click);
            // 
            // 移动ToolStripMenuItem
            // 
            this.移动ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.取消ToolStripMenuItem});
            this.移动ToolStripMenuItem.Name = "移动ToolStripMenuItem";
            this.移动ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.移动ToolStripMenuItem.Text = "移动";
            this.移动ToolStripMenuItem.Click += new System.EventHandler(this.移动ToolStripMenuItem_Click);
            // 
            // 取消ToolStripMenuItem
            // 
            this.取消ToolStripMenuItem.Name = "取消ToolStripMenuItem";
            this.取消ToolStripMenuItem.Size = new System.Drawing.Size(197, 44);
            this.取消ToolStripMenuItem.Text = "取消";
            this.取消ToolStripMenuItem.Visible = false;
            this.取消ToolStripMenuItem.Click += new System.EventHandler(this.取消ToolStripMenuItem_Click);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            this.新建文件夹ToolStripMenuItem.Click += new System.EventHandler(this.新建文件夹ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
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
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(210, 40);
            this.显示ToolStripMenuItem.Text = "查看";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Checked = true;
            this.大图标ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(245, 44);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.大图标ToolStripMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(245, 44);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.小图标ToolStripMenuItem_Click);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(245, 44);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.详细信息ToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(245, 44);
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
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Controls.Add(this.Capacity);
            this.uiPanel2.Controls.Add(this.CapacityInfo);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel2.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel2.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 420);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(649, 30);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.StyleCustomMode = true;
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Capacity
            // 
            this.Capacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Capacity.DecimalCount = 0;
            this.Capacity.FillColor = System.Drawing.Color.White;
            this.Capacity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacity.ForeColor = System.Drawing.Color.DimGray;
            this.Capacity.Location = new System.Drawing.Point(270, 8);
            this.Capacity.Margin = new System.Windows.Forms.Padding(2);
            this.Capacity.MinimumSize = new System.Drawing.Size(58, 4);
            this.Capacity.Name = "Capacity";
            this.Capacity.Radius = 10;
            this.Capacity.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Capacity.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.Capacity.Size = new System.Drawing.Size(243, 15);
            this.Capacity.Style = Sunny.UI.UIStyle.Custom;
            this.Capacity.StyleCustomMode = true;
            this.Capacity.TabIndex = 4;
            this.Capacity.Text = "0%";
            // 
            // CapacityInfo
            // 
            this.CapacityInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CapacityInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityInfo.Location = new System.Drawing.Point(516, 4);
            this.CapacityInfo.Name = "CapacityInfo";
            this.CapacityInfo.Size = new System.Drawing.Size(131, 23);
            this.CapacityInfo.Style = Sunny.UI.UIStyle.Custom;
            this.CapacityInfo.TabIndex = 3;
            this.CapacityInfo.Text = "读取中...";
            this.CapacityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 文档
            // 
            this.文档.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.文档.Controls.Add(this.Document);
            this.文档.ImageIndex = 4;
            this.文档.Location = new System.Drawing.Point(151, 0);
            this.文档.Name = "文档";
            this.文档.Size = new System.Drawing.Size(649, 450);
            this.文档.TabIndex = 5;
            this.文档.Text = "文档";
            // 
            // Document
            // 
            this.Document.AllowColumnReorder = true;
            this.Document.AllowDrop = true;
            this.Document.BackColor = System.Drawing.Color.White;
            this.Document.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Document.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.Document.ContextMenuStrip = this.fileOperator;
            this.Document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Document.FullRowSelect = true;
            this.Document.HideSelection = false;
            this.Document.LabelEdit = true;
            this.Document.LargeImageList = this.big;
            this.Document.Location = new System.Drawing.Point(0, 0);
            this.Document.Name = "Document";
            this.Document.ShowItemToolTips = true;
            this.Document.Size = new System.Drawing.Size(649, 450);
            this.Document.SmallImageList = this.small;
            this.Document.TabIndex = 3;
            this.Document.UseCompatibleStateImageBehavior = false;
            this.Document.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.Document.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.Document.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.Document.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "文件名";
            this.columnHeader11.Width = 112;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "文件大小";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "修改时间";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "文件类型";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "路径";
            // 
            // 图片
            // 
            this.图片.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.图片.Controls.Add(this.Picture);
            this.图片.ImageIndex = 1;
            this.图片.Location = new System.Drawing.Point(151, 0);
            this.图片.Name = "图片";
            this.图片.Size = new System.Drawing.Size(649, 450);
            this.图片.TabIndex = 2;
            this.图片.Text = "图片";
            // 
            // Picture
            // 
            this.Picture.AllowColumnReorder = true;
            this.Picture.AllowDrop = true;
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Picture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.fileSize,
            this.modifyTime,
            this.fileType,
            this.filePath});
            this.Picture.ContextMenuStrip = this.fileOperator;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.FullRowSelect = true;
            this.Picture.HideSelection = false;
            this.Picture.LabelEdit = true;
            this.Picture.LargeImageList = this.big;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.ShowItemToolTips = true;
            this.Picture.Size = new System.Drawing.Size(649, 450);
            this.Picture.SmallImageList = this.small;
            this.Picture.TabIndex = 3;
            this.Picture.UseCompatibleStateImageBehavior = false;
            this.Picture.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.Picture.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.Picture.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.Picture.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            // 
            // fileName
            // 
            this.fileName.Text = "文件名";
            this.fileName.Width = 112;
            // 
            // fileSize
            // 
            this.fileSize.Text = "文件大小";
            // 
            // modifyTime
            // 
            this.modifyTime.Text = "修改时间";
            // 
            // fileType
            // 
            this.fileType.Text = "文件类型";
            // 
            // filePath
            // 
            this.filePath.Text = "路径";
            // 
            // 视频
            // 
            this.视频.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.视频.Controls.Add(this.Video);
            this.视频.ImageIndex = 2;
            this.视频.Location = new System.Drawing.Point(151, 0);
            this.视频.Name = "视频";
            this.视频.Size = new System.Drawing.Size(649, 450);
            this.视频.TabIndex = 3;
            this.视频.Text = "视频";
            // 
            // Video
            // 
            this.Video.AllowColumnReorder = true;
            this.Video.AllowDrop = true;
            this.Video.BackColor = System.Drawing.Color.White;
            this.Video.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Video.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Video.ContextMenuStrip = this.fileOperator;
            this.Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Video.FullRowSelect = true;
            this.Video.HideSelection = false;
            this.Video.LabelEdit = true;
            this.Video.LargeImageList = this.big;
            this.Video.Location = new System.Drawing.Point(0, 0);
            this.Video.Name = "Video";
            this.Video.ShowItemToolTips = true;
            this.Video.Size = new System.Drawing.Size(649, 450);
            this.Video.SmallImageList = this.small;
            this.Video.TabIndex = 3;
            this.Video.UseCompatibleStateImageBehavior = false;
            this.Video.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.Video.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.Video.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.Video.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "文件大小";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "修改时间";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "文件类型";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "路径";
            // 
            // 音乐
            // 
            this.音乐.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.音乐.Controls.Add(this.Music);
            this.音乐.ImageIndex = 3;
            this.音乐.Location = new System.Drawing.Point(151, 0);
            this.音乐.Name = "音乐";
            this.音乐.Size = new System.Drawing.Size(649, 450);
            this.音乐.TabIndex = 4;
            this.音乐.Text = "音乐";
            // 
            // Music
            // 
            this.Music.AllowColumnReorder = true;
            this.Music.AllowDrop = true;
            this.Music.BackColor = System.Drawing.Color.White;
            this.Music.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Music.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.Music.ContextMenuStrip = this.fileOperator;
            this.Music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Music.FullRowSelect = true;
            this.Music.HideSelection = false;
            this.Music.LabelEdit = true;
            this.Music.LargeImageList = this.big;
            this.Music.Location = new System.Drawing.Point(0, 0);
            this.Music.Name = "Music";
            this.Music.ShowItemToolTips = true;
            this.Music.Size = new System.Drawing.Size(649, 450);
            this.Music.SmallImageList = this.small;
            this.Music.TabIndex = 3;
            this.Music.UseCompatibleStateImageBehavior = false;
            this.Music.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.Music.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.Music.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.Music.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "文件名";
            this.columnHeader6.Width = 112;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "文件大小";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "修改时间";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "文件类型";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "路径";
            // 
            // 其他
            // 
            this.其他.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.其他.Controls.Add(this.Other);
            this.其他.ImageIndex = 5;
            this.其他.Location = new System.Drawing.Point(151, 0);
            this.其他.Name = "其他";
            this.其他.Size = new System.Drawing.Size(649, 450);
            this.其他.TabIndex = 6;
            this.其他.Text = "其他";
            // 
            // Other
            // 
            this.Other.AllowColumnReorder = true;
            this.Other.AllowDrop = true;
            this.Other.BackColor = System.Drawing.Color.White;
            this.Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Other.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.Other.ContextMenuStrip = this.fileOperator;
            this.Other.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Other.FullRowSelect = true;
            this.Other.HideSelection = false;
            this.Other.LabelEdit = true;
            this.Other.LargeImageList = this.big;
            this.Other.Location = new System.Drawing.Point(0, 0);
            this.Other.Name = "Other";
            this.Other.ShowItemToolTips = true;
            this.Other.Size = new System.Drawing.Size(649, 450);
            this.Other.SmallImageList = this.small;
            this.Other.TabIndex = 3;
            this.Other.UseCompatibleStateImageBehavior = false;
            this.Other.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.Other.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.Other.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.Other.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "文件名";
            this.columnHeader16.Width = 112;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "文件大小";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "修改时间";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "文件类型";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "路径";
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
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Name = "HomePanel";
            this.RectColor = System.Drawing.Color.Transparent;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.全部文件.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.fileOperator.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.文档.ResumeLayout(false);
            this.图片.ResumeLayout(false);
            this.视频.ResumeLayout(false);
            this.音乐.ResumeLayout(false);
            this.其他.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private Sunny.UI.UIPanel uiPanel1;
        public System.Windows.Forms.ListView AllFile;
        private System.Windows.Forms.ImageList small;
        private System.Windows.Forms.ImageList big;
        private System.Windows.Forms.ImageList imageList1;
        public Sunny.UI.UISymbolButton back;
        private Sunny.UI.UISymbolButton upload;
        private Sunny.UI.UISymbolButton download;
        private Sunny.UI.UISymbolButton home;
        public Sunny.UI.UILabel path;
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
        private System.Windows.Forms.ToolStripMenuItem 下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载到ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog pathSelector;
        private OpenFileDialogEx fileSelector;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader fileSize;
        private System.Windows.Forms.ColumnHeader modifyTime;
        private System.Windows.Forms.ColumnHeader fileType;
        private System.Windows.Forms.ColumnHeader filePath;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        public System.Windows.Forms.ListView Picture;
        public System.Windows.Forms.ListView Video;
        public System.Windows.Forms.ListView Music;
        public System.Windows.Forms.ListView Document;
        public System.Windows.Forms.ListView Other;
        public System.Windows.Forms.TabPage 全部文件;
        public System.Windows.Forms.TabPage 图片;
        public System.Windows.Forms.TabPage 视频;
        public System.Windows.Forms.TabPage 音乐;
        public System.Windows.Forms.TabPage 文档;
        public System.Windows.Forms.TabPage 其他;
        private System.Windows.Forms.ToolStripMenuItem 上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移动ToolStripMenuItem;
        private Sunny.UI.UIProgressIndicator loading;
        private Sunny.UI.UITextBox createFolder;
        private Sunny.UI.UISymbolButton sharing;
        private System.Windows.Forms.ToolStripMenuItem 分享ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消ToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel CapacityInfo;
        public Sunny.UI.UIProcessBar Capacity;
    }
}