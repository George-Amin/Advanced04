using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04.DictionaryHelper
{
    public class StringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? strX, string? strY)
        {
         
            return string.Equals(strX , strY, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
           return string.GetHashCode(obj, StringComparison.OrdinalIgnoreCase);  
        }
    }
}
