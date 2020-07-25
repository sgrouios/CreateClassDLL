using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDLL
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }

        public Employee(int empID, string firstName, string surname, string position)
        {
            EmpID = empID;
            FirstName = firstName;
            Surname = surname;
            Position = position;
        }

        public override string ToString()
        {
            return $"ID: {EmpID}, Name: {FirstName} {Surname}, Position: {Position}";
        }
    }
}
