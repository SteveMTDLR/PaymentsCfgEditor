using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Reflection;
using PaymentCFG;

//the config file is located in folder like this
//C:\Users\steve.morrow\AppData\Local\TDLR\TextSearch.exe_Url_wt0b2rgpygq2cwzqrc1st5a5xgyxezgs\1.0.0.0\user.config

namespace PaymantCFG.Helper
{

    /// <summary>
    /// Settings Helper Class
    /// </summary>
    public class SettingsHelper
    {
        private static readonly object mutex = new object();
        private static SettingsHelper m_instance = null;


        public static SettingsHelper Instance
        {
            get
            {
                lock (mutex)
                {
                    if (m_instance == null)
                        m_instance = new SettingsHelper();
                    return m_instance;
                }

            }
        }
        private SettingsHelper() { }


        public void ResetLocation()
        {

            PaymentsCFG.Properties.Settings.Default.Location = new System.Drawing.Point(0, 0);
            PaymentsCFG.Properties.Settings.Default.Size = new System.Drawing.Size(0, 0);
            Save();
        }

        public bool IsOnScreen(Form form)
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                var formRectangle = new System.Drawing.Rectangle(form.Left, form.Top,
                                                        form.Width, form.Height);

                if (screen.WorkingArea.Contains(formRectangle))
                {
                    return true;
                }
            }

            return false;
        }

        public void DlgLoad(PaymentsCfgDlg dlg)
        {
            try
            {
                if (PaymentsCFG.Properties.Settings.Default.Size.Width != 0 && PaymentsCFG.Properties.Settings.Default.Size.Height != 0)
                {
                    //dlg.WindowState = Settings.Default.WindowState;

                    // we don't want a minimized window at startup
                    if (dlg.WindowState == FormWindowState.Minimized) dlg.WindowState = FormWindowState.Normal;

                    dlg.Location = PaymentsCFG.Properties.Settings.Default.Location;
                    dlg.Size = PaymentsCFG.Properties.Settings.Default.Size;
                }

            }
            catch (Exception ex)
            {
                // added option to not show message box???
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void DlgClosing(PaymentsCfgDlg dlg)
        {
            try
            {
                //Settings.Default.WindowState = dlg.WindowState;
                if (dlg.WindowState == FormWindowState.Normal)
                {
                    // save location and size if the state is normal
                    PaymentsCFG.Properties.Settings.Default.Location = dlg.Location;
                    PaymentsCFG.Properties.Settings.Default.Size = dlg.Size;
                }
                else
                {
                    // save the RestoreBounds if the form is minimized or maximized!
                    PaymentsCFG.Properties.Settings.Default.Location = dlg.RestoreBounds.Location;
                    PaymentsCFG.Properties.Settings.Default.Size = dlg.RestoreBounds.Size;
                }

                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Reset()
        {
            PaymentsCFG.Properties.Settings.Default.Reset();
        }

        public void Save()
        {
            PaymentsCFG.Properties.Settings.Default.Save();
        }

    }
}
