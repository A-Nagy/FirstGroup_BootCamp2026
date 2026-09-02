using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.FirstStepInTask_16_DashBoardSystem
{
     class StudentClass
    {
        public  object[] StudentInputs()
        {
            Console.WriteLine("Enter Student Name: ");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student Mark: ");
            double Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Full Mark: ");
            double Full_Mark = Convert.ToInt32(Console.ReadLine());

            return new object[] { StudentName, Mark, Full_Mark };
        }
        double GetPercentage(double mark, double fullmark)
        {
            return (mark / fullmark) * 100;
        }
        string GetGrade(double mark, double fullmark)
        {
            double Perctange = GetPercentage(mark, fullmark);
            //if (Perctange >= 85)
            //{
            //    return  "Excellent ";
            //}
            //else if (Perctange >= 75)
            //{
            //    return "Very Good ";
            //}
            //else if (Perctange >= 65)
            //{
            //    return "Good ";
            //}
            //else if (Perctange >= 50)
            //{
            //    return  "Pass ";
            //}
            //else
            //{
            //    return "Failed ";
            //}
            return Perctange >= 85 ? "Excellent " :
                   Perctange >= 75 ? "Very Good " :
                   Perctange >= 65 ? "Good " :
                   Perctange >= 50 ? "Pass " : "Failed ";

        }
        public  void PrintStudentLabel()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Student Information");
            Console.WriteLine("===================");
        }
        public  string[] GetStudentSummary(string StudentName, double Mark, double Full_Mark)
        {

            return new string[]
            {
                   $"Student Information : \n"              ,
                   $"Student Name : {StudentName} \n"       ,
                   $"Student Mark : {Mark}\n"               ,
                   $"Student Full Mark : {Full_Mark}\n"     ,
                   $"Student Percentage : {GetPercentage(Mark, Full_Mark)} % \n" ,
                   $"Student Grade : {GetGrade(Mark, Full_Mark)}"
            };
        }
        public  void PrintSummary(string[] Summary)
        {
            foreach (string s in Summary)
            {
                Console.WriteLine(s);
            }
        }
    }
}
