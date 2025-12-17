using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04.HashTable
{
    internal class StringEqualityComparer : IEqualityComparer // hashtable do not use generic IEqualityComparer<T>
    {
        public new bool Equals(object? x, object? y)
        {
            //// cast object to string\]
            //// use "as" operator to avoid invalid cast exception [save casting]
            string? strX = x as string;
            string? strY = y as string;

            #region not save code and there is cases not handling
            //// can not use == operator because it is case sensitive 
            ///can not strX be null because how to call ToLower() method on null
            //return strX?.ToLower().Equals(strY?.ToLower()) ?? false;

            #endregion


            ////..use String.Equals static method with OrdinalIgnoreCase option to ignore case sensitivity
            //// ToLower() => Create New Object
            ////..StringComparison.OrdinalIgnoreCase is Enum type [StringComatison] => ignore case sensitivity compar the strings by their binary values and have some methods
            return string.Equals(strX, strY, StringComparison.OrdinalIgnoreCase);

        }

        public int GetHashCode(object? obj)
        {
            string? GetString = obj as string;
            return string.GetHashCode(GetString, StringComparison.OrdinalIgnoreCase);

        }
    }
}
