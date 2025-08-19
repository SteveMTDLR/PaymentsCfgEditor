using PaymentCFG.Controllers;
using PaymentCFG.Models;
using PaymentCFG.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCFG.Controllers
{

    public class ControllerFactory
    {

        public static BasePackageController Get (PaymentsCfgDlg dlg, string fileName, string filterPropertyName)
        {
            BasePackageController packageController = new PaymentsJsonController(dlg, fileName);
            packageController.FilloutComponents(string.Empty, true, filterPropertyName);
            return packageController;
        }
    }
}
