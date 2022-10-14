
namespace WebDisk_Client
{
    partial class ProcessBar
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.process = new Sunny.UI.UIProcessBar();
            this.delete = new Sunny.UI.UISymbolButton();
            this.control = new Sunny.UI.UISymbolButton();
            this.open = new Sunny.UI.UISymbolButton();
            this.tip = new Sunny.UI.UILabel();
            this.process1 = new System.Diagnostics.Process();
            this.fileName = new Sunny.UI.UISymbolLabel();
            this.subtask = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // process
            // 
            this.process.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.process.DecimalCount = 0;
            this.process.FillColor = System.Drawing.Color.White;
            this.process.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process.ForeColor = System.Drawing.Color.DimGray;
            this.process.Location = new System.Drawing.Point(234, 9);
            this.process.Margin = new System.Windows.Forms.Padding(2);
            this.process.MinimumSize = new System.Drawing.Size(58, 4);
            this.process.Name = "process";
            this.process.Radius = 20;
            this.process.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.process.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.process.Size = new System.Drawing.Size(180, 23);
            this.process.Style = Sunny.UI.UIStyle.Custom;
            this.process.StyleCustomMode = true;
            this.process.TabIndex = 1;
            this.process.Text = "0%";
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.delete.FillColor = System.Drawing.Color.Transparent;
            this.delete.FillHoverColor = System.Drawing.Color.Gainsboro;
            this.delete.FillPressColor = System.Drawing.Color.Transparent;
            this.delete.FillSelectedColor = System.Drawing.Color.Transparent;
            this.delete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.delete.ForeColor = System.Drawing.Color.DimGray;
            this.delete.ForeDisableColor = System.Drawing.Color.Transparent;
            this.delete.ForeHoverColor = System.Drawing.Color.Orange;
            this.delete.ForePressColor = System.Drawing.Color.Orange;
            this.delete.ForeSelectedColor = System.Drawing.Color.Orange;
            this.delete.Location = new System.Drawing.Point(629, 0);
            this.delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.delete.Name = "delete";
            this.delete.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.delete.RectColor = System.Drawing.Color.Transparent;
            this.delete.RectDisableColor = System.Drawing.Color.Transparent;
            this.delete.RectHoverColor = System.Drawing.Color.Transparent;
            this.delete.RectPressColor = System.Drawing.Color.Transparent;
            this.delete.RectSelectedColor = System.Drawing.Color.Transparent;
            this.delete.Size = new System.Drawing.Size(29, 41);
            this.delete.Style = Sunny.UI.UIStyle.Custom;
            this.delete.Symbol = 77;
            this.delete.SymbolSize = 35;
            this.delete.TabIndex = 3;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // control
            // 
            this.control.Cursor = System.Windows.Forms.Cursors.Hand;
            this.control.Dock = System.Windows.Forms.DockStyle.Right;
            this.control.FillColor = System.Drawing.Color.Transparent;
            this.control.FillDisableColor = System.Drawing.Color.Transparent;
            this.control.FillHoverColor = System.Drawing.Color.Transparent;
            this.control.FillPressColor = System.Drawing.Color.Transparent;
            this.control.FillSelectedColor = System.Drawing.Color.Transparent;
            this.control.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.control.ForeColor = System.Drawing.Color.DimGray;
            this.control.ForeDisableColor = System.Drawing.Color.Transparent;
            this.control.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.control.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.control.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.control.Location = new System.Drawing.Point(598, 0);
            this.control.MinimumSize = new System.Drawing.Size(1, 1);
            this.control.Name = "control";
            this.control.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.control.RectColor = System.Drawing.Color.Transparent;
            this.control.RectDisableColor = System.Drawing.Color.Transparent;
            this.control.RectHoverColor = System.Drawing.Color.Transparent;
            this.control.RectPressColor = System.Drawing.Color.Transparent;
            this.control.RectSelectedColor = System.Drawing.Color.Transparent;
            this.control.Size = new System.Drawing.Size(31, 41);
            this.control.Style = Sunny.UI.UIStyle.Custom;
            this.control.Symbol = 61516;
            this.control.SymbolSize = 20;
            this.control.TabIndex = 4;
            this.control.Click += new System.EventHandler(this.control_Click);
            // 
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.Dock = System.Windows.Forms.DockStyle.Right;
            this.open.FillColor = System.Drawing.Color.Transparent;
            this.open.FillDisableColor = System.Drawing.Color.Transparent;
            this.open.FillHoverColor = System.Drawing.Color.Transparent;
            this.open.FillPressColor = System.Drawing.Color.Transparent;
            this.open.FillSelectedColor = System.Drawing.Color.Transparent;
            this.open.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.open.ForeColor = System.Drawing.Color.Gray;
            this.open.ForeDisableColor = System.Drawing.Color.Transparent;
            this.open.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.open.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.open.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.open.Location = new System.Drawing.Point(566, 0);
            this.open.MinimumSize = new System.Drawing.Size(1, 1);
            this.open.Name = "open";
            this.open.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.open.RectColor = System.Drawing.Color.Transparent;
            this.open.RectDisableColor = System.Drawing.Color.Transparent;
            this.open.RectHoverColor = System.Drawing.Color.Transparent;
            this.open.RectPressColor = System.Drawing.Color.Transparent;
            this.open.RectSelectedColor = System.Drawing.Color.Transparent;
            this.open.Size = new System.Drawing.Size(32, 41);
            this.open.Style = Sunny.UI.UIStyle.Custom;
            this.open.Symbol = 85;
            this.open.TabIndex = 5;
            this.open.Visible = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.Transparent;
            this.tip.Dock = System.Windows.Forms.DockStyle.Right;
            this.tip.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tip.Location = new System.Drawing.Point(417, 0);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(149, 41);
            this.tip.TabIndex = 6;
            this.tip.Text = "进度";
            this.tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.Color.Transparent;
            this.fileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(0, 0);
            this.fileName.MinimumSize = new System.Drawing.Size(1, 1);
            this.fileName.Name = "fileName";
            this.fileName.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.fileName.Size = new System.Drawing.Size(152, 41);
            this.fileName.Symbol = 61699;
            this.fileName.SymbolSize = 20;
            this.fileName.TabIndex = 8;
            this.fileName.Text = "文件名";
            this.fileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtask
            // 
            this.subtask.Dock = System.Windows.Forms.DockStyle.Left;
            this.subtask.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.subtask.Location = new System.Drawing.Point(152, 0);
            this.subtask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtask.Name = "subtask";
            this.subtask.Size = new System.Drawing.Size(78, 41);
            this.subtask.TabIndex = 9;
            this.subtask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProcessBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.subtask);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.open);
            this.Controls.Add(this.control);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.process);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.Name = "ProcessBar";
            this.Size = new System.Drawing.Size(658, 41);
            this.ResumeLayout(false);

        }

        #endregion
        public Sunny.UI.UIProcessBar process;
        public Sunny.UI.UISymbolButton delete;
        public Sunny.UI.UISymbolButton control;
        public Sunny.UI.UISymbolButton open;
        public Sunny.UI.UILabel tip;
        private System.Diagnostics.Process process1;
        public Sunny.UI.UILabel subtask;
        public Sunny.UI.UISymbolLabel fileName;
        public  System.Windows.Forms.Timer timer1;
    }
}
