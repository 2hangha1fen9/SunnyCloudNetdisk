
namespace WebDisk_Client.UI
{
    partial class SharePanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ShareTable = new Sunny.UI.UIDataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareOperator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制分享码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改分享信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消分享ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataSet = new System.Data.DataSet();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.CopyCode = new Sunny.UI.UISymbolButton();
            this.DelShare = new Sunny.UI.UISymbolButton();
            this.EditShare = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.ShareTable)).BeginInit();
            this.ShareOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShareTable
            // 
            this.ShareTable.AllowUserToAddRows = false;
            this.ShareTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShareTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShareTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShareTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ShareTable.BackgroundColor = System.Drawing.Color.White;
            this.ShareTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShareTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShareTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ShareTable.ColumnHeadersHeight = 30;
            this.ShareTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Code,
            this.Effective,
            this.FileType,
            this.FileSize,
            this.StartTime,
            this.EndTIme,
            this.MaxVisit,
            this.Visited});
            this.ShareTable.ContextMenuStrip = this.ShareOperator;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShareTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShareTable.EnableHeadersVisualStyles = false;
            this.ShareTable.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ShareTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ShareTable.Location = new System.Drawing.Point(0, 41);
            this.ShareTable.Name = "ShareTable";
            this.ShareTable.ReadOnly = true;
            this.ShareTable.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShareTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ShareTable.RowHeadersVisible = false;
            this.ShareTable.RowHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShareTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ShareTable.RowTemplate.Height = 30;
            this.ShareTable.SelectedIndex = -1;
            this.ShareTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShareTable.ShowGridLine = true;
            this.ShareTable.ShowRect = false;
            this.ShareTable.Size = new System.Drawing.Size(800, 409);
            this.ShareTable.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ShareTable.Style = Sunny.UI.UIStyle.Gray;
            this.ShareTable.StyleCustomMode = true;
            this.ShareTable.TabIndex = 2;
            this.ShareTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ShareTable_DataError);
            this.ShareTable.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShareTable_KeyUp);
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "文件名";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 82;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "分享码";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 82;
            // 
            // Effective
            // 
            this.Effective.DataPropertyName = "Effective";
            this.Effective.HeaderText = "状态";
            this.Effective.Name = "Effective";
            this.Effective.ReadOnly = true;
            this.Effective.Width = 66;
            // 
            // FileType
            // 
            this.FileType.DataPropertyName = "FileType";
            this.FileType.HeaderText = "文件类型";
            this.FileType.Name = "FileType";
            this.FileType.ReadOnly = true;
            this.FileType.Width = 98;
            // 
            // FileSize
            // 
            this.FileSize.DataPropertyName = "FileSize";
            this.FileSize.HeaderText = "文件大小";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.Width = 98;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "创建时间";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 98;
            // 
            // EndTIme
            // 
            this.EndTIme.DataPropertyName = "EndTime";
            this.EndTIme.HeaderText = "失效时间";
            this.EndTIme.Name = "EndTIme";
            this.EndTIme.ReadOnly = true;
            this.EndTIme.Width = 98;
            // 
            // MaxVisit
            // 
            this.MaxVisit.DataPropertyName = "MaxVisit";
            this.MaxVisit.HeaderText = "最大访问数";
            this.MaxVisit.Name = "MaxVisit";
            this.MaxVisit.ReadOnly = true;
            this.MaxVisit.Width = 114;
            // 
            // Visited
            // 
            this.Visited.DataPropertyName = "Visited";
            this.Visited.HeaderText = "访问人数";
            this.Visited.Name = "Visited";
            this.Visited.ReadOnly = true;
            this.Visited.Width = 98;
            // 
            // ShareOperator
            // 
            this.ShareOperator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制分享码ToolStripMenuItem,
            this.修改分享信息ToolStripMenuItem,
            this.取消分享ToolStripMenuItem});
            this.ShareOperator.Name = "ShareOperator";
            this.ShareOperator.Size = new System.Drawing.Size(149, 70);
            // 
            // 复制分享码ToolStripMenuItem
            // 
            this.复制分享码ToolStripMenuItem.Name = "复制分享码ToolStripMenuItem";
            this.复制分享码ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制分享码ToolStripMenuItem.Text = "复制分享码";
            this.复制分享码ToolStripMenuItem.Click += new System.EventHandler(this.复制分享码ToolStripMenuItem_Click);
            // 
            // 修改分享信息ToolStripMenuItem
            // 
            this.修改分享信息ToolStripMenuItem.Name = "修改分享信息ToolStripMenuItem";
            this.修改分享信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改分享信息ToolStripMenuItem.Text = "修改分享信息";
            this.修改分享信息ToolStripMenuItem.Click += new System.EventHandler(this.修改分享信息ToolStripMenuItem_Click);
            // 
            // 取消分享ToolStripMenuItem
            // 
            this.取消分享ToolStripMenuItem.Name = "取消分享ToolStripMenuItem";
            this.取消分享ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.取消分享ToolStripMenuItem.Text = "取消分享";
            this.取消分享ToolStripMenuItem.Click += new System.EventHandler(this.取消分享ToolStripMenuItem_Click);
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "NewDataSet";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.CopyCode);
            this.uiPanel1.Controls.Add(this.DelShare);
            this.uiPanel1.Controls.Add(this.EditShare);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(800, 35);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyCode
            // 
            this.CopyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.CopyCode.FillColor = System.Drawing.Color.Transparent;
            this.CopyCode.FillDisableColor = System.Drawing.Color.Transparent;
            this.CopyCode.FillHoverColor = System.Drawing.Color.Transparent;
            this.CopyCode.FillPressColor = System.Drawing.Color.Transparent;
            this.CopyCode.FillSelectedColor = System.Drawing.Color.Transparent;
            this.CopyCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.CopyCode.ForeColor = System.Drawing.Color.Gray;
            this.CopyCode.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CopyCode.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CopyCode.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CopyCode.Location = new System.Drawing.Point(200, 0);
            this.CopyCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.CopyCode.Name = "CopyCode";
            this.CopyCode.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.CopyCode.RectColor = System.Drawing.Color.Transparent;
            this.CopyCode.RectDisableColor = System.Drawing.Color.Transparent;
            this.CopyCode.RectHoverColor = System.Drawing.Color.Transparent;
            this.CopyCode.RectPressColor = System.Drawing.Color.Transparent;
            this.CopyCode.RectSelectedColor = System.Drawing.Color.Transparent;
            this.CopyCode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.CopyCode.Size = new System.Drawing.Size(100, 35);
            this.CopyCode.Style = Sunny.UI.UIStyle.Custom;
            this.CopyCode.StyleCustomMode = true;
            this.CopyCode.Symbol = 104;
            this.CopyCode.TabIndex = 4;
            this.CopyCode.Text = "复制分享码";
            this.CopyCode.Click += new System.EventHandler(this.CopyCode_Click);
            // 
            // DelShare
            // 
            this.DelShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelShare.Dock = System.Windows.Forms.DockStyle.Left;
            this.DelShare.FillColor = System.Drawing.Color.Transparent;
            this.DelShare.FillDisableColor = System.Drawing.Color.Transparent;
            this.DelShare.FillHoverColor = System.Drawing.Color.Transparent;
            this.DelShare.FillPressColor = System.Drawing.Color.Transparent;
            this.DelShare.FillSelectedColor = System.Drawing.Color.Transparent;
            this.DelShare.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.DelShare.ForeColor = System.Drawing.Color.Gray;
            this.DelShare.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DelShare.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DelShare.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DelShare.Location = new System.Drawing.Point(100, 0);
            this.DelShare.MinimumSize = new System.Drawing.Size(1, 1);
            this.DelShare.Name = "DelShare";
            this.DelShare.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.DelShare.RectColor = System.Drawing.Color.Transparent;
            this.DelShare.RectDisableColor = System.Drawing.Color.Transparent;
            this.DelShare.RectHoverColor = System.Drawing.Color.Transparent;
            this.DelShare.RectPressColor = System.Drawing.Color.Transparent;
            this.DelShare.RectSelectedColor = System.Drawing.Color.Transparent;
            this.DelShare.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.DelShare.Size = new System.Drawing.Size(100, 35);
            this.DelShare.Style = Sunny.UI.UIStyle.Custom;
            this.DelShare.StyleCustomMode = true;
            this.DelShare.Symbol = 61735;
            this.DelShare.TabIndex = 2;
            this.DelShare.Text = "删除分享";
            this.DelShare.Click += new System.EventHandler(this.DelShare_Click);
            // 
            // EditShare
            // 
            this.EditShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditShare.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditShare.FillColor = System.Drawing.Color.Transparent;
            this.EditShare.FillDisableColor = System.Drawing.Color.Transparent;
            this.EditShare.FillHoverColor = System.Drawing.Color.Transparent;
            this.EditShare.FillPressColor = System.Drawing.Color.Transparent;
            this.EditShare.FillSelectedColor = System.Drawing.Color.Transparent;
            this.EditShare.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.EditShare.ForeColor = System.Drawing.Color.Gray;
            this.EditShare.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditShare.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditShare.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditShare.Location = new System.Drawing.Point(0, 0);
            this.EditShare.MinimumSize = new System.Drawing.Size(1, 1);
            this.EditShare.Name = "EditShare";
            this.EditShare.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.EditShare.RectColor = System.Drawing.Color.Transparent;
            this.EditShare.RectDisableColor = System.Drawing.Color.Transparent;
            this.EditShare.RectHoverColor = System.Drawing.Color.Transparent;
            this.EditShare.RectPressColor = System.Drawing.Color.Transparent;
            this.EditShare.RectSelectedColor = System.Drawing.Color.Transparent;
            this.EditShare.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.EditShare.Size = new System.Drawing.Size(100, 35);
            this.EditShare.Style = Sunny.UI.UIStyle.Custom;
            this.EditShare.StyleCustomMode = true;
            this.EditShare.Symbol = 62104;
            this.EditShare.TabIndex = 1;
            this.EditShare.Text = "编辑分享";
            this.EditShare.Click += new System.EventHandler(this.EditShare_Click);
            // 
            // SharePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.ShareTable);
            this.Name = "SharePanel";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.Style = Sunny.UI.UIStyle.White;
            this.Text = "SharePanel";
            this.Load += new System.EventHandler(this.SharePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShareTable)).EndInit();
            this.ShareOperator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UIDataGridView ShareTable;
        private System.Data.DataSet DataSet;
        private System.Windows.Forms.ContextMenuStrip ShareOperator;
        private System.Windows.Forms.ToolStripMenuItem 复制分享码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改分享信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消分享ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effective;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visited;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton DelShare;
        private Sunny.UI.UISymbolButton EditShare;
        private Sunny.UI.UISymbolButton CopyCode;
    }
}