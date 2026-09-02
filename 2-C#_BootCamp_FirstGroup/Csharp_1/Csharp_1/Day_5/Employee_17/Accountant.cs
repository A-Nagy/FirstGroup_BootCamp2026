using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Employee_17
{
    internal class Accountant :Employee
    {/*
      * `TaxDeduction`
      * GetNetSalary()` → Salary - Tax
      */
        public double Tax { get; set; }

        public Accountant(string name, double salary, double tax)
            : base(name, salary)
        {
            this.Tax = tax;
        }

        public override double GetNetSalary()
        {
            return base.EmployeeSalary - Tax;
        }

    }
}
