using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Student_18
{
     class Student : Person , IPrintable
    {
        /*
         *  - Attributes: `Name`, `Mark`, `FullMark`
            - Functions: 
            - `GetPercentage()` → calculates result percentage
            - `GetGrade()` → returns grade based on percentage

         */
 
         double _mark;
         double _fullMark;

        public double Mark
        {
            get { return _mark; }
            set { _mark = value < 0 ? 0 : value; }
        }
        public double FullMark
        {
            get { return _fullMark; }
            set { _fullMark = value < 0 ? 0 : value; }
        }
        public Student(string name, double mark, double full_mark)
            :base(name)
        {
      
            Mark = mark;
            FullMark = full_mark;

        }
        public double GetPercentage()
        {
            return (Mark / FullMark) * 100;
        }
        public string GetGrade()
        {
            double percentage = GetPercentage();

            if (percentage >= 90)
                return "A";
            else if (percentage >= 80)
                return "B";
            else if (percentage >= 70)
                return "C";
            else if (percentage >= 60)
                return "D";
            else
                return "F";
        }
        public override string GetInfo()
        {
            return $"Student Name       : {Name} \n" +
                   $"Student Mark       : {Mark}\n" +
                   $"Student Percentage : {GetPercentage()} % \n" +
                   $"Student Grade      : {GetGrade()}";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student Name       : {Name} \n" +
                              $"Student Mark       : {Mark}\n" +
                              $"Student Percentage : {GetPercentage()} % \n" +
                              $"Student Grade      : {GetGrade()}");        }
    }
}
