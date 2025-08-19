using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PaymentCFG
{
    public static class JsonHelper
    {
        public static string ToJson(object value, bool indented = false)
        {
            Formatting formatting = indented ? Formatting.Indented : Formatting.None;

            var json = JsonConvert.SerializeObject(value, formatting);

            return json;
        }

        public static T FromJson<T>(string value)
        {
            var result = JsonConvert.DeserializeObject<T>(value);
            return result;
        }

        public static object FromJson(string value)
        {
            var result = JsonConvert.DeserializeObject(value);

            return result;
        }
    }
}
