
namespace WebDisk_Client.UI.Dialog
{
    partial class TextEditDiaolog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditDiaolog));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.传输ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.格式ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.传输ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 传输ToolStripMenuItem
            // 
            this.传输ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载ToolStripMenuItem,
            this.下载到ToolStripMenuItem});
            this.传输ToolStripMenuItem.Name = "传输ToolStripMenuItem";
            this.传输ToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.传输ToolStripMenuItem.Text = "传输";
            // 
            // 下载ToolStripMenuItem
            // 
            this.下载ToolStripMenuItem.Name = "下载ToolStripMenuItem";
            this.下载ToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.下载ToolStripMenuItem.Text = "下载";
            // 
            // 下载到ToolStripMenuItem
            // 
            this.下载到ToolStripMenuItem.Name = "下载到ToolStripMenuItem";
            this.下载到ToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.下载到ToolStripMenuItem.Text = "下载到";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查找ToolStripMenuItem,
            this.替换ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.查找ToolStripMenuItem.Text = "查找";
            // 
            // 替换ToolStripMenuItem
            // 
            this.替换ToolStripMenuItem.Name = "替换ToolStripMenuItem";
            this.替换ToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.替换ToolStripMenuItem.Text = "替换";
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行ToolStripMenuItem,
            this.字体ToolStripMenuItem});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // 自动换行ToolStripMenuItem
            // 
            this.自动换行ToolStripMenuItem.Name = "自动换行ToolStripMenuItem";
            this.自动换行ToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.自动换行ToolStripMenuItem.Text = "自动换行";
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.字体ToolStripMenuItem.Text = "字体";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(2, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(713, 418);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // TextEditDiaolog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 484);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditDiaolog";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = resources.GetString("$this.Text");
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 传输ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动换行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}