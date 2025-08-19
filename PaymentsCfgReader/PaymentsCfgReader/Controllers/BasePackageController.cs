using PaymentCFG.Models;
using PaymentCFG.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PaymentCFG.Controllers
{
    public enum VulnerabilityLevel
    {
        High,
        Medium,
        Low,
        All,
        None
    }

    public abstract class BasePackageController : IBasePackageController
    {
        
        public BasePackageController(PaymentsCfgDlg dependencyDlg)
        {
            MainDlg = dependencyDlg;
        }

        public PaymentsCfgDlg MainDlg { get; set; }
        public abstract string FileName { get; set; }

        public void AddToTabControl (BasePackageController bc, string title, string fileName)
        {
            TabPage tabPage = new TabPage();
            //tabPage.Text = title;
            tabPage.Text = GetFilenameWithoutExtension(fileName);

            tabPage.ToolTipText = fileName;
            tabPage.Tag = bc;
        }

        public abstract void ClearSubLists();
        public abstract void FilloutComponents(string filter, bool reload, string propertyName);
        public abstract void SelectedIndexChanged(string accountName);
        private string GetFilenameWithoutExtension(string filePath)
        {
            // Use Path.GetFileName to get the filename from the full path
            string filename = Path.GetFileName(filePath);
            // Use Path.GetFileNameWithoutExtension to remove the extension
            string filenameWithoutExtension = Path.GetFileNameWithoutExtension(filename);
            return filenameWithoutExtension;
        }

        public bool FilterOut (string filter, string propertyName, Account account)
        {
            //show all
            if (string.IsNullOrEmpty(filter) || filter.Equals("*"))
                return false;

            string value = GetPropertyValue(propertyName, account);
            if (filter.ContainsFilter("*"))
            {
                string nFilter = filter.Replace("*", "");

                if (!value.Contains(nFilter))
                    return true;
            }
            else if (!value.StartsWith(filter, StringComparison.InvariantCultureIgnoreCase))
                return true;
            
            return false;
        }

        private string GetPropertyValue(string propertyName, Account account)
        {
            PropertyInfo[] properties = typeof(Account).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!propertyName.Equals(property.Name, StringComparison.CurrentCultureIgnoreCase))
                    continue;
                try
                {
                    return property.GetValue(account).ToString();
                }
                catch { return string.Empty; }
            }
            return string.Empty;
        }



        public bool FilterOutXXXX(string filter, string name, string propertyName)
        {

            ////show modified, ignore filter value
            //if (filter.ContainsFilter("*"))
            //{
            //    string nFilter = filter.Replace("*", "");
            //    if (!name.Contains(nFilter))
            //        return true;
            //}
            if (string.IsNullOrEmpty(filter) || filter.Equals("*"))
                return false;

                if (!string.IsNullOrEmpty(filter) && !filter.Equals("*"))
                {
                    if (filter.ContainsFilter("*"))
                    {
                        string nFilter = filter.Replace("*", "");
                        if (!name.Contains(nFilter))
                            return true;
                    }
                    else if (!name.StartsWith(filter, StringComparison.InvariantCultureIgnoreCase))
                        return true;
                }
            return false;
        }
        public abstract void Save();
        public abstract void CacheSave(DataGridViewCellEventArgs e, string newValue, string key);
        public abstract bool ValueHasBeenUpdated(string accountName, string rowKeyName);

        public abstract void ShowModified();

        public abstract string Copy(string accName);
        public abstract void Delete(string accName);
    }

    internal interface IBasePackageController
    {
        void FilloutComponents(string filter, bool reload, string propertyName);
        void CacheSave(DataGridViewCellEventArgs e, string newValue, string key);
        void SelectedIndexChanged(string accountName);
        void ClearSubLists();
        string FileName { get; set; }
        void Save();
        bool ValueHasBeenUpdated(string accountName, string rowKeyName);
        void ShowModified();
        string Copy(string accName);
        void Delete(string accName);


    }

}
