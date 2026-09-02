using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5
{
     class EmployeeClass
    {
         
        double GetAnnualSalary(double salary)
        {
            return salary * 12;
        }
        string GetSalaryLevel(double salary)
        {
            return salary >= 15000 ? "high salary" :
                   salary >= 10000 ? "normal salary" :
                   salary >= 5000  ? "low salary" : "very low salary";
        }
        string GetAnnualSalaryLevel(double salary)
        {
          double AnnualSalary=GetAnnualSalary(salary);

            return AnnualSalary >= 180000 ? "high salary" :
                   AnnualSalary >= 120000 ? "normal salary" :
                   AnnualSalary >= 60000 ? "low salary" : "very low salary";
        }
         public string[] GetEmployeeSummary(string name, double salary)
        {
            return new string[]
                  { $"Employee Name : {name}",
                    $"Monthly Salary: {salary}",
                    $"Salary Level  : {GetSalaryLevel (salary)}",
                    $"Annual Salary : {GetAnnualSalary(salary)}",
                    $"Annual Salary Level : {GetAnnualSalaryLevel(salary)}"};
        }
        public void EmployeeSumaryPrint(string[] summary)
        {
            foreach (string Sum in summary)
            {
                Console.WriteLine(Sum);
            }
        }
        public object[] GetInfoFromUser()
        {
            Console.WriteLine("Enter Employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your monthly salary:");
            double salary = Convert.ToInt32(Console.ReadLine());

            return new object[] { name, salary };
        }
        public void DisplayEmployeeLabel()
        {
            Console.WriteLine("=================");
            Console.WriteLine("Employee Salary Info");
            Console.WriteLine("=================");
        }
    }
}
