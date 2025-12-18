using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04.SortedDictionaryHelper
{
    internal class SortingDescComparer : IComparer<string>
    {
        public int Compare(string? Str1, string? Str2)
        {

            /*
             *Str1 and Str2 are maybe nulls or one of them is null.
             *
             
             */
            if (Str1 is null && Str2 is null) return 0;
            if (Str1 is null) return 1;
            if (Str2 is null) return -1;
            return string.Compare(Str2, Str1);

        }
    }
}
