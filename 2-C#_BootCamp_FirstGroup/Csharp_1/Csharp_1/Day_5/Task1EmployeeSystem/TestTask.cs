using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Task1EmployeeSystem
{
     class TestTask
    {
        //static void Main(string[] args)
        //{ 
        //    Employee employee = new Employee("TestName", 10000);
        //    Console.WriteLine(  employee.GetSalaryLevel(employee.CalculateAnnualSalary()) ) ;
        //}
    }

    public abstract class EmployeeBase 
    {
        string _name;
        double _monthlySalary;
        public string Name { get => _name; set => _name = value; }
        public double MonthlySalary { get => _monthlySalary; set => _monthlySalary = value; }
        public EmployeeBase(string name, double monthlySalary)
        {
            Name = name;
            MonthlySalary = monthlySalary;
        }

        public abstract double CalculateAnnualSalary();
     

    }
    public interface ISalaryLevel
    {
        string GetSalaryLevel(double annualSalary);
    }
    public class Employee : EmployeeBase, ISalaryLevel
    {
        public Employee(string name, double monthlySalary) : base(name, monthlySalary)
        {
        }

        public override double CalculateAnnualSalary()
        {
            return MonthlySalary * 12;
        }

        public string GetSalaryLevel(double annualSalary)
        {
            return annualSalary >= 180000 ? "High Salary "   :
                   annualSalary >= 120000 ? "Normal Salary " :
                   annualSalary >= 60000  ? "Low Salary"     : "Very Low Salary";
        }
    }
}
