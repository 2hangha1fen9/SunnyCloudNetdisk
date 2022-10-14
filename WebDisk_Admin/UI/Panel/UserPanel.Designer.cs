
namespace WebDisk_Admin.UI
{
    partial class UserPanel
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
            this.DataSet = new System.Data.DataSet();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.GetUserFIle = new Sunny.UI.UISymbolButton();
            this.Find = new Sunny.UI.UITextBox();
            this.DelUser = new Sunny.UI.UISymbolButton();
            this.EditUser = new Sunny.UI.UISymbolButton();
            this.AddUser = new Sunny.UI.UISymbolButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserTable = new Sunny.UI.UIDataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DLBandwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ULBandwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotaSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotaFIles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "Pureftpd";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.GetUserFIle);
            this.uiPanel1.Controls.Add(this.Find);
            this.uiPanel1.Controls.Add(this.DelUser);
            this.uiPanel1.Controls.Add(this.EditUser);
            this.uiPanel1.Controls.Add(this.AddUser);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(800, 35);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetUserFIle
            // 
            this.GetUserFIle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetUserFIle.Dock = System.Windows.Forms.DockStyle.Left;
            this.GetUserFIle.FillColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.FillDisableColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.FillHoverColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.FillPressColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.FillSelectedColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.GetUserFIle.ForeColor = System.Drawing.Color.Gray;
            this.GetUserFIle.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GetUserFIle.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GetUserFIle.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GetUserFIle.Location = new System.Drawing.Point(300, 0);
            this.GetUserFIle.MinimumSize = new System.Drawing.Size(1, 1);
            this.GetUserFIle.Name = "GetUserFIle";
            this.GetUserFIle.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.GetUserFIle.RectColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.RectDisableColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.RectHoverColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.RectPressColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.RectSelectedColor = System.Drawing.Color.Transparent;
            this.GetUserFIle.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.GetUserFIle.Size = new System.Drawing.Size(100, 35);
            this.GetUserFIle.Style = Sunny.UI.UIStyle.Custom;
            this.GetUserFIle.StyleCustomMode = true;
            this.GetUserFIle.Symbol = 61717;
            this.GetUserFIle.TabIndex = 4;
            this.GetUserFIle.Text = "查看文件";
            this.GetUserFIle.Click += new System.EventHandler(this.GetUserFIle_Click);
            // 
            // Find
            // 
            this.Find.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Find.Dock = System.Windows.Forms.DockStyle.Right;
            this.Find.FillColor = System.Drawing.Color.Gainsboro;
            this.Find.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Find.ForeColor = System.Drawing.Color.Gray;
            this.Find.Location = new System.Drawing.Point(506, 0);
            this.Find.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Find.Maximum = 2147483647D;
            this.Find.Minimum = -2147483648D;
            this.Find.MinimumSize = new System.Drawing.Size(1, 1);
            this.Find.Name = "Find";
            this.Find.Radius = 35;
            this.Find.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.Find.RectColor = System.Drawing.Color.Gray;
            this.Find.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.Find.Size = new System.Drawing.Size(294, 49);
            this.Find.Style = Sunny.UI.UIStyle.Custom;
            this.Find.StyleCustomMode = true;
            this.Find.Symbol = 61442;
            this.Find.SymbolColor = System.Drawing.Color.Gray;
            this.Find.TabIndex = 3;
            this.Find.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Find.TextChanged += new System.EventHandler(this.Find_TextChanged);
            // 
            // DelUser
            // 
            this.DelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.DelUser.FillColor = System.Drawing.Color.Transparent;
            this.DelUser.FillDisableColor = System.Drawing.Color.Transparent;
            this.DelUser.FillHoverColor = System.Drawing.Color.Transparent;
            this.DelUser.FillPressColor = System.Drawing.Color.Transparent;
            this.DelUser.FillSelectedColor = System.Drawing.Color.Transparent;
            this.DelUser.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.DelUser.ForeColor = System.Drawing.Color.Gray;
            this.DelUser.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DelUser.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DelUser.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DelUser.Location = new System.Drawing.Point(200, 0);
            this.DelUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.DelUser.Name = "DelUser";
            this.DelUser.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.DelUser.RectColor = System.Drawing.Color.Transparent;
            this.DelUser.RectDisableColor = System.Drawing.Color.Transparent;
            this.DelUser.RectHoverColor = System.Drawing.Color.Transparent;
            this.DelUser.RectPressColor = System.Drawing.Color.Transparent;
            this.DelUser.RectSelectedColor = System.Drawing.Color.Transparent;
            this.DelUser.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.DelUser.Size = new System.Drawing.Size(100, 35);
            this.DelUser.Style = Sunny.UI.UIStyle.Custom;
            this.DelUser.StyleCustomMode = true;
            this.DelUser.Symbol = 62005;
            this.DelUser.TabIndex = 2;
            this.DelUser.Text = "删除用户";
            this.DelUser.Click += new System.EventHandler(this.DelUser_Click);
            // 
            // EditUser
            // 
            this.EditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditUser.FillColor = System.Drawing.Color.Transparent;
            this.EditUser.FillDisableColor = System.Drawing.Color.Transparent;
            this.EditUser.FillHoverColor = System.Drawing.Color.Transparent;
            this.EditUser.FillPressColor = System.Drawing.Color.Transparent;
            this.EditUser.FillSelectedColor = System.Drawing.Color.Transparent;
            this.EditUser.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.EditUser.ForeColor = System.Drawing.Color.Gray;
            this.EditUser.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditUser.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditUser.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditUser.Location = new System.Drawing.Point(100, 0);
            this.EditUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.EditUser.Name = "EditUser";
            this.EditUser.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.EditUser.RectColor = System.Drawing.Color.Transparent;
            this.EditUser.RectDisableColor = System.Drawing.Color.Transparent;
            this.EditUser.RectHoverColor = System.Drawing.Color.Transparent;
            this.EditUser.RectPressColor = System.Drawing.Color.Transparent;
            this.EditUser.RectSelectedColor = System.Drawing.Color.Transparent;
            this.EditUser.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.EditUser.Size = new System.Drawing.Size(100, 35);
            this.EditUser.Style = Sunny.UI.UIStyle.Custom;
            this.EditUser.StyleCustomMode = true;
            this.EditUser.Symbol = 61508;
            this.EditUser.TabIndex = 1;
            this.EditUser.Text = "编辑用户";
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddUser.FillColor = System.Drawing.Color.Transparent;
            this.AddUser.FillDisableColor = System.Drawing.Color.Transparent;
            this.AddUser.FillHoverColor = System.Drawing.Color.Transparent;
            this.AddUser.FillPressColor = System.Drawing.Color.Transparent;
            this.AddUser.FillSelectedColor = System.Drawing.Color.Transparent;
            this.AddUser.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.AddUser.ForeColor = System.Drawing.Color.Gray;
            this.AddUser.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddUser.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddUser.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddUser.Location = new System.Drawing.Point(0, 0);
            this.AddUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddUser.Name = "AddUser";
            this.AddUser.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.AddUser.RectColor = System.Drawing.Color.Transparent;
            this.AddUser.RectDisableColor = System.Drawing.Color.Transparent;
            this.AddUser.RectHoverColor = System.Drawing.Color.Transparent;
            this.AddUser.RectPressColor = System.Drawing.Color.Transparent;
            this.AddUser.RectSelectedColor = System.Drawing.Color.Transparent;
            this.AddUser.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.AddUser.Size = new System.Drawing.Size(100, 35);
            this.AddUser.Style = Sunny.UI.UIStyle.Custom;
            this.AddUser.StyleCustomMode = true;
            this.AddUser.Symbol = 62004;
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "添加用户";
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.编辑用户ToolStripMenuItem,
            this.删除用户ToolStripMenuItem,
            this.查看文件ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 164);
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(186, 40);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 编辑用户ToolStripMenuItem
            // 
            this.编辑用户ToolStripMenuItem.Name = "编辑用户ToolStripMenuItem";
            this.编辑用户ToolStripMenuItem.Size = new System.Drawing.Size(186, 40);
            this.编辑用户ToolStripMenuItem.Text = "编辑用户";
            this.编辑用户ToolStripMenuItem.Click += new System.EventHandler(this.编辑用户ToolStripMenuItem_Click);
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(186, 40);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            this.删除用户ToolStripMenuItem.Click += new System.EventHandler(this.删除用户ToolStripMenuItem_Click);
            // 
            // 查看文件ToolStripMenuItem
            // 
            this.查看文件ToolStripMenuItem.Name = "查看文件ToolStripMenuItem";
            this.查看文件ToolStripMenuItem.Size = new System.Drawing.Size(186, 40);
            this.查看文件ToolStripMenuItem.Text = "查看文件";
            this.查看文件ToolStripMenuItem.Click += new System.EventHandler(this.查看文件ToolStripMenuItem_Click);
            // 
            // UserTable
            // 
            this.UserTable.AllowUserToAddRows = false;
            this.UserTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.UserTable.BackgroundColor = System.Drawing.Color.White;
            this.UserTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserTable.ColumnHeadersHeight = 35;
            this.UserTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Password,
            this.status,
            this.Mail,
            this.DLBandwidth,
            this.ULBandwidth,
            this.QuotaSize,
            this.QuotaFIles});
            this.UserTable.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserTable.EnableHeadersVisualStyles = false;
            this.UserTable.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.UserTable.Location = new System.Drawing.Point(0, 41);
            this.UserTable.Name = "UserTable";
            this.UserTable.ReadOnly = true;
            this.UserTable.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserTable.RowHeadersVisible = false;
            this.UserTable.RowHeadersWidth = 82;
            this.UserTable.RowHeight = 35;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UserTable.RowTemplate.Height = 35;
            this.UserTable.SelectedIndex = -1;
            this.UserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserTable.ShowGridLine = true;
            this.UserTable.ShowRect = false;
            this.UserTable.Size = new System.Drawing.Size(800, 412);
            this.UserTable.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.UserTable.Style = Sunny.UI.UIStyle.Gray;
            this.UserTable.StyleCustomMode = true;
            this.UserTable.TabIndex = 3;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "用户名";
            this.User.MinimumWidth = 10;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 160;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "密码";
            this.Password.MinimumWidth = 10;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 128;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "状态";
            this.status.MinimumWidth = 10;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 128;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Mail";
            this.Mail.HeaderText = "邮箱";
            this.Mail.MinimumWidth = 10;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 128;
            // 
            // DLBandwidth
            // 
            this.DLBandwidth.DataPropertyName = "DLBandwidth";
            this.DLBandwidth.HeaderText = "上行带宽(KB/s)";
            this.DLBandwidth.MinimumWidth = 10;
            this.DLBandwidth.Name = "DLBandwidth";
            this.DLBandwidth.ReadOnly = true;
            this.DLBandwidth.Width = 281;
            // 
            // ULBandwidth
            // 
            this.ULBandwidth.DataPropertyName = "ULBandwidth";
            this.ULBandwidth.HeaderText = "下行带宽(KB/s)";
            this.ULBandwidth.MinimumWidth = 10;
            this.ULBandwidth.Name = "ULBandwidth";
            this.ULBandwidth.ReadOnly = true;
            this.ULBandwidth.Width = 281;
            // 
            // QuotaSize
            // 
            this.QuotaSize.DataPropertyName = "QuotaSize";
            this.QuotaSize.HeaderText = "最大容量(MB)";
            this.QuotaSize.MinimumWidth = 10;
            this.QuotaSize.Name = "QuotaSize";
            this.QuotaSize.ReadOnly = true;
            this.QuotaSize.Width = 262;
            // 
            // QuotaFIles
            // 
            this.QuotaFIles.DataPropertyName = "QuotaFIles";
            this.QuotaFIles.HeaderText = "最大文件数";
            this.QuotaFIles.MinimumWidth = 10;
            this.QuotaFIles.Name = "QuotaFIles";
            this.QuotaFIles.ReadOnly = true;
            this.QuotaFIles.Width = 224;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserTable);
            this.Controls.Add(this.uiPanel1);
            this.Name = "UserPanel";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserEditorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet DataSet;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox Find;
        private Sunny.UI.UISymbolButton DelUser;
        private Sunny.UI.UISymbolButton EditUser;
        private Sunny.UI.UISymbolButton AddUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看文件ToolStripMenuItem;
        private Sunny.UI.UIDataGridView UserTable;
        private Sunny.UI.UISymbolButton GetUserFIle;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DLBandwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ULBandwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotaSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotaFIles;
    }
}