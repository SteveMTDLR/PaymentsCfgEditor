using PaymentCFG.Controllers;
using PaymentCFG.Models;
using PaymentCFG.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PaymantCFG.Helper;
using PaymantCFG.Utilities;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Principal;

namespace PaymentCFG
{
    public partial class PaymentsCfgDlg : Form
    {
        private BasePackageController _payController = null;
        private string _fileName = null;
        private bool _selectedFileNameOnStartup = false;      
        private string CurrentFilterPropertyKey = null;

        public PaymentsCfgDlg()
        {
            InitializeComponent();
            this.TopMost = true;
            _selectedFileNameOnStartup = SelectFile(false);

            dataGridViewMain.RowHeadersVisible = true;
            dataGridViewMain.RowHeadersWidth = 25;
            dataGridViewMain.RowPostPaint += DataGridViewMain_RowPostPaint;
            dataGridViewMain.KeyDown += DataGridViewMain_KeyDown;
            SetFilterOptions();
        }

        private void SetFilterOptions ()
        {
            tsAccountName.Click += FilterOption_Click;
            tsAccountId.Click += FilterOption_Click;
            tsCustomerId.Click += FilterOption_Click;
            tsMid.Click += FilterOption_Click;
            tsUserName.Click += FilterOption_Click;
            tssecretKey.Click += FilterOption_Click;
            tsPwd.Click += FilterOption_Click;
            tsAccountName.Checked = true;
            CurrentFilterPropertyKey = tsAccountName.Tag.ToString();
            tsFilter.Text = $"Filter: {CurrentFilterPropertyKey}";
        }

        private void FilterOption_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            tsAccountName.Checked = false;
            tsAccountId.Checked = false;
            tsCustomerId.Checked = false;
            tsMid.Checked = false;
            tsUserName.Checked = false;
            tssecretKey.Checked = false;
            tsPwd.Checked = false;
            item.Checked = true;
            CurrentFilterPropertyKey = item.Tag.ToString();
            tsFilter.Text = $"Filter: {CurrentFilterPropertyKey}";
        }

        private void DataGridViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F2)
            //    e.SuppressKeyPress = true; // Prevents the key press from being processed
        }

        private void DataGridViewMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Get the bounds of the row header
            Rectangle rowHeaderBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dataGridViewMain.RowHeadersWidth,
                e.RowBounds.Height);

            bool hasUpdatedValue = _payController.ValueHasBeenUpdated(GetSelectAccount(), GetSelectRowName(e.RowIndex));
            Color br = hasUpdatedValue ? Color.Red : Color.Black;
            using (Brush brush = new SolidBrush(br))
            {

                string customSymbol = hasUpdatedValue ? "★" : ""; // Unicode star symbol               
                e.Graphics.DrawString(customSymbol, dataGridViewMain.Font, brush, rowHeaderBounds,
                    new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
            }
        }

        private string GetSelectAccount()
        {
            if (listViewAccounts.SelectedItems == null || listViewAccounts.Items.Count == 0)
                return "___NOTSELCTED___";

            try
            {
                return listViewAccounts.SelectedItems[0].Text;
            }
            catch
            {
                return "___NOTSELCTED___";
            }
        }

        private string GetSelectRowName(int index)
        {
            if (index < 0) return "___NOTROW___";
            return dataGridViewMain.Rows[index].Tag.ToString();
        }

        private void DependencyDlg_Shown(object sender, EventArgs e)
        {
            this.TopMost = false;
            if (!_selectedFileNameOnStartup)
                Close();

            dataGridViewMain.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            if (listViewAccounts.Items.Count > 1)
            {
                listViewAccounts.Columns[0].Width = -2;
                int i = listViewAccounts.Columns[0].Width;
                listViewAccounts.Columns[0].Width = i - 10;
            }
        }

        private bool SelectFile(bool rememberLastFile)
        {
            if (!rememberLastFile || string.IsNullOrEmpty(_fileName))
                _fileName = OPSystem.Instance.SelectFile();

            //_fileName = @"D:\TFS\SDS\TDLR.Payments\src\TDLR.Payments.Api\appsettings.json";

            Fillout();
            return !string.IsNullOrEmpty(_fileName);
        }
        
        private void Fillout()
        {

            if (_fileName == null)
            {
                tsFilter.Enabled = false;
                toolStripTextBoxFilter.Enabled = false;
                return;
            }

            _payController = ControllerFactory.Get(this, _fileName, CurrentFilterPropertyKey);

            toolStripStatusLabel.Text = _payController.FileName;

        }

        private void toolStripButtonReloadFile_Click(object sender, EventArgs e)
        {
            if (toolStripButtonSave.Enabled)
            {
                if (MessageBox.Show("There are changes, do you want to disgard changes?", "Reload",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            SelectFile(true);
            dataGridViewMain.Rows.Clear();
            this.listViewAccounts.Items[0].Selected = true;
            toolStripButtonSave.Enabled = false;
            toolStripButtonShowModified.Enabled = false;
        }

        private void toolStripButtonFilter_Click(object sender, EventArgs e)
        {
            _payController.FilloutComponents(toolStripTextBoxFilter.Text, false, CurrentFilterPropertyKey);
        }

        private void toolStripTextBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _payController.FilloutComponents(toolStripTextBoxFilter.Text, false, CurrentFilterPropertyKey);
        }

        private void DependencyDlg_Load(object sender, EventArgs e)
        {
            SettingsHelper.Instance.DlgLoad(this);
        }

        private void DependencyDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toolStripButtonSave.Enabled)
            {
                if (MessageBox.Show("There are changes, do you want to disgard changes?", "Changes detected",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

            SettingsHelper.Instance.DlgClosing(this);
        }

        private void listViewAccounts_Click(object sender, EventArgs e)
        {
            _payController.SelectedIndexChanged(GetSelectAccount());
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            _payController.Save();
            toolStripButtonSave.Enabled = false;
            toolStripButtonShowModified.Enabled = false;
        }

        private void dataGridViewMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == 0)
                return;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                string newValue = dgv[e.ColumnIndex, e.RowIndex].Value?.ToString();
                string rowKeyName = dataGridViewMain.Rows[e.RowIndex].Tag.ToString();
                if (rowKeyName.Equals("enableLevel3", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (!Boolean.TryParse(newValue, out bool bval))
                    {
                        dataGridViewMain.CancelEdit();
                        return;
                    }
                }
                _payController.CacheSave(e, newValue, GetSelectAccount());
                toolStripButtonSave.Enabled = true;
                toolStripButtonShowModified.Enabled = true;
            }
        }

        private void dataGridViewMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);

            listViewAccounts.SelectedItems[0].ImageIndex = 1;  
            
        }

        private void toolStripButtonShowModified_Click(object sender, EventArgs e)
        {
            bool enable = true;

            if (toolStripButtonShowModified.Tag == null || toolStripButtonShowModified.Tag.ToString() == "")
            {
                _payController.ShowModified();
                toolStripButtonShowModified.Text = "Clear Modified View";
                toolStripButtonShowModified.Tag = "1";
                enable = false;
            }
            else
            {
                _payController.FilloutComponents("", false, null);
                toolStripButtonShowModified.Text = "Show Modified";
                toolStripButtonShowModified.Tag = "";
            }
            tsFilter.Enabled = enable;
            toolStripTextBoxFilter.Enabled = enable;
        }

        private void tsDropDownOptions_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonClearFilter_Click(object sender, EventArgs e)
        {
            toolStripTextBoxFilter.Text = string.Empty;
            _payController.FilloutComponents(toolStripTextBoxFilter.Text, false, CurrentFilterPropertyKey);
        }

        private void listViewAccounts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listViewAccounts.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            string newname = _payController.Copy(GetSelectAccount());
            _payController.FilloutComponents(string.Empty, false, string.Empty);
            listViewAccounts.Items[listViewAccounts.Items.Count - 1].Selected = true;
            listViewAccounts.Select();
            listViewAccounts.EnsureVisible(listViewAccounts.Items.Count - 1);
            toolStripButtonSave.Enabled = true;
            //TODO mark new record as modified
            toolStripButtonShowModified.Enabled = true;
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            _payController.Delete(GetSelectAccount());
            _payController.FilloutComponents(string.Empty, false, string.Empty);
            toolStripButtonSave.Enabled = true;
            //TODO mark new record as modified
            toolStripButtonShowModified.Enabled = true;
        }
    }
}
