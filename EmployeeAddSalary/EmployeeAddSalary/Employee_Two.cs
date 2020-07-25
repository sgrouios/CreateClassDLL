using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDLL;

namespace EmployeeAddSalary
{
    public class Employee_Two: Employee
    {
        public double Salary { get; set; }

        public Employee_Two(int id, string first, string last, string pos, double salary): base(id, first, last, pos)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $", Salary: ${Salary}";
        }
    }
}
