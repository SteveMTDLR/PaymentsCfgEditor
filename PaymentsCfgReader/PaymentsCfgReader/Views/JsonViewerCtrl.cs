using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentCFG.Views
{
    public partial class JsonViewerCtrl : UserControl
    {
        public JsonViewerCtrl()
        {
            InitializeComponent();
        }
        public RichTextBox RT { get { return richTextBox; } }
    }
}
