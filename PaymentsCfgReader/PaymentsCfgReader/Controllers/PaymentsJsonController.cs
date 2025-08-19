using PaymentCFG.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PaymentCFG.Controllers
{

    internal class PaymentsJsonController : BasePackageController
    {
        private PaymentRootModel _root = null;
        private Dictionary<string, string> UpdatedDisplayList = null;
        public override void Save()
        {
            string json = JsonHelper.ToJson(_root, true);
            File.WriteAllText(FileName, json);
            ResetUpdatedDisplayList();
        }

        public override string FileName { get; set; } = string.Empty;

        public PaymentsJsonController(PaymentsCfgDlg dependencyDlg, string fileName) : base(dependencyDlg)
        {
            FileName = fileName;
        }
        public override void ClearSubLists()
        {
            MainDlg.listViewAccounts.Items.Clear();
        }
        private PaymentRootModel FromJson(string json)
        {
            try
            {
                ResetUpdatedDisplayList();
                var result = JsonHelper.FromJson<PaymentRootModel>(json);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void ResetUpdatedDisplayList()
        {
            UpdatedDisplayList = new Dictionary<string, string>();
        }



        public override void FilloutComponents(string filter, bool reload, string propertyName)
        {
            if (reload)
            {
                string jstring = File.ReadAllText(FileName);
                _root = FromJson(jstring);
                if (_root == null || _root.Accounts == null)
                {
                    MessageBox.Show("Invalid Format, missing Accounts section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            MainDlg.listViewAccounts.Items.Clear();

            foreach (var account in _root.Accounts)
            {

                string displayName = account.accountName;
                if (string.IsNullOrEmpty(propertyName))
                    propertyName = account.accountName;

                if (FilterOut(filter, propertyName, account))
                    continue;

                ListViewItem item = new ListViewItem(displayName) { Tag = account, ImageIndex = IsModified(displayName) ? 1 : 0 };
                MainDlg.listViewAccounts.Items.Add(item);
            }
        }

        public override void CacheSave(DataGridViewCellEventArgs e, string newValue, string accountKeyName)
        {
            string rowKeyName = MainDlg.dataGridViewMain.Rows[e.RowIndex].Tag.ToString();

            foreach (var currentAccount in _root.Accounts)
            {
                if (!currentAccount.accountName.Equals(accountKeyName))
                    continue;

                foreach (DataGridViewRow row in MainDlg.dataGridViewMain.Rows)
                {
                    if (!row.Tag.ToString().Equals(rowKeyName))
                        continue;

                    UpdateValue(currentAccount, newValue, rowKeyName);
                    AddtoUpdateList(accountKeyName, rowKeyName);
                    return;
                }
            }
        }

        private void AddtoUpdateList(string accName, string rowKey)
        {
            string key = GetKeyUpdateName(accName, rowKey);
            if (!UpdatedDisplayList.ContainsKey(key))
                UpdatedDisplayList.Add(key, rowKey);
        }

        private string GetKeyUpdateName(string accName, string rowKey)
        {
            return $"{accName}:{rowKey}";
        }

        private void UpdateValue(Account currentAccount, string newValue, string rowKeyName)
        {
            PropertyInfo[] properties = typeof(Account).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (rowKeyName.Equals(property.Name, StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        if (property.Name.Equals("enableLevel3", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (Boolean.TryParse(newValue, out bool bval))
                                property.SetValue(currentAccount, bval);
                            else
                                property.SetValue(currentAccount, false);
                        }
                        else
                            property.SetValue(currentAccount, newValue);
                    }
                    catch //(Exception ex)
                    {
                        //todo  handle
                    }
                    return;
                }
            }
        }

        public override bool ValueHasBeenUpdated(string accountName, string rowKeyName)
        {
            if (UpdatedDisplayList.Count == 0) return false;
            bool status = (UpdatedDisplayList.TryGetValue(GetKeyUpdateName(accountName, rowKeyName), out _));
            return status;
        }

        public override void SelectedIndexChanged(string accountName)
        {
            MainDlg.dataGridViewMain.Rows.Clear();
            foreach (var accName in _root.Accounts)
            {
                if (!accName.accountName.Equals(accountName))
                    continue;

                int i = MainDlg.dataGridViewMain.Rows.Add("Account Id", accName.accountId);
                MainDlg.dataGridViewMain.Rows[i].Tag = "accountId";

                i = MainDlg.dataGridViewMain.Rows.Add("Account Name", accName.accountName);
                MainDlg.dataGridViewMain.Rows[i].Tag = "accountName";

                i = MainDlg.dataGridViewMain.Rows.Add("Application Id", accName.applicationId);
                MainDlg.dataGridViewMain.Rows[i].Tag = "applicationId";

                i = MainDlg.dataGridViewMain.Rows.Add("Company Code", accName.companyCode);
                MainDlg.dataGridViewMain.Rows[i].Tag = "companyCode";

                i = MainDlg.dataGridViewMain.Rows.Add("Customer Id", accName.customerId);
                MainDlg.dataGridViewMain.Rows[i].Tag = "customerId";

                i = MainDlg.dataGridViewMain.Rows.Add("Secret Key", accName.secretKey);
                MainDlg.dataGridViewMain.Rows[i].Tag = "secretKey";

                i = MainDlg.dataGridViewMain.Rows.Add("User Id", accName.userId);
                MainDlg.dataGridViewMain.Rows[i].Tag = "userId";

                i = MainDlg.dataGridViewMain.Rows.Add("User Name", accName.userName);
                MainDlg.dataGridViewMain.Rows[i].Tag = "userName";

                i = MainDlg.dataGridViewMain.Rows.Add("Pwd", accName.pwd);
                MainDlg.dataGridViewMain.Rows[i].Tag = "pwd";

                i = MainDlg.dataGridViewMain.Rows.Add("Mid", accName.mid);
                MainDlg.dataGridViewMain.Rows[i].Tag = "mid";

                i = MainDlg.dataGridViewMain.Rows.Add("enableLevel3", accName.enableLevel3);
                MainDlg.dataGridViewMain.Rows[i].Tag = "enableLevel3";

                i = MainDlg.dataGridViewMain.Rows.Add("Success", accName.redirecturl);
                MainDlg.dataGridViewMain.Rows[i].Tag = "redirecturl";

                i = MainDlg.dataGridViewMain.Rows.Add("Declined", accName.redirectonerrorurl);
                MainDlg.dataGridViewMain.Rows[i].Tag = "redirectonerrorurl";

                i = MainDlg.dataGridViewMain.Rows.Add("Cancel", accName.cancelredirecturl);
                MainDlg.dataGridViewMain.Rows[i].Tag = "cancelredirecturl";

                i = MainDlg.dataGridViewMain.Rows.Add("Duplicate", accName.duplicateredirecturl);
                MainDlg.dataGridViewMain.Rows[i].Tag = "duplicateredirecturl";

                //ShowUpdatedValue(accountName);
                break;

            }
        }

        public override void ShowModified()
        {
            MainDlg.listViewAccounts.Items.Clear();

            foreach (var account in _root.Accounts)
            {
                string name = account.accountName;

                if (!IsModified(name))
                    continue;

                ListViewItem item = new ListViewItem(name) { Tag = account, ImageIndex = 1 };
                MainDlg.listViewAccounts.Items.Add(item);
            }

            if (MainDlg.listViewAccounts.Items.Count > 1)
                MainDlg.listViewAccounts.Columns[0].Width = -1;


        }

        private bool IsModified(string accName)
        {
            foreach (string key in UpdatedDisplayList.Keys)
            {
                string[] parsed = key.Split(':');
                if (accName.Equals(parsed[0], StringComparison.CurrentCultureIgnoreCase))
                    return true;
            }
            return false;
        }

        public override string Copy(string accName)
        {
            string newName = $"{accName}1";
            int i = 1;
            foreach (Account account in _root.Accounts)
            {
                if (account.accountName.Equals(newName, StringComparison.CurrentCultureIgnoreCase))
                    i++;
            }
            newName = $"{accName}{i}";
            Account newAccount = new Account();
            foreach (Account account in _root.Accounts)
            {
                if (account.accountName.Equals(accName, StringComparison.CurrentCultureIgnoreCase))
                {
                    //should have a clone
                    newAccount = new Account
                    {
                        accountName = newName,
                        applicationId = account.applicationId,
                        userName = account.userName,
                        pwd = account.pwd,
                        accountId = account.accountId,
                        customerId = account.customerId,
                        userId = account.userId,
                        companyCode = account.companyCode,
                        mid = account.mid,
                        duplicateredirecturl = account.duplicateredirecturl,
                        cancelredirecturl = account.cancelredirecturl,
                        redirecturl = account.redirecturl,
                        redirectonerrorurl = account.redirectonerrorurl,
                        secretKey = account.secretKey,
                        enableLevel3 = account.enableLevel3
                    };
                    AddtoUpdateList(newName, "accountName");
                    break;
                }
            }

            List<Account> list = new List<Account>(_root.Accounts)
            {
                newAccount
            };
            _root.Accounts = list.ToArray();
            return newName;
        }

        public override void Delete(string accName)
        {
            // ask to delete
            // enable save
            if (MessageBox.Show("Delete record?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            List<Account> list = new List<Account>();
            foreach (Account account in _root.Accounts)
            {
                if (!account.accountName.Equals(accName))
                    list.Add(account);
            }
            _root.Accounts = list.ToArray();
        }
    }

}
