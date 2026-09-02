using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Task2_StudentSystem
{
    class TestTAsk2
    {
        //static void Main(string[] args)
        //{
        //    /*
        //     * Student System
        //                - Create an **abstract class** `StudentBase` with:
        //                         - Properties: `Name`, `Mark`, `FullMark`
        //                         - Abstract Method: `GetPercentage()`
        //                - Create an **interface** `IGrading` with:
        //                         - Method: `GetGrade(double percentage)`
                
        //    - Implement a class `Student` that inherits from `StudentBase` and implements `IGrading`.

        //     */
        //    Student student = new Student("Fatimah", 85, 100);

        //    double percentage = student.GetPercentage();
        //    string grade = student.GetGrade(percentage);

        //    Console.WriteLine($"Student Name: {student.Name}");
        //    Console.WriteLine($"Mark: {student.Mark}/{student.FullMark}");
        //    Console.WriteLine($"Percentage: {percentage}%");
        //    Console.WriteLine($"Grade: {grade}");
        //}
    }

    public abstract class StudentBase
    {
        public string Name { get; set; }
        public double Mark { get; set; }
        public double FullMark { get; set; }

        protected StudentBase(string name, double mark, double fullMark)
        {
            Name = name;
            Mark = mark;
            FullMark = fullMark;
        }

        public abstract double GetPercentage();
    }

    public interface IGrading
    {
        string GetGrade(double percentage);
    }

    public class Student : StudentBase, IGrading
    {
        public Student(string name, double mark, double fullMark)
            : base(name, mark, fullMark)
        {
        }

        public override double GetPercentage()
        {
            return (Mark / FullMark) * 100;
        }

        public string GetGrade(double percentage)
        {
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
    }
}

     