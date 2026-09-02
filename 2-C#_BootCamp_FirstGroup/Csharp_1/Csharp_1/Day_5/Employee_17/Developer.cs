using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Employee_17
{
    class Developer : Employee
    {

        /*
         * `OvertimeHours`, `HourlyRate`
        * GetNetSalary()` → Salary + Overtime earnings
        */
        public double OvertimeHours { get; set; }
        public double HourlyRate    { get; set; }
 
        public Developer(string name, double salary, double overtimeHours, double hourlyRate) : base(name, salary)
        {
            OvertimeHours = overtimeHours;
            HourlyRate = hourlyRate;
        }

        public override double GetNetSalary() 
        {
            //return (OvertimeHours * HourlyRate) + base.GetNetSalary();
            return (OvertimeHours * HourlyRate) + base.EmployeeSalary;
            //return (OvertimeHours * HourlyRate) + EmployeeSalary;


        }



    }
}
