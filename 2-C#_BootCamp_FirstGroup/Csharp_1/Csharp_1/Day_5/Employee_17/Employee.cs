using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Employee_17
{
     class Employee : Person , IPrintable
    {
        //fields
         double _salary;
        //Properties
        public double EmployeeSalary
        {
            get { return _salary; }
            set { _salary = value < 2000 ? 25000 : value; }
        }
        //Constractor
        public Employee(string name, double salary):
            base(name) 
        {
         
            EmployeeSalary = salary;
        }
        public virtual double GetNetSalary() 
        {
            return EmployeeSalary;
        }
        public override string GetInfo() 
        {
            return $"Employee Name IS {Name} \n" +
                   $"Employee Salary is {GetNetSalary()}\n";   
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Employee Name IS {Name} \n" +
                              $"Employee Salary is {GetNetSalary()}\n");
        }

        //Methodes That Do Not Take Parameters
        //method Debend on the class variables (EmployeeName, EmployeeSalary)
        //public double GetAnnualSalary()
        // {
        //     return EmployeeSalary * 12;
        // }
        //public string GetSalaryLevel()
        // {
        //     return EmployeeSalary >= 15000 ? "high salary" :
        //            EmployeeSalary >= 10000 ? "normal salary" :
        //            EmployeeSalary >= 5000 ? "low salary" : "very low salary";
        // }
        //public string GetAnnualSalaryLevel()
        // {
        //     double AnnualSalary = GetAnnualSalary();

        //     return AnnualSalary >= 180000 ? "high salary" :
        //            AnnualSalary >= 120000 ? "normal salary" :
        //            AnnualSalary >= 60000 ? "low salary" : "very low salary";
        // }

        // //Methodes That Take Parameters
        // public string[] GetEmployeeSummary()
        // {
        //     return new string[]
        //           { $"Employee Name : {EmployeeName}",
        //             $"Monthly Salary: {EmployeeSalary}",
        //             $"Salary Level  : {GetSalaryLevel ()}",
        //             $"Annual Salary : {GetAnnualSalary()}",
        //             $"Annual Salary Level : {GetAnnualSalaryLevel()}"};
        // }
        // public void EmployeeSumaryPrint(string[] summary)
        // {
        //     foreach (string Sum in summary)
        //     {
        //         Console.WriteLine(Sum);
        //     }
        // }
        // public object[] GetInfoFromUser()
        // {
        //     Console.WriteLine("Enter Employee name:");
        //     string name = Console.ReadLine();

        //     Console.WriteLine("Enter your monthly salary:");
        //     double salary = Convert.ToInt32(Console.ReadLine());

        //     return new object[] { name, salary };
        // }
        // public void DisplayEmployeeLabel()
        // {
        //     Console.WriteLine("=================");
        //     Console.WriteLine("Employee Salary Info");
        //     Console.WriteLine("=================");
        // }
    }
}
