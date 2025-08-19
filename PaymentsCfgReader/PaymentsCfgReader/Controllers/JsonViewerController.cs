using DependencyScan.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using DependencyScan.Views;
using DependencyScan.Controllers;

namespace DependencyScan
{
    public class JsonViewerController : BasePackageController
    {
        public JsonViewerCtrl JsonViewerControl { get; set; }
        public override string FileName { get; set; } = string.Empty;

        public JsonViewerController(PaymentsCfgDlg dependencyDlg, string fileName, bool isNative) : base(dependencyDlg)
        {
            FileName = fileName;
            IsNative = isNative;
            JsonViewerControl = new JsonViewerCtrl();
            EmbeddedControl = JsonViewerControl as Control;
            AddToTabControl(this, "Native View", fileName);
        }

        public override void SelectedIndexChanged() { }
        public override void ClearSubLists() {}
        public override VulnerabilityLevel CurrentVulnerabilityLevel { get; set; } = VulnerabilityLevel.All;
        public override Control EmbeddedControl { get; set; }
        public override void FilloutComponents(string filter)
        {
            string jstring = File.ReadAllText(FileName);
            JsonViewerControl.RT.Text = jstring;
        }
        public override void SaveToReport()
        {

        }


    }
}
