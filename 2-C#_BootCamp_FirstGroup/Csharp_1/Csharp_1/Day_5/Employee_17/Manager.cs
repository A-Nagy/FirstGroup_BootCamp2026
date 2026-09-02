using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Employee_17
{
    class Manager : Employee
    {
     /*
      * `Bonus`
      * GetNetSalary()` → Salary + Bonus
      */

        public double Bounse { get; set; }

        public Manager(string name, double salary, double bounse) : base(name, salary)
        {
            Bounse = bounse;
        }

        public override double GetNetSalary() 
        {
            return Bounse + EmployeeSalary;
        }
    
    
    }
}
