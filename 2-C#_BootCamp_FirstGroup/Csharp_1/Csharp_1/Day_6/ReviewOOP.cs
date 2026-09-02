using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_6
{
     class ReviewOOP
    {

 //       static void Main(string[] args)
 //       {
 ///*
 //- * Abstraction   * Employee class is abstract and hides implementation details using abstract method AnnualSalary()
 //- * Encapsulation * Private fields (name, salary, etc.) with public properties (getters/setters)
 //- * Inheritance   * EmployeeBase  and Employee
 //- * Polymorphism  * GetNetSalary() is overridden differently in each derived class.
 //                    Base class reference holds derived class objects
 
 // */

 //       }
    }

    public abstract  class Employee
    {
      private string _name  ;
      private double _salary;
      public string Name { get => _name; set => _name = value; }
      public double Salary { get => _salary; set => _salary = value; }
      public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
      public abstract double AnnualSalary();
        
    }
    public class EmployeeBasic : Employee
    {
   
        double _commission;

        public double Commission { get => _commission; set => _commission = value; }

        public EmployeeBasic(string name, double salary, double commission)
            :base(name,salary) 
        {
      
            Commission = commission;
        }

  
        public override double AnnualSalary()
        {
            return (Salary * 12) + Commission;
        }

    }
    public class EmployeeHourly :Employee
    {
        private double _overtime;
        public double Overtime { get => _overtime; set => _overtime = value; }
        public EmployeeHourly(string name, double salary,double overtime) : base(name, salary)
        {
            Overtime = overtime;
        }
        public override double AnnualSalary()
        {
             return (Salary * 12) + Overtime;
        }
    }
}
