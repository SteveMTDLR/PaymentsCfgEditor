using DependencyScan.Controllers;
using DependencyScan.Models;
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
using TextSearch.Utilities;

namespace DependencyScan.Views
{
    public partial class PaymentsCtrl : UserControl
    {
        private PaymentsJsonController _payJsonController = null;
        public PaymentsCtrl()
        {
            InitializeComponent();
            new ListViewColumnSorter(this.listViewMain);
        }

        internal void Setup (PaymentsJsonController payCtrl)
        {            
            _payJsonController = payCtrl;
        }

        public ListView ListViewMain { get { return listViewMain; } }

        
        public RichTextBox RichTextBoxMain { get { return richTextBox; } }
        public ImageList Images { get { return imageListTop; } }


        private void FilloutComponents(string fileName)
        {

            if (fileName == null)
            {
                ListViewMain.Items.Clear();
                return;
            }
        }

        private void listViewVul_DoubleClick(object sender, EventArgs e)
        {
            //OPSystem.Instance.OpenUrl(listViewVul);
        }

        private void richTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            OPSystem.Instance.OpenUrl(e.LinkText);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textContents = richTextBox.Text;
            Clipboard.SetText(textContents);
        }

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            _payJsonController.SelectedIndexChanged();            
        }

        private void toolStripMenuItemShowReferences_Click(object sender, EventArgs e)
        {
            //_payJsonController.ShowDependency(listViewDependencies.Focused ? listViewDependencies : listViewBC, true);
        }



        private void EnableForUrl(ToolStripButton button, ListView lv)
        {
            button.Enabled = false;
            if (lv.Items.Count == 0) return;
            if (lv.SelectedItems == null || lv.SelectedItems.Count == 0 || lv.SelectedItems[0] == null) return;
            button.Enabled = (lv.SelectedItems[0].SubItems[1].Text.StartsWith("http"));
        }

        private void listViewBC_DoubleClick(object sender, EventArgs e)
        {
            //_payJsonController.ShowDependency(listViewBC, false);
        }

    }
}
