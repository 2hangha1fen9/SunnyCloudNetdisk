
namespace WebDisk_Client.UI.Dialog
{
    partial class ShareEditDialog
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
            this.Submit = new Sunny.UI.UIButton();
            this.Count = new Sunny.UI.UITextBox();
            this.Never = new Sunny.UI.UICheckBox();
            this.EndTime = new Sunny.UI.UIDatetimePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Free = new Sunny.UI.UICheckBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Submit.Location = new System.Drawing.Point(301, 166);
            this.Submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.Submit.Name = "Submit";
            this.Submit.Radius = 33;
            this.Submit.RectColor = System.Drawing.Color.Transparent;
            this.Submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.Submit.RectHoverColor = System.Drawing.Color.Transparent;
            this.Submit.RectPressColor = System.Drawing.Color.Transparent;
            this.Submit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Submit.Size = new System.Drawing.Size(100, 35);
            this.Submit.Style = Sunny.UI.UIStyle.Custom;
            this.Submit.StyleCustomMode = true;
            this.Submit.TabIndex = 35;
            this.Submit.Text = "修改";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Count
            // 
            this.Count.BackColor = System.Drawing.Color.Transparent;
            this.Count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Count.DoubleValue = 1D;
            this.Count.FillColor = System.Drawing.Color.White;
            this.Count.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Count.HasMaximum = true;
            this.Count.HasMinimum = true;
            this.Count.IntValue = 1;
            this.Count.Location = new System.Drawing.Point(98, 53);
            this.Count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Count.Maximum = 2147483647D;
            this.Count.MaximumEnabled = true;
            this.Count.Minimum = 0D;
            this.Count.MinimumEnabled = true;
            this.Count.MinimumSize = new System.Drawing.Size(1, 1);
            this.Count.Name = "Count";
            this.Count.RectColor = System.Drawing.Color.Gray;
            this.Count.Size = new System.Drawing.Size(71, 30);
            this.Count.Style = Sunny.UI.UIStyle.Custom;
            this.Count.StyleCustomMode = true;
            this.Count.TabIndex = 43;
            this.Count.Text = "1";
            this.Count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Count.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // Never
            // 
            this.Never.BackColor = System.Drawing.Color.Transparent;
            this.Never.CheckBoxColor = System.Drawing.Color.Gray;
            this.Never.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Never.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Never.ForeColor = System.Drawing.Color.Gray;
            this.Never.Location = new System.Drawing.Point(301, 105);
            this.Never.MinimumSize = new System.Drawing.Size(1, 1);
            this.Never.Name = "Never";
            this.Never.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.Never.Size = new System.Drawing.Size(108, 29);
            this.Never.Style = Sunny.UI.UIStyle.Custom;
            this.Never.StyleCustomMode = true;
            this.Never.TabIndex = 42;
            this.Never.Text = "永久有效";
            this.Never.CheckedChanged += new System.EventHandler(this.Never_CheckedChanged);
            // 
            // EndTime
            // 
            this.EndTime.BackColor = System.Drawing.Color.Transparent;
            this.EndTime.FillColor = System.Drawing.Color.White;
            this.EndTime.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.EndTime.ForeColor = System.Drawing.Color.Gray;
            this.EndTime.Location = new System.Drawing.Point(98, 105);
            this.EndTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndTime.MaxLength = 19;
            this.EndTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.EndTime.Name = "EndTime";
            this.EndTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.EndTime.RectColor = System.Drawing.Color.Gray;
            this.EndTime.Size = new System.Drawing.Size(196, 29);
            this.EndTime.Style = Sunny.UI.UIStyle.Custom;
            this.EndTime.StyleCustomMode = true;
            this.EndTime.SymbolDropDown = 61555;
            this.EndTime.SymbolNormal = 61555;
            this.EndTime.TabIndex = 41;
            this.EndTime.Text = "2021-08-31 00:00:00";
            this.EndTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.EndTime.Value = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Location = new System.Drawing.Point(15, 105);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 40;
            this.uiLabel2.Text = "有效期:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Free
            // 
            this.Free.BackColor = System.Drawing.Color.Transparent;
            this.Free.CheckBoxColor = System.Drawing.Color.Gray;
            this.Free.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Free.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Free.ForeColor = System.Drawing.Color.Gray;
            this.Free.Location = new System.Drawing.Point(191, 57);
            this.Free.MinimumSize = new System.Drawing.Size(1, 1);
            this.Free.Name = "Free";
            this.Free.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.Free.Size = new System.Drawing.Size(103, 23);
            this.Free.Style = Sunny.UI.UIStyle.Custom;
            this.Free.StyleCustomMode = true;
            this.Free.TabIndex = 39;
            this.Free.Text = "无限制";
            this.Free.CheckedChanged += new System.EventHandler(this.Free_CheckedChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.uiLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel1.Location = new System.Drawing.Point(15, 57);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 38;
            this.uiLabel1.Text = "访问人数:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(-15, 140);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(451, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.StyleCustomMode = true;
            this.uiLine1.TabIndex = 44;
            // 
            // ShareEditDialog
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 213);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Never);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.Free);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.uiLine1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShareEditDialog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "  ";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Load += new System.EventHandler(this.ShareEditDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton Submit;
        private Sunny.UI.UITextBox Count;
        private Sunny.UI.UICheckBox Never;
        private Sunny.UI.UIDatetimePicker EndTime;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UICheckBox Free;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
    }
}