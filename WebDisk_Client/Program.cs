using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Windows.Forms;
using WebDisk_Client.Properties;
using WebDisk_Client.UI;


namespace WebDisk_Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //初始化设置
            if (Settings.Default.runed == false)
            {
                Settings.Default.downloadPath = KnownFolders.Downloads.Path;
                Settings.Default.runed = true;
                Settings.Default.Save();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginDialog());
        }
    }
}
