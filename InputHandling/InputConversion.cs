using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumismaticsCatalog.Validation
{
    public static class InputConversion
    {
        public static string? ConvertString(string str, bool can_be_empty = true)
        {
            str = str.Trim();

            if (str.Length > 100)
                return null;

            if (!can_be_empty && str.Length == 0)
                return null;

            return str;
        }
        public static int? ConvertToInt(string str)
        {
            int res;
            bool success = int.TryParse(str, out res);
            if (!success)
                return null;
            else
                return res;
        }

        public static double? ConvertToDouble(string str)
        {
            double res;
            bool success = double.TryParse(str, out res);
            if (!success)
                return null;
            else
                return res;
        }
    }
}
