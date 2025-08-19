using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace PaymantCFG.Utilities
{
    public delegate void ColumnSync(int index);

    /// <summary>
    /// ListView Column Sorter class
    /// </summary>
    public class ListViewColumnSorter : IComparer
    {
        private int ColumnToSort;
        private SortOrder OrderOfSort;
        private CaseInsensitiveComparer ObjectCompare;
        private ListView listView;
        private int ColumnIndexIsNumeric = 20;

        public event ColumnSync OnColumnSync;

        public ListViewColumnSorter(ListView lView, int ColumnIndexIsNumeric = 20)
        {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
            this.listView = lView;
            this.listView.ListViewItemSorter = this;
            this.ColumnIndexIsNumeric = ColumnIndexIsNumeric; // this is used if the column to be sorted uses numeric values
            listView.ColumnClick += ListView_ColumnClick;

        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortColumnSync(e.Column);
            OnColumnSync?.Invoke(e.Column);
        }

        public void SortColumnSync(int index)
        {
            if (index == this.SortColumn)
            {
                if (this.Order == SortOrder.Ascending)
                {
                    this.Order = SortOrder.Descending;
                }
                else
                {
                    this.Order = SortOrder.Ascending;
                }
            }
            else
            {
                this.SortColumn = index;
                this.Order = SortOrder.Ascending;
            }

            this.listView.Sort();
        }

        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;
            if (ColumnToSort == ColumnIndexIsNumeric)
                compareResult = CompareSize(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            else
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);

            if (OrderOfSort == SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                return (-compareResult);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Compare File Size
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int CompareSize(object a, object b)
        {
            string text = a as string;
            string text2 = b as string;
            if (text != null && text2 != null)
            {
                if (text.Length == text2.Length)
                    return ObjectCompare.Compare(b, a);

                return text.Length > text2.Length ? -1 : 1;
            }

            return Comparer.Default.Compare(a, b);
        }

        public int SortColumn { set { ColumnToSort = value; } get { return ColumnToSort; } }

        public SortOrder Order { set { OrderOfSort = value; } get { return OrderOfSort; } }

    }
}