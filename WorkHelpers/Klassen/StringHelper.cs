using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHelpers.Klassen
{
    public static class StringHelper
    {
        public static string cleanupSQL(string input) {
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            input = input.Replace("}", "");
            input = input.Replace("\t", "");
            input = input.Replace("\n", "");
            input = input.Replace("\r", "");
            return input;
        }

    }
}
