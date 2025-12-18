using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04.DictionaryHelper
{
    internal class EmployeeIdIqualityComaparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            // if x and y check for the same reference or nulls
            if (ReferenceEquals(x, y)) return true;
            // if either is null, they are not equal
            if (x is null || y is null) return false; // not Equals

            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
