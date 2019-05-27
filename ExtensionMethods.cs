using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class ExtensionMethods
    {
        public static bool ToInt(this string value)
        {
            return int.TryParse(value, out var _);
        }
    }
}
