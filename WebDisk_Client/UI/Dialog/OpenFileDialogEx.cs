using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WebDisk_Client.Utils;

namespace WebDisk_Client.UI
{
    /// <summary>
    /// 扩展文件打开对话框。不可继承该类。
    /// 支持自定义的文件预览功能。
    /// </summary>
    [DefaultEvent("FileSelecting")]
    public sealed class OpenFileDialogEx : Component
    {
        #region 字段区域

        private string m_fileName = string.Empty;
        private string m_filer = string.Empty;

        #endregion

        #region 属性区域

        /// <summary>
        /// 获取或设置当前选择的文件名。
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FileName
        {
            get { return m_fileName; }
            set { m_fileName = value ?? string.Empty; }
        }

        /// <summary>
        /// 获取或设置文件筛选条件。
        /// </summary>
        [Description("文件筛选条件。")]
        public string Filer
        {
            get { return m_filer; }
            set { m_filer = value ?? string.Empty; }
        }
        public string InitialDirectory
        {
            get;
            set;
        }

        public List<string> FileNames
        {
            get;
            set;
        }
        public string SelectPath
        {
            get;
            set;
        }
        #endregion

        #region 方法区域

        /// <summary>
        /// 显示模式对话框。
        /// </summary>
        /// <returns></returns>
        public DialogResult ShowDialog()
        {
            return ShowDialog(null);
        }

        /// <summary>
        /// 显示模式对话框。
        /// </summary>
        /// <param name="owner">宿主控件。</param>
        /// <returns></returns>
        public DialogResult ShowDialog(IWin32Window owner)
        {
            FileNames = new List<string>();

            using (OpenFileDialog dialog = new OpenFileDialog() { FileName = m_fileName, Filter = m_filer, Multiselect = true, InitialDirectory = InitialDirectory })
            {
                SelectPath = dialog.InitialDirectory;
                //在Vista、WIN7、WIN8上按XP风格显示对话框
                dialog.AutoUpgradeEnabled = false;

                OpenFileDialogHostForm hostForm = new OpenFileDialogHostForm(this, dialog);
                if (owner != null)
                    hostForm.Show(owner);
                else hostForm.Show(Application.OpenForms[0]);

                //隐藏中间窗体
                Win32.SetWindowPos(hostForm.Handle, IntPtr.Zero, 0, 0, 0, 0,
                    SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOOWNERZORDER | SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_HIDEWINDOW);

                //将median作为openfileDialog的owner
                DialogResult result = dialog.ShowDialog(hostForm);
                if (result == DialogResult.OK)
                {
                    m_fileName = dialog.FileName;
                }

                hostForm.Close();
                hostForm.Dispose();

                return result;
            }
        }

        #endregion

        #region 事件委托


        /// <summary>
        /// 选择文件时调用该方法。
        /// </summary>
        /// <param name="fileName"></param>
        public void OnFileSelecting(string fileName)
        {

        }
        public void OnItemSelected(List<string> selectedItems)
        {
            FileNames = selectedItems;
        }

        /// <summary>
        /// 打开路径时调用该方法。
        /// </summary>
        /// <param name="path"></param>
        public void OnPathOpened(string path)
        {
            SelectPath = path;
        }

        #endregion

        #region 内部类型

        /// <summary>
        /// OpenFileDialog宿主窗体。
        /// </summary>
        class OpenFileDialogHostForm : Form
        {
            #region 构造区域

            /// <summary>
            /// 构造函数。
            /// </summary>
            /// <param name="dialogEx"></param>
            /// <param name="dialog"></param>
            public OpenFileDialogHostForm(OpenFileDialogEx dialogEx, OpenFileDialog dialog)
            {
                m_dialogEx = dialogEx;
                m_dialog = dialog;

                this.StartPosition = FormStartPosition.Manual;
                this.Location = new System.Drawing.Point(-1000, -1000); //隐藏窗口，避免界面闪烁
            }

            #endregion

            #region 字段区域

            private OpenFileDialogEx m_dialogEx;
            private OpenFileDialog m_dialog = null;
            private DialogNativeWindow m_nativeWindow;

            #endregion

            #region 方法区域

            /// <summary>
            /// 窗口关闭前。
            /// </summary>
            /// <param name="e"></param>
            protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
            {
                if (m_nativeWindow != null)
                    m_nativeWindow.Dispose();
                base.OnClosing(e);
            }

            /// <summary>
            /// 处理窗口消息。
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                //m.LParam为要打开的窗口句柄，开始监听OpenFileDialog的Windows消息
                if (m.Msg == (int)Msg.WM_ACTIVATE)
                {
                    //跳过不需要监听的窗口
                    bool needInitNative = true;
                    if (Application.OpenForms != null && Application.OpenForms.Count > 0)
                    {
                        foreach (Form frm in Application.OpenForms)
                        {
                            if (m.LParam == frm.Handle && frm.Handle != this.Handle)
                                needInitNative = false;
                        }
                    }
                    if (m_nativeWindow == null && needInitNative)
                        m_nativeWindow = new DialogNativeWindow(m_dialogEx, m.LParam, m_dialog);
                }
                base.WndProc(ref m);
            }

            #endregion
        }

        /// <summary>
        /// OpenFileDialog钩子窗口。
        /// </summary>
        class DialogNativeWindow : NativeWindow, IDisposable
        {
            #region 构造区域

            /// <summary>
            /// 构造函数。
            /// </summary>
            /// <param name="dialogEx"></param>
            /// <param name="handle">要监视的窗口句柄。</param>
            /// <param name="dialog">打开文件的对话框。</param>
            public DialogNativeWindow(OpenFileDialogEx dialogEx, IntPtr handle, OpenFileDialog dialog)
            {
                m_dialogEx = dialogEx;
                m_dialog = dialog;
                AssignHandle(handle);
            }

            #endregion

            #region 字段区域

            private OpenFileDialogEx m_dialogEx;
            private OpenFileDialog m_dialog; //待扩展OpenFileDialog
            private ChildControlNativeWindow m_childNative;
            private ChildControlNativeWindow m_SelectButton;
            private ChildControlNativeWindow m_ListView;
            private bool m_isDisposed;

            #endregion

            #region 属性区域

            /// <summary>
            /// 获取一个值，该值指示当前资源是否已被释放。
            /// </summary>
            public bool IsDisposed
            {
                get { return m_isDisposed; }
            }

            #endregion

            #region 方法区域

            /// <summary>
            /// 处理窗口消息。
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case (int)Msg.WM_SHOWWINDOW:
                        InitChildNative();
                        break;
                }
                base.WndProc(ref m);
            }

            /// <summary>
            /// 初始化子控件的NativeWindow。
            /// </summary>
            private void InitChildNative()
            {
                //查找openfileDialog中的子控件
                Win32.EnumChildWindows(this.Handle, new Win32.EnumWindowsCallBack((IntPtr handle, int lparam) =>
                        {
                            StringBuilder sb = new StringBuilder(256);
                            Win32.GetClassName(handle, sb, sb.Capacity);//获取控件类名

                            StringBuilder text = new StringBuilder(256);
                            Win32.GetWindowText(handle, text, text.Capacity);
                            if (sb.ToString().StartsWith("#32770")) //找到目标控件
                            {
                                m_childNative = new ChildControlNativeWindow(handle);
                                m_childNative.SelectFileChanged += new ChildControlNativeWindow.SelectFileChangedEventHandler(childNative_SelectFileChanged);
                                m_childNative.SelectPathChanged += new ChildControlNativeWindow.SelectPathChangedEventHandler(childNative_SelectPathChanged);
                                m_childNative.SelectPathSelectedFiles += m_childNative_SelectPathSelectedFiles;
                                m_childNative.m_ListView = m_ListView;
                                return true;
                            }
                            if (sb.ToString().StartsWith("Button"))
                            {
                                if (text.ToString().Contains("(&O)"))
                                {
                                    int id = Win32.GetDlgCtrlID(handle);
                                    Win32.SetDlgItemText(Win32.GetParent(handle), id, "上传(&O)");
                                    m_SelectButton = new ChildControlNativeWindow(handle);
                                    m_SelectButton.m_ListView = m_ListView;
                                    return true;
                                }
                            }
                            if (sb.ToString().StartsWith("SysListView32"))
                            {
                                m_ListView = new ChildControlNativeWindow(handle);
                                m_ListView.m_ListView = m_ListView;
                                return true;
                            }
                            return true;
                        }),
                    0);
            }



            /// <summary>
            /// 释放资源。
            /// </summary>
            public void Dispose()
            {
                ReleaseHandle();
                if (m_childNative != null)
                {
                    m_childNative.SelectFileChanged -= new ChildControlNativeWindow.SelectFileChangedEventHandler(childNative_SelectFileChanged);
                    m_childNative.SelectPathChanged -= new ChildControlNativeWindow.SelectPathChangedEventHandler(childNative_SelectPathChanged);
                    m_childNative.SelectPathSelectedFiles -= new ChildControlNativeWindow.SelectPathSelectedFilesEventHandler(m_childNative_SelectPathSelectedFiles);
                    m_childNative.Dispose();
                }
                m_isDisposed = true;
            }

            /// <summary>
            /// 选择目录发生变化。
            /// </summary>
            /// <param name="path"></param>
            void childNative_SelectPathChanged(string path)
            {
                m_dialogEx.OnPathOpened(path);
            }

            /// <summary>
            /// 选择文件发生变化。
            /// </summary>
            /// <param name="fileName"></param>
            void childNative_SelectFileChanged(string fileName)
            {
                m_dialogEx.OnFileSelecting(fileName);
            }

            void m_childNative_SelectPathSelectedFiles(List<string> lstSelectedItems)
            {
                m_dialogEx.OnItemSelected(lstSelectedItems);
            }

            #endregion
        }

        /// <summary>
        /// 子控件钩子窗口。
        /// </summary>
        class ChildControlNativeWindow : NativeWindow, IDisposable
        {
            #region 构造区域
            public ChildControlNativeWindow m_ListView { get; set; }
            /// <summary>
            /// 构造函数。
            /// </summary>
            /// <param name="handle"></param>
            public ChildControlNativeWindow(IntPtr handle)
            {
                AssignHandle(handle);
            }
            #endregion

            #region 方法区域

            /// <summary>
            /// 处理窗口消息。
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                try
                {
                    switch (m.Msg)
                    {
                        case (int)Msg.WM_NOTIFY:
                            OFNOTIFY ofNotify = (OFNOTIFY)Marshal.PtrToStructure(m.LParam, typeof(OFNOTIFY));
                            if (ofNotify.hdr.code == (uint)DialogChangeStatus.CDN_SELCHANGE) //openfileDialog选择文件发生变化
                            {
                                StringBuilder sb = new StringBuilder(2560);
                                Win32.SendMessage(Win32.GetParent(this.Handle), (int)DialogChangeProperties.CDM_GETFILEPATH, (int)2560, sb);
                                string path = sb.ToString();
                                if (SelectFileChanged != null)
                                    SelectFileChanged(sb.ToString()); //通知注册者

                                if (m_ListView != null)
                                {
                                    int count = ListV.ListView_GetItemCount(m_ListView.Handle);
                                    if (count > 0)
                                    {
                                        List<string> lstSelectedItemName = ListV.ListViewGetItem(m_ListView.Handle);
                                        if (SelectPathSelectedFiles != null)
                                        {
                                            SelectPathSelectedFiles(lstSelectedItemName);
                                        }
                                    }
                                }
                            }
                            else if (ofNotify.hdr.code == (uint)DialogChangeStatus.CDN_FOLDERCHANGE) //openfileDialog选择目录发生变化
                            {
                                Win32.EnumChildWindows(Win32.GetParent(this.Handle), new Win32.EnumWindowsCallBack((IntPtr handle, int lparam) =>
                                {
                                    StringBuilder className = new StringBuilder(256);
                                    Win32.GetClassName(handle, className, className.Capacity);//获取控件类名
                                    if (className.ToString().StartsWith("SysListView32"))
                                    {
                                        m_ListView = new ChildControlNativeWindow(handle);
                                        return true;
                                    }
                                    return true;
                                }), 0);

                                StringBuilder sb = new StringBuilder(256);
                                Win32.SendMessage(Win32.GetParent(this.Handle), (int)DialogChangeProperties.CDM_GETFOLDERPATH, (int)256, sb);
                                if (SelectPathChanged != null)
                                    SelectPathChanged(sb.ToString()); //通知注册者
                            }
                            break;
                        case (int)Msg.WM_LBUTTONDOWN:
                            StringBuilder text = new StringBuilder(256);
                            Win32.GetWindowText(Handle, text, text.Capacity);
                            if (text.ToString().Contains("(&O)"))
                            {
                                Win32.EndDialog(Win32.GetParent(this.Handle), 1);
                            }
                            break;
                    }
                    base.WndProc(ref m);
                }
                catch (Exception)
                {
                }
            }

            /// <summary>
            /// 释放资源。
            /// </summary>
            public void Dispose()
            {
                ReleaseHandle();
            }

            #endregion

            #region 事件委托

            //当openfileDialog的选择文件发生变化时发生
            public delegate void SelectFileChangedEventHandler(string fileName);
            public event SelectFileChangedEventHandler SelectFileChanged;

            //当openfileDialog的选择目录发生变化时发生
            public delegate void SelectPathChangedEventHandler(string path);
            public event SelectPathChangedEventHandler SelectPathChanged;

            public delegate void SelectPathSelectedFilesEventHandler(List<string> lstSelectedItems);
            public event SelectPathSelectedFilesEventHandler SelectPathSelectedFiles;

            #endregion
        }

        #endregion
    }

    /// <summary>
    /// 路径事件参数。
    /// </summary>
    [Serializable]
    public class OpenFileDialogExPathEventArgs : EventArgs
    {
        #region 构造区域

        /// <summary>
        /// 构造函数。
        /// </summary>
        /// <param name="path">与事件相关的路径名（文件名或文件夹名）。</param>
        public OpenFileDialogExPathEventArgs(string path)
        {
            m_path = path;
        }

        #endregion

        #region 字段区域

        private string m_path = string.Empty;

        #endregion

        #region 属性区域

        /// <summary>
        /// 获取与事件相关的路径名（文件名或文件夹名）。
        /// </summary>
        public string Path
        {
            get { return m_path; }
        }
        #endregion
    }
}