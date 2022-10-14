
namespace WebDisk_Admin.UI
{
    partial class TransPanel
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
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.传输队列 = new System.Windows.Forms.TabPage();
            this.Transing = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.AllCancel = new Sunny.UI.UISymbolButton();
            this.AllStart = new Sunny.UI.UISymbolButton();
            this.AllStop = new Sunny.UI.UISymbolButton();
            this.已完成 = new System.Windows.Forms.TabPage();
            this.Completed = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.AllDel = new Sunny.UI.UISymbolButton();
            this.uiTabControlMenu1.SuspendLayout();
            this.传输队列.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.已完成.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.传输队列);
            this.uiTabControlMenu1.Controls.Add(this.已完成);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.FillColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.uiTabControlMenu1.TabIndex = 1;
            this.uiTabControlMenu1.TabSelectedColor = System.Drawing.Color.Azure;
            this.uiTabControlMenu1.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiTabControlMenu1.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uiTabControlMenu1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.uiTabControlMenu1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // 传输队列
            // 
            this.传输队列.AutoScroll = true;
            this.传输队列.BackColor = System.Drawing.Color.White;
            this.传输队列.Controls.Add(this.Transing);
            this.传输队列.Controls.Add(this.uiPanel1);
            this.传输队列.ImageIndex = 4;
            this.传输队列.Location = new System.Drawing.Point(151, 0);
            this.传输队列.Name = "传输队列";
            this.传输队列.Size = new System.Drawing.Size(649, 450);
            this.传输队列.TabIndex = 5;
            this.传输队列.Text = "传输队列";
            // 
            // Transing
            // 
            this.Transing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transing.AutoScroll = true;
            this.Transing.FillColor = System.Drawing.Color.Transparent;
            this.Transing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Transing.ForeDisableColor = System.Drawing.Color.Transparent;
            this.Transing.Location = new System.Drawing.Point(0, 36);
            this.Transing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Transing.MinimumSize = new System.Drawing.Size(1, 1);
            this.Transing.Name = "Transing";
            this.Transing.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Transing.RectColor = System.Drawing.Color.Transparent;
            this.Transing.RectDisableColor = System.Drawing.Color.Transparent;
            this.Transing.Size = new System.Drawing.Size(649, 414);
            this.Transing.Style = Sunny.UI.UIStyle.Custom;
            this.Transing.StyleCustomMode = true;
            this.Transing.TabIndex = 1;
            this.Transing.Text = null;
            this.Transing.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel1.Controls.Add(this.AllCancel);
            this.uiPanel1.Controls.Add(this.AllStart);
            this.uiPanel1.Controls.Add(this.AllStop);
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.uiPanel1.ForeDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(649, 35);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllCancel
            // 
            this.AllCancel.BackColor = System.Drawing.Color.Transparent;
            this.AllCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AllCancel.FillColor = System.Drawing.Color.Transparent;
            this.AllCancel.FillDisableColor = System.Drawing.Color.Transparent;
            this.AllCancel.FillHoverColor = System.Drawing.Color.Transparent;
            this.AllCancel.FillPressColor = System.Drawing.Color.Transparent;
            this.AllCancel.FillSelectedColor = System.Drawing.Color.Transparent;
            this.AllCancel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AllCancel.ForeColor = System.Drawing.Color.Gray;
            this.AllCancel.ForeHoverColor = System.Drawing.Color.Orange;
            this.AllCancel.ForePressColor = System.Drawing.Color.Orange;
            this.AllCancel.ForeSelectedColor = System.Drawing.Color.Orange;
            this.AllCancel.Location = new System.Drawing.Point(358, 0);
            this.AllCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.AllCancel.Name = "AllCancel";
            this.AllCancel.RectColor = System.Drawing.Color.Transparent;
            this.AllCancel.RectDisableColor = System.Drawing.Color.Transparent;
            this.AllCancel.RectHoverColor = System.Drawing.Color.Transparent;
            this.AllCancel.RectPressColor = System.Drawing.Color.Transparent;
            this.AllCancel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.AllCancel.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.AllCancel.Size = new System.Drawing.Size(103, 35);
            this.AllCancel.Style = Sunny.UI.UIStyle.Custom;
            this.AllCancel.StyleCustomMode = true;
            this.AllCancel.Symbol = 77;
            this.AllCancel.SymbolSize = 35;
            this.AllCancel.TabIndex = 3;
            this.AllCancel.Text = "全部取消";
            this.AllCancel.Click += new System.EventHandler(this.AllCancel_Click);
            // 
            // AllStart
            // 
            this.AllStart.BackColor = System.Drawing.Color.Transparent;
            this.AllStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.AllStart.FillColor = System.Drawing.Color.Transparent;
            this.AllStart.FillDisableColor = System.Drawing.Color.Transparent;
            this.AllStart.FillHoverColor = System.Drawing.Color.Transparent;
            this.AllStart.FillPressColor = System.Drawing.Color.Transparent;
            this.AllStart.FillSelectedColor = System.Drawing.Color.Transparent;
            this.AllStart.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AllStart.ForeColor = System.Drawing.Color.Gray;
            this.AllStart.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AllStart.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AllStart.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AllStart.Location = new System.Drawing.Point(461, 0);
            this.AllStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.AllStart.Name = "AllStart";
            this.AllStart.RectColor = System.Drawing.Color.Transparent;
            this.AllStart.RectDisableColor = System.Drawing.Color.Transparent;
            this.AllStart.RectHoverColor = System.Drawing.Color.Transparent;
            this.AllStart.RectPressColor = System.Drawing.Color.Transparent;
            this.AllStart.RectSelectedColor = System.Drawing.Color.Transparent;
            this.AllStart.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.AllStart.Size = new System.Drawing.Size(100, 35);
            this.AllStart.Style = Sunny.UI.UIStyle.Custom;
            this.AllStart.StyleCustomMode = true;
            this.AllStart.Symbol = 61516;
            this.AllStart.SymbolSize = 20;
            this.AllStart.TabIndex = 2;
            this.AllStart.Text = "全部开始";
            this.AllStart.Click += new System.EventHandler(this.AllStart_Click);
            // 
            // AllStop
            // 
            this.AllStop.BackColor = System.Drawing.Color.Transparent;
            this.AllStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.AllStop.FillColor = System.Drawing.Color.Transparent;
            this.AllStop.FillDisableColor = System.Drawing.Color.Transparent;
            this.AllStop.FillHoverColor = System.Drawing.Color.Transparent;
            this.AllStop.FillPressColor = System.Drawing.Color.Transparent;
            this.AllStop.FillSelectedColor = System.Drawing.Color.Transparent;
            this.AllStop.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AllStop.ForeColor = System.Drawing.Color.Gray;
            this.AllStop.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AllStop.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AllStop.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AllStop.Location = new System.Drawing.Point(561, 0);
            this.AllStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.AllStop.Name = "AllStop";
            this.AllStop.RectColor = System.Drawing.Color.Transparent;
            this.AllStop.RectDisableColor = System.Drawing.Color.Transparent;
            this.AllStop.RectHoverColor = System.Drawing.Color.Transparent;
            this.AllStop.RectPressColor = System.Drawing.Color.Transparent;
            this.AllStop.RectSelectedColor = System.Drawing.Color.Transparent;
            this.AllStop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.AllStop.Size = new System.Drawing.Size(88, 35);
            this.AllStop.Style = Sunny.UI.UIStyle.Custom;
            this.AllStop.StyleCustomMode = true;
            this.AllStop.Symbol = 61515;
            this.AllStop.SymbolSize = 20;
            this.AllStop.TabIndex = 0;
            this.AllStop.Text = "全部暂停";
            this.AllStop.Click += new System.EventHandler(this.AllStop_Click);
            // 
            // 已完成
            // 
            this.已完成.BackColor = System.Drawing.Color.White;
            this.已完成.Controls.Add(this.Completed);
            this.已完成.Controls.Add(this.uiPanel2);
            this.已完成.ImageIndex = 5;
            this.已完成.Location = new System.Drawing.Point(151, 0);
            this.已完成.Name = "已完成";
            this.已完成.Size = new System.Drawing.Size(649, 450);
            this.已完成.TabIndex = 6;
            this.已完成.Text = "已完成";
            // 
            // Completed
            // 
            this.Completed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Completed.AutoScroll = true;
            this.Completed.FillColor = System.Drawing.Color.Transparent;
            this.Completed.FillDisableColor = System.Drawing.Color.Transparent;
            this.Completed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Completed.Location = new System.Drawing.Point(0, 36);
            this.Completed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Completed.MinimumSize = new System.Drawing.Size(1, 1);
            this.Completed.Name = "Completed";
            this.Completed.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Completed.RectColor = System.Drawing.Color.Transparent;
            this.Completed.RectDisableColor = System.Drawing.Color.Transparent;
            this.Completed.Size = new System.Drawing.Size(649, 414);
            this.Completed.Style = Sunny.UI.UIStyle.Custom;
            this.Completed.StyleCustomMode = true;
            this.Completed.TabIndex = 2;
            this.Completed.Text = null;
            this.Completed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel2.Controls.Add(this.AllDel);
            this.uiPanel2.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel2.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.uiPanel2.ForeDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(649, 35);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.StyleCustomMode = true;
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllDel
            // 
            this.AllDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AllDel.FillColor = System.Drawing.Color.Transparent;
            this.AllDel.FillDisableColor = System.Drawing.Color.Transparent;
            this.AllDel.FillHoverColor = System.Drawing.Color.Transparent;
            this.AllDel.FillPressColor = System.Drawing.Color.Transparent;
            this.AllDel.FillSelectedColor = System.Drawing.Color.Transparent;
            this.AllDel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AllDel.ForeColor = System.Drawing.Color.Gray;
            this.AllDel.ForeHoverColor = System.Drawing.Color.Orange;
            this.AllDel.ForePressColor = System.Drawing.Color.Orange;
            this.AllDel.ForeSelectedColor = System.Drawing.Color.Orange;
            this.AllDel.Location = new System.Drawing.Point(507, 0);
            this.AllDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.AllDel.Name = "AllDel";
            this.AllDel.RectColor = System.Drawing.Color.Transparent;
            this.AllDel.RectDisableColor = System.Drawing.Color.Transparent;
            this.AllDel.RectHoverColor = System.Drawing.Color.Transparent;
            this.AllDel.RectPressColor = System.Drawing.Color.Transparent;
            this.AllDel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.AllDel.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.AllDel.Size = new System.Drawing.Size(142, 35);
            this.AllDel.Style = Sunny.UI.UIStyle.Custom;
            this.AllDel.StyleCustomMode = true;
            this.AllDel.Symbol = 77;
            this.AllDel.SymbolSize = 35;
            this.AllDel.TabIndex = 1;
            this.AllDel.Text = "清空所有记录";
            this.AllDel.Click += new System.EventHandler(this.AllDel_Click);
            // 
            // TransPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Name = "TransPanel";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.Style = Sunny.UI.UIStyle.White;
            this.Text = "TransForm";
            this.uiTabControlMenu1.ResumeLayout(false);
            this.传输队列.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.已完成.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton AllStop;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton AllDel;
        public System.Windows.Forms.TabPage 传输队列;
        public System.Windows.Forms.TabPage 已完成;
        public Sunny.UI.UIPanel Transing;
        public Sunny.UI.UIPanel Completed;
        private Sunny.UI.UISymbolButton AllCancel;
        private Sunny.UI.UISymbolButton AllStart;
    }
}