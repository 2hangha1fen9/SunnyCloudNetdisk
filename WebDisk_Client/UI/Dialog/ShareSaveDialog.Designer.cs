
namespace WebDisk_Client.UI.Dialog
{
    partial class ShareSaveDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShareSaveDialog));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Path = new Sunny.UI.UILabel();
            this.Switch = new Sunny.UI.UIButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.big = new System.Windows.Forms.ImageList(this.components);
            this.small = new System.Windows.Forms.ImageList(this.components);
            this.Ok = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel1.Location = new System.Drawing.Point(17, 309);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "保存到:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Path
            // 
            this.Path.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Path.ForeColor = System.Drawing.Color.Gray;
            this.Path.Location = new System.Drawing.Point(85, 309);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(289, 23);
            this.Path.Style = Sunny.UI.UIStyle.Custom;
            this.Path.TabIndex = 2;
            this.Path.Text = "/";
            this.Path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Switch
            // 
            this.Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Switch.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Switch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Switch.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Switch.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Switch.Location = new System.Drawing.Point(419, 304);
            this.Switch.MinimumSize = new System.Drawing.Size(1, 1);
            this.Switch.Name = "Switch";
            this.Switch.Radius = 33;
            this.Switch.RectColor = System.Drawing.Color.Transparent;
            this.Switch.RectDisableColor = System.Drawing.Color.Transparent;
            this.Switch.RectHoverColor = System.Drawing.Color.Transparent;
            this.Switch.RectPressColor = System.Drawing.Color.Transparent;
            this.Switch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Switch.Size = new System.Drawing.Size(75, 33);
            this.Switch.Style = Sunny.UI.UIStyle.Custom;
            this.Switch.StyleCustomMode = true;
            this.Switch.TabIndex = 3;
            this.Switch.Text = "选择";
            this.Switch.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.big;
            this.listView1.Location = new System.Drawing.Point(0, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 253);
            this.listView1.SmallImageList = this.small;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // Ok
            // 
            this.Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Ok.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Ok.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Ok.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Ok.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Ok.Location = new System.Drawing.Point(509, 304);
            this.Ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.Ok.Name = "Ok";
            this.Ok.Radius = 33;
            this.Ok.RectColor = System.Drawing.Color.Transparent;
            this.Ok.RectDisableColor = System.Drawing.Color.Transparent;
            this.Ok.RectHoverColor = System.Drawing.Color.Transparent;
            this.Ok.RectPressColor = System.Drawing.Color.Transparent;
            this.Ok.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Ok.Size = new System.Drawing.Size(75, 33);
            this.Ok.Style = Sunny.UI.UIStyle.Custom;
            this.Ok.StyleCustomMode = true;
            this.Ok.TabIndex = 4;
            this.Ok.Text = "确定";
            this.Ok.Click += new System.EventHandler(this.uiButton2_Click_1);
            // 
            // ShareSaveDialog
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 355);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.listView1);
            this.Name = "ShareSaveDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "保存文件";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Load += new System.EventHandler(this.ShareSaveDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel Path;
        private Sunny.UI.UIButton Switch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList big;
        private System.Windows.Forms.ImageList small;
        private Sunny.UI.UIButton Ok;
    }
}