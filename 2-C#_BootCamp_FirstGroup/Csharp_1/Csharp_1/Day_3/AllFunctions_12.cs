using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_3
{
     class AllFunctions_12
    {
        public static void EmployeesSalaryCheck()
        {
            // 1.Variable Declaration
            string name;
            int salary;
            int annualSalary;
            Console.WriteLine("=================");
            Console.WriteLine("Employee Salary Info");
            Console.WriteLine("=================");
            // 2. Input from user
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your monthly salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            // 3. Calculate annual salary
            annualSalary = salary * 12;
            // 4. Output Result
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Monthly Salary: " + salary);
            Console.WriteLine("Annual Salary: " + annualSalary);
            if (salary >= 15000)
            {
                Console.WriteLine("high salary");
            }
            else if (salary >= 10000)
            {
                Console.WriteLine("normal salary");
            }
            else if (salary >= 5000)
            {
                Console.WriteLine("low salary");
            }
            else
            {
                Console.WriteLine("very low salary");

            }


        }

        public static void Student_Information()
        {
            // 1.Variable Declaration
            string StudentName;
            double Mark;
            double Full_Mark;
            double Perctange;
            Console.WriteLine("=================");
            Console.WriteLine("Student Information");
            Console.WriteLine("=================");
            // 2. Input from user
            Console.WriteLine("Enter your Name: ");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter your Mark: ");
            Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Full Mark: ");
            Full_Mark = Convert.ToInt32(Console.ReadLine());
            // 3. Calculate percentage
            Perctange = (Mark / Full_Mark) * 100;

            // 4. Output Result
            Console.WriteLine("Student Information : ");
            Console.WriteLine("Student Name : " + StudentName);
            Console.WriteLine("Student Mark : " + Mark);
            Console.WriteLine("Student Full Mark : " + Full_Mark);
            Console.WriteLine("Student Percentage : " + Perctange + "%");
            if (Perctange >= 85)
            {
                Console.WriteLine("Excellent ");
            }
            else if (Perctange >= 75)
            {
                Console.WriteLine("Very Good ");
            }
            else if (Perctange >= 65)
            {
                Console.WriteLine("Good ");
            }
            else if (Perctange >= 50)
            {
                Console.WriteLine("Pass ");
            }
            else
            {
                Console.WriteLine("Failed ");
            }
        }

        public static void BMI_Calculating_system()
        {

            //declear Var
            string PatientName;
            double height;
            double weight;
            double BMI;
            //inputs 
            Console.WriteLine("=================");
            Console.WriteLine("BMI Calculating system");
            Console.WriteLine("=================");
            Console.WriteLine("pls Enter Your Name ");
            PatientName = Console.ReadLine();
            Console.WriteLine("pls Enter Your Height ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pls Enter Your Weight ");
            weight = Convert.ToDouble(Console.ReadLine());
            //calcualte Bmi
            BMI = weight / (height * height);
            // Display Result 
            Console.WriteLine("Patient Name is " + PatientName);
            Console.WriteLine("Patient Height is " + height + " M");
            Console.WriteLine($"Patient Weight is   {weight} K.g");
            Console.WriteLine("BMI is " + BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("under weight");
            }
            else if (BMI < 25)
            {
                Console.WriteLine("normal weight");
            }
            else if (BMI < 30)
            {
                Console.WriteLine("over weight");
            }
            else
            {
                Console.WriteLine("obese ");
            }
        }
    }
}
