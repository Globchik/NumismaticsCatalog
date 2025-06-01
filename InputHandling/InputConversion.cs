using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumismaticsCatalog.InputHandling
{
    public static class InputConversion
    {
        public static string? ConvertString(string? str, bool can_be_empty = true)
        {
            if (str == null)
                return null;

            str = str.Trim();

            if (str.Length > 100)
                return null;

            if (!can_be_empty && str.Length == 0)
                return null;

            return str;
        }
        public static int? ConvertToAmount(string str)
        {
            int res;
            bool success = int.TryParse(str, out res);
            if (!success || res < 1)
                return null;
            else
                return res;
        }

        public static int? ConvertToYear(string str)
        {
            int res;
            bool success = int.TryParse(str, out res);
            if (!success || res < 0 || res > 9999)
                return null;
            else
                return res;
        }

        public static float? ConvertToCoinValue(string str)
        {
            float res;
            bool success = float.TryParse(str, out res);
            if (!success || res < 0)
                return null;
            else
                return (float)Math.Round(res,2);
        }
    }
}
