using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PaymentCFG
{
    public class OPSystem
    {
        private static readonly object mutex = new object();
        private static OPSystem m_instance = null;
        public static OPSystem Instance
        {
            get
            {
                lock (mutex)
                {
                    if (m_instance == null)
                        m_instance = new OPSystem();
                    return m_instance;
                }

            }
        }
        private OPSystem() { }

        public string SelectFile()
        {
            var folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = true;
            folderBrowser.CheckFileExists = true;
            folderBrowser.CheckPathExists = true;
            folderBrowser.InitialDirectory = @"D:\\TFS\\SDS\\TDLR.Payments\\src\\TDLR.Payments.Api\\";
            folderBrowser.Filter = $"Select appsettings.json (appsettings.json)|appsettings.json|All files (*.*)|*.*";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                return folderBrowser.FileName;
            }
            return null;
        }

        public void OpenUrl(ListView lv)
        {
            if (lv.SelectedItems != null && lv.SelectedItems.Count > 0)
            {
                string text = lv.SelectedItems[0].SubItems[1].Text;
                OpenUrl(text);
            }
        }

        public void OpenUrl(string text)
        {            
            if (string.IsNullOrEmpty(text)) { return; }
            if (text.StartsWith("http", StringComparison.InvariantCultureIgnoreCase))
            {
                Process.Start(text);
            }
        }
    }

}
