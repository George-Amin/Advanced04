using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04.EmployeeHelper
{
    internal class EmployeeNameComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (ReferenceEquals(x, y)) return 0;
            return string.Compare(x.Name, y.Name,StringComparison.Ordinal);
        }
    }
}
