using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04
{
    internal class Employee
    {

        public int Id { get; set; }
        public string?  Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Salary}";   
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id &&
                   Name == employee.Name &&
                   Salary == employee.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }
    }
}
