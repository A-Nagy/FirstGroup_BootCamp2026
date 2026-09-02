using Csharp_1.Day_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_4
{
     class ExplainFunction_13
    {
        public static void Static_add()
        {
            Console.WriteLine("pls Enter Number 1 :");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("pls Enter Number 2 :");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"The Result is : {num1 + num2}");
        }
        public void Instance_Multi()
        {
            Console.WriteLine("pls Enter Number 1 :");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("pls Enter Number 2 :");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"The Result is : {num1 * num2}");
        }
        public void Instance_Sub()
        {
            Console.WriteLine("pls Enter Number 1 :");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("pls Enter Number 2 :");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"The Result is : {num1 - num2}");
        }
        public static double  RETUREND_add()
        {
            Console.WriteLine("pls Enter Number 1 :");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("pls Enter Number 2 :");
            double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine($"The Result is : {num1 + num2}");
            //value , variable or exp

            return num1 + num2; 
        }

        public static double RETUREND_withParamters_add(double num1, double num2)
        {
             return num1 + num2;
        }

        static string[]  GetEmployeeInfo(string name , double salary ) 
        {
            double annualSalary = salary * 12;

            string level = (salary >= 15000) ? "high salary"   :
                           (salary >= 10000) ? "normal salary" :
                           (salary >= 5000)  ? "low salary"    : "very low salary";

            //if (salary >= 15000)
            //{
            //    level = "high salary";
            //}
            //else if (salary >= 10000)
            //{
            //    level = "normal salary";
            //}
            //else if (salary >= 5000)
            //{
            //    level = "low salary";
            //}
            //else
            //{
            //    level = "very low salary";
            //}

            string[] su = new string[] {  "the Employee Name   IS : "       + name        ,
                                          "the Employee Salary IS : "       + salary      ,
                                          "the Employee level  IS : "       + level       ,
                                          "the Employee annualSalary IS : " + annualSalary
                                         };

      


            return su;
        }

        static string[] Get_Student_Summery(string name, double mark, double FullMArk) 
        { 
            double precentage = (mark / FullMArk) * 100;
            string grede =   precentage >= 85 ? "A" :
                             precentage >= 75 ? "B" :
                             precentage >= 65 ? "C" :
                             precentage >= 50 ? "D" : "F";

            //string[] summery = new string[]
            //                                { $"The Student Name :     {name}  ",
            //                                  $"The Student Mark is    {mark} ",
            //                                  $"The Student PreCentage {precentage} %", 
            //                                  $"The Student Grade  is  {grede}"
            //                                };


            return new string[]
                                { $"The Student Name :     {name}  ",
                                    $"The Student Mark is    {mark} ",
                                    $"The Student PreCentage {precentage} %",
                                    $"The Student Grade  is  {grede}"
                                };
        }

        //static void Main(string[] args)
        //{

        //    /*
        //       Access Modifier   Accessing_shared/class-level      DataType     FunctionName(Paramters) {Bolck Of Code}
        //          Public                  static                     void
        //          private[D]            instance[D]                Returned
        //                                                         {int,string...}
        //    // */
        //    ///*
        //    // *  Belongs to the class itself
        //    // *  Called without creating an object.
        //    // */
        //    //Static_add();

        //    ///*
        //    // *Belongs to a specific object (instance of class)
        //    // *Requires creating an object to use.
        //    // */
        //    //ExplainFunction_13 ex13 = new ExplainFunction_13();
        //    //ex13.Instance_Multi();


        //    ////ex:
        //    ////lab5 printer shared  +> send to it any thing
        //    //// pdf forP_Notes 


        //    //Static_add();
        //    //double result = RETUREND_add();

        //    //Console.WriteLine(result);

        //    //Console.WriteLine(RETUREND_add());

        //    //Console.WriteLine("pls Enter Number 1 :");
        //    //double finum1 = double.Parse(Console.ReadLine());

        //    //Console.WriteLine("pls Enter Number 2 :");
        //    //double senum2 = double.Parse(Console.ReadLine());


        //    //double P_result = RETUREND_withParamters_add(finum1, senum2);
        //    //Console.WriteLine(result);

        //    //Console.WriteLine("pls Enter Name ");
        //    //string emp_name = Console.ReadLine();

        //    //Console.WriteLine("pls Enter Salary ");
        //    //double emp_Salary =double.Parse( Console.ReadLine());

        //    //string[] result = GetEmployeeInfo(emp_name, emp_Salary);

        //    //foreach (string s in result)
        //    //{
        //    //    Console.WriteLine(s);
        //    //}

        //    string[] studentSummary = Get_Student_Summery("Ahmad ", 95, 100);
        //    foreach (string s in studentSummary) 
        //    {
        //        Console.WriteLine(s);
        //    }

           
        //}

        /*
         * make simple Calculator For The Basic Procces {+ ,- ,*, / }
         * using What You Learn In Functions 
         */
        /*employee Infromation 
         * name 
         * salary 
         * annual salary 
         * level 
         */
        /*
         * `GetStudentSummary(name, mark, fullMark)`
         * → returns name, mark, percentage, and grade.
         */
    }
}
