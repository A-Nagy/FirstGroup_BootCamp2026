using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_2
{
     class Controls_If_Else_4
    {
 //       static void Main(string[] args)
 //       {
 //           Console.WriteLine("pls Enter Number");
 //           int num = Convert.ToInt32(Console.ReadLine());

 //           if (num % 2 == 0)
 //           {
 //               Console.WriteLine("this is Even Number ");
 //           }
 //           else 
 //           {
 //               Console.WriteLine("this is odd Number ");
 //           }



 //           //// ## ✅ Task 1: Employee Salary Info
 //           //// **Objective:**
 //           ////-- Ask the employee to enter their name and monthly salary.
 //           ////-- Display their name, monthly salary, and calculated annual salary.
 //           /// - If the salary is 10,000 or more → display "High Salary".
 //           /// - Otherwise → display "Low Salary".

 //           // 1.Variable Declaration
 //           string name;
 //           int salary;
 //           int annualSalary;

 //           // 2. Input from user
 //           Console.WriteLine("Enter your name:");
 //           name = Console.ReadLine();
 //           Console.WriteLine("Enter your monthly salary:");
 //           salary = Convert.ToInt32(Console.ReadLine());

 //           // 3. Calculate annual salary
 //           annualSalary = salary * 12;

 //           // 4. Output Result
 //           Console.WriteLine("=================");
 //           Console.WriteLine("Employee Salary Info");
 //           Console.WriteLine("=================");
 //           Console.WriteLine("Name: " + name);
 //           Console.WriteLine("Monthly Salary: " + salary);
 //           Console.WriteLine("Annual Salary: " + annualSalary);

 //           if(salary >= 10000)
 //           {
 //               Console.WriteLine("High Salary");
 //           }
 //           else 
 //           {
 //               Console.WriteLine("Low Salary");
 //           }




 //           //## ✅ Task 2: Student Percentage Calculator
 //           // **Objective:**
 //           // -Ask the student to enter their name, obtained mark, and full mark.
 //           //  percentage =mark / Fullmark * 100
 //           // - Calculate and display their percentage.
 //           // -If percentage is 50 % or more → display "Success".
 //           // - Otherwise → display "Failed".
 //           // -Display the name, marks,  percentage , status .

 //           // 1.Variable Declaration
 //           string StudentName;
 //           int Mark;
 //           int Full_Mark;
 //           int Perctange;

 //           // 2. Input from user
 //           Console.WriteLine("Enter your Name: ");
 //           StudentName = Console.ReadLine();

 //           Console.WriteLine("Enter your Mark: ");
 //           Mark = Convert.ToInt32(Console.ReadLine());

 //           Console.WriteLine("Enter the Full Mark: ");
 //           Full_Mark = Convert.ToInt32(Console.ReadLine());

 //           // 3. Calculate percentage
 //           Perctange = (Mark / Full_Mark) * 100;

 //           // 4. Output Result
 //           Console.WriteLine("Student Information : ");
 //           Console.WriteLine("Student Name : " + StudentName);
 //           Console.WriteLine("Student Mark : " + Mark);
 //           Console.WriteLine("Student Full Mark : " + Full_Mark);
 //           Console.WriteLine("Student Percentage : " + Perctange + "%");
 //           if (Perctange >= 50)
 //           {
 //               Console.WriteLine("you are successful");
 //           }
 //           else
 //           {
 //               Console.WriteLine("you are failed");
 //           }

 //           /*
 //            double fullMark;
 //double mark;
 //string name1;
 //double precentge;

 //Console.Write("enter your name : ");
 //name1 = Console.ReadLine();

 //Console.Write("enter your mark : ");
 //mark = Convert.ToDouble(Console.ReadLine());

 //Console.Write("enter full mark : ");
 //fullMark = Convert.ToDouble(Console.ReadLine());

 //precentge = (mark / fullMark) * 100;

 //Console.WriteLine("name " + name1 + "\n" + "mark " + mark +
 //    "\n" + "precentge:" + precentge + "%");

 //if (precentge >= 60)
 //{
 //    Console.WriteLine("you are successful");
 //}
 //else
 //{
 //    Console.WriteLine("you are failed");
 //}
 //            */


 //           //# ✅ Task 3: Patient BMI Calculator
 //           // *Objective:**
 //           //  height(in meters), and weight(in kg).
 //           //   Calculate BMI using the formula:
 //           //       BMI = weight / (height * height)
 //           //  -Display the name, height, weight, and BMI.
 //           //   - If BMI >= 25 → display "Over Weight".
 //           // - Otherwise → display "Normal Weight".

 //           //declear Var
 //           string PatientName;
 //           double height;
 //           double weight;
 //           double BMI;
 //           //inputs 
 //           Console.WriteLine("pls Enter Your Name ");
 //           PatientName = Console.ReadLine();
 //           Console.WriteLine("pls Enter Your Height ");
 //           height = Convert.ToDouble(Console.ReadLine());
 //           Console.WriteLine("pls Enter Your Weight ");
 //           weight = Convert.ToDouble(Console.ReadLine());
 //           //calcualte Bmi
 //           BMI = weight / (height * height);
 //           // Display Result 
 //           Console.WriteLine("Patient Name is " + PatientName);
 //           Console.WriteLine("Patient Height is " + height + " M");
 //           Console.WriteLine($"Patient Weight is   {weight} K.g");
 //           Console.WriteLine("BMI is " + BMI);
 //           if (BMI >= 25)
 //           {
 //               Console.WriteLine("over weight");
 //           }
 //           else
 //           {
 //               Console.WriteLine("normal weight");
 //           }

 //           /*
 //            * 
 //            *  string name;
 //               double height;
 //               double weight;
 //               string unitHeight;  
 //               string unitWeight; 
 //               double BMI;
 //               bool coract_format = true;

 //               Console.Write("enter name :");
 //               name = Console.ReadLine();

 //               Console.Write("enter height :");
 //               height = Convert.ToDouble(Console.ReadLine());

 //               Console.Write("enter unit of height : ");
 //               unitHeight = Console.ReadLine();

 //               Console.Write("enter weight : ");
 //               weight = Convert.ToDouble(Console.ReadLine());

 //               Console.Write("enter unit of weight : ");
 //               unitWeight = Console.ReadLine();

 //               if (unitHeight == "cm")
 //               {
 //                   height = height / 100;
 //               }
 //               else if (unitHeight == "ft")
 //               {
 //                   height = height * 0.3048;
 //               }
 //               else
 //               {
 //                   Console.WriteLine("the unit is not include ");
 //                   coract_format = false;
 //               }
 //               switch (unitWeight)
 //               {
 //                   case "g":
 //                       weight = weight / 1000;
 //                       break;
 //                   case "lb":
 //                       weight = weight * 0.453592;
 //                       break;
 //                   default:
 //                       Console.WriteLine("the unit is not include ");
 //                       coract_format = false;
 //                       break;
 //               }
 //               if (coract_format)
 //               {
 //                   try
 //                   {
 //                       BMI = weight / (height * height);

 //                       Console.WriteLine("name " + name + "\n" + "height: " + height + "m" +
 //                       "\n" + "weight :" + weight + "kg" + "\n" + "BMI :" + BMI);

 //                       if (BMI >= 25)
 //                       {
 //                           Console.WriteLine(" over weight");
 //                       }
 //                       else
 //                       {
 //                           Console.WriteLine(" normal weight");
 //                       }
 //                   }
 //                   catch (DivideByZeroException e)
 //                   {
 //                       Console.WriteLine(e);
 //                   }
 //               }
 //            */





 //       }
    }
}
