using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_2
{
    internal class Controls_Else_If_5
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("pls Enter Number");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (num >= 100)
        //    {
        //        Console.WriteLine("your Number have more than two Digit");

        //    }
        //    else if (num >= 10)
        //    {
        //        Console.WriteLine("your Number have two Digit");

        //    }
        //    else if (num >= 0)
        //    {
        //        Console.WriteLine("your Number have One Digit");

        //    }
        //    else 
        //    {
        //        Console.WriteLine("your Number is Nagitive Number");
        //    }


        //    //// ## ✅ Task 1: Employee Salary Info
        //    //// **Objective:**
        //    ////-- Ask the employee to enter their name and monthly salary.
        //    ////-- Display their name, monthly salary, and calculated annual salary.
        //    /// - Classify salary as:
        //    //         -15,000  or more    → "High Salary"
        //    //         - 10,000 or more    → "Normal Salary"
        //    //         - 5,000  or more    → "Low Salary"
        //    //         - Less   than 5,000 → "Very Low Salary"

        //        // 1.Variable Declaration
        //    string name;
        //    int salary;
        //    int annualSalary;

        //    // 2. Input from user
        //    Console.WriteLine("Enter your name:");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Enter your monthly salary:");
        //    salary = Convert.ToInt32(Console.ReadLine());

        //    // 3. Calculate annual salary
        //    annualSalary = salary * 12;

        //    // 4. Output Result
        //    Console.WriteLine("=================");
        //    Console.WriteLine("Employee Salary Info");
        //    Console.WriteLine("=================");
        //    Console.WriteLine("Name: " + name);
        //    Console.WriteLine("Monthly Salary: " + salary);
        //    Console.WriteLine("Annual Salary: " + annualSalary);

        //    if (salary >= 15000)
        //    {
        //        Console.WriteLine("high salary");
        //    }
        //    else if (salary >= 10000)
        //    {
        //        Console.WriteLine("normal salary");
        //    }
        //    else if (salary >= 5000)
        //    {
        //        Console.WriteLine("low salary");
        //    }
        //    else
        //    {
        //        Console.WriteLine("very low salary");

        //    }


        //    //if (salary >= 15000)
        //    //{
        //    //    Console.WriteLine("High Salary ");
        //    //}
        //    //else if (salary >= 10000)
        //    //{
        //    //    Console.WriteLine("Normal Salary ");
        //    //}
        //    //else if (salary >= 5000)
        //    //{
        //    //    Console.WriteLine("low Salary ");
        //    //}
        //    //else if (salary < 5000)
        //    //{
        //    //    Console.WriteLine("Very low Salary ");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Invalid Input ");
        //    //}



        //    //## ✅ Task 2: Student Percentage Calculator
        //    // **Objective:**
        //    // -Ask the student to enter their name, obtained mark, and full mark.
        //    //  percentage =mark / Fullmark * 100
        //    // - Calculate and display their percentage.
        //  //  -Classify grade based on percentage:
        //  //    -85 % or more → "Excellent"
        //  //    - 75 % or more → "Very Good"
        //  //    - 65 % or more → "Good"
        // //     - 50 % or more → "Pass"
        //  //    - Below 50 % → "Failed"

        //    // 1.Variable Declaration
        //    string StudentName;
        //    int Mark;
        //    int Full_Mark;
        //    int Perctange;

        //    // 2. Input from user
        //    Console.WriteLine("Enter your Name: ");
        //    StudentName = Console.ReadLine();

        //    Console.WriteLine("Enter your Mark: ");
        //    Mark = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter the Full Mark: ");
        //    Full_Mark = Convert.ToInt32(Console.ReadLine());

        //    // 3. Calculate percentage
        //    Perctange = (Mark / Full_Mark) * 100;

        //    // 4. Output Result
        //    Console.WriteLine("Student Information : ");
        //    Console.WriteLine("Student Name : " + StudentName);
        //    Console.WriteLine("Student Mark : " + Mark);
        //    Console.WriteLine("Student Full Mark : " + Full_Mark);
        //    Console.WriteLine("Student Percentage : " + Perctange + "%");
        //    if (Perctange >= 85)
        //    {
        //        Console.WriteLine("Excellent ");
        //    }
        //    else if (Perctange >= 75)
        //    {
        //        Console.WriteLine("Very Good ");
        //    }
        //    else if (Perctange >= 65)
        //    {
        //        Console.WriteLine("Good ");
        //    }
        //    else if (Perctange >= 50)
        //    {
        //        Console.WriteLine("Pass ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed ");
        //    }




        //    //# ✅ Task 3: Patient BMI Calculator
        //    // *Objective:**
        //    //  height(in meters), and weight(in kg).
        //    //   Calculate BMI using the formula:
        //    //       BMI = weight / (height * height)
        //    //  -Display the name, height, weight, and BMI.
        //    //-Classify BMI as:
        //    //  -Less than 18.5 → "Underweight"
        //    //  - 18.5 to less than 25 → "Normal Weight"
        //    //  - 25 to less than 30 → "Overweight"
        //    //  - 30 or more → "Obese"

        //    //declear Var
        //    string PatientName;
        //    double height;
        //    double weight;
        //    double BMI;
        //    //inputs 

        //    Console.WriteLine("pls Enter Your Name ");
        //    PatientName = Console.ReadLine();
        //    Console.WriteLine("pls Enter Your Height ");
        //    height = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("pls Enter Your Weight ");
        //    weight = Convert.ToDouble(Console.ReadLine());
        //    //calcualte Bmi
        //    BMI = weight / (height * height);
        //    // Display Result 
        //    Console.WriteLine("Patient Name is " + PatientName);
        //    Console.WriteLine("Patient Height is " + height + " M");
        //    Console.WriteLine($"Patient Weight is   {weight} K.g");
        //    Console.WriteLine("BMI is " + BMI);

        //    if (BMI < 18.5)
        //    {
        //        Console.WriteLine("under weight");
        //    }
        //    else if (BMI < 25)
        //    {
        //        Console.WriteLine("normal weight");
        //    }
        //    else if (BMI <30)
        //    { 
        //    Console.WriteLine("over weight");
        //    }
        //    else
        //    { 
        //    Console.WriteLine("obese ");
        //    }

        //    //////////////////
        //    //if (BMI < 18.5)
        //    //{
        //    //    Console.WriteLine("under weight");
        //    //}
        //    //else if (BMI < 25)
        //    //{
        //    //    Console.WriteLine("normal weight");
        //    //}
        //    //else if (BMI < 30)
        //    //{
        //    //    Console.WriteLine("over weight");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("obese");

        //    //}

        //}

    }
}
