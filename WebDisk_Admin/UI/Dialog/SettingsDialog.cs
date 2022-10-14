using Microsoft.WindowsAPICodePack.Shell;
using Sunny.UI;
using System;
using System.Windows.Forms;
using WebDisk_Admin.Properties;

namespace WebDisk_Admin.UI
{
    public partial class SettingsDialog : UIForm
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.DownLoadPath.Text = Settings.Default.downloadPath;
            this.ShowSuccessTip.Active = Settings.Default.showSuccessTip;
            this.PlaySuccessSound.Active = Settings.Default.playSuccessSound;
            this.CloseAction.Active = Settings.Default.closeAction;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (this.pathSelector.ShowDialog() == DialogResult.OK)
            {
                this.DownLoadPath.Text = this.pathSelector.SelectedPath;
            }
        }


        private void uiButton7_Click(object sender, EventArgs e)
        {
            Settings.Default.downloadPath = this.DownLoadPath.Text;
            Settings.Default.showSuccessTip = this.ShowSuccessTip.Active;
            Settings.Default.playSuccessSound = this.PlaySuccessSound.Active;
            Settings.Default.closeAction = this.CloseAction.Active;
            Settings.Default.Save();

            
            ShowInfoDialog("提示","修改成功",UIStyle.Green,false);
            this.Hide();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            Settings.Default.downloadPath = KnownFolders.Downloads.Path;
            Settings.Default.Save();

            SettingsForm_Load(null, null);
            ShowInfoDialog("提示", "重置设置成功", UIStyle.Green, false);
        }
    }
}
