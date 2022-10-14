using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDisk_Client.Model;

namespace WebDisk_Client.UI.Dialog
{
    public partial class TextEditDiaolog : UIForm
    {
        public TextEditDiaolog(HomePanel panel,FileDescribe describe)
        {
            InitializeComponent();

            Task.Run(() => 
            {
                this.Text = "读取中...";
                try
                {
                    using (StreamReader reader = panel.view.OpenSteam(describe))
                    {
                        string line = null;
                        while ((line = reader.ReadLine()) != null)
                        {
                            this.richTextBox1.AppendText(line);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }              
            }).ContinueWith((x) => 
            {
                this.Text = describe.Name;
            });          
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
