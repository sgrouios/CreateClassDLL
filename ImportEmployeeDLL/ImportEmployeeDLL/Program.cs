using System;
using EmployeeAddSalary;

namespace ImportEmployeeDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee_Two emp = new Employee_Two(1, "Stephen", "Grouios", "Senior Developer", 80000);

            Console.Write(emp.ToString());
            Console.ReadLine();
        }
    }
}
