using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_1.Day_2
{
    class Controls_Switch_6
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter Number Of Day (1-7) ");
        //    int Day_Num = Convert.ToInt32(Console.ReadLine());

        //    switch (Day_Num) 
        //    {
        //        case 1:
        //            Console.WriteLine("Sat"); ///week end
        //            break;
        //        case 2:
        //            Console.WriteLine("sun"); ///work day 
        //            break;
        //        case 3:
        //            Console.WriteLine("Mon"); ///work day 
        //            break;
        //        case 4:
        //            Console.WriteLine("tue"); ///work day 
        //            break;
        //        case 5:
        //            Console.WriteLine("wed"); ///work day 
        //            break;
        //        case 6:
        //            Console.WriteLine("thur"); ///work day 
        //            break;
        //        case 7:
        //            Console.WriteLine("Fri");  //week end
        //            break;
        //        default:
        //            Console.WriteLine("invalid Number"); 
        //            break;
        //    }

        //    //switch (Day_Num)
        //    //{
        //    //    case 1:
        //    //        Console.WriteLine("Weekday");
        //    //        break;
        //    //    case 2:
        //    //        Console.WriteLine("Weekday");
        //    //        break;
        //    //    case 3:
        //    //        Console.WriteLine("Weekday");
        //    //        break;
        //    //    case 4:
        //    //        Console.WriteLine("Weekday");
        //    //        break;
        //    //    case 5:
        //    //        Console.WriteLine("Weekday");
        //    //        break;
        //    //    case 6:
        //    //        Console.WriteLine("Week End");
        //    //        break;
        //    //    case 7:
        //    //        Console.WriteLine("Week End ");
        //    //        break;

        //    //    default:
        //    //        Console.WriteLine("Invalid Input");
        //    //        break;


        //    Console.WriteLine("enter num of day  ");
        //    int day_num = Convert.ToInt32(Console.ReadLine());

        //    switch (day_num)
        //    {

        //        case 1:
        //        case 2:
        //        case 3:
        //        case 4:
        //        case 5:
        //            Console.WriteLine("Work Day");
        //            break;
        //        case 6:
        //        case 7:
        //            Console.WriteLine("Week End");
        //            break;

        //        default:
        //            Console.WriteLine("invalid num");
        //            break;

        //    }


        //    /*
        //     * ## 🧠 Task 2: Grade Description by Letter
        //        **Objective:**
        //        - Ask the user to enter a letter grade (A–F).
        //        - Display the corresponding performance description.
        //        **Descriptions:**
        //        - A → Excellent
        //        - B → Very Good
        //        - C → Good
        //        - D → Pass
        //        - F → Failed
        //     */
        //    Console.WriteLine("pls Enter Your Grade");
        //    char gread = Convert.ToChar(Console.ReadLine().ToUpper());
        //    switch (gread)
        //    {
        //        case 'A':
        //            Console.WriteLine("excellent");
        //            break;
        //        case 'B':
        //            Console.WriteLine("verygood");
        //            break;
        //        case 'C':
        //            Console.WriteLine("good");
        //            break;
        //        case 'D':
        //            Console.WriteLine("pass");
        //            break;
        //        case 'F':
        //            Console.WriteLine("failed");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid Input");
        //            break;

        //    }

        //    Console.WriteLine("Enter your Grade: ");
        //    string Grade = Console.ReadLine().ToUpper();
        //    switch (Grade)
        //    {
        //        case "A":
        //            Console.WriteLine("E");
        //            break;

        //        case "B":
        //            Console.WriteLine("VG");
        //            break;
        //        case "C":
        //            Console.WriteLine("G");
        //            break;
        //        case "D":
        //            Console.WriteLine("P");
        //            break;
        //        case "F":
        //            Console.WriteLine("F");
        //            break;

        //        default:
        //            Console.WriteLine("invalid input");
        //            break;

        //    }

        //    Console.WriteLine("Enter ur grade A-F Use Capital Case");
        //    string Grade1 = Console.ReadLine().ToUpper();
        //    switch (Grade1)
        //    {
        //        case "A":
        //            Console.WriteLine("Excellent");
        //            break;
        //        case "B":
        //            Console.WriteLine("Very Good");
        //            break;
        //        case "C":
        //            Console.WriteLine("Good");
        //            break;
        //        case "D":
        //            Console.WriteLine("Pass");
        //            break;
        //        case "F":
        //            Console.WriteLine("Failed");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid Input");
        //            break;
        //    }

        //    /*
        //     * # 🧠 Task 3: Month Days Count
        //        **Objective:**
        //        - Ask the user to enter the month number (1–12).
        //        - Display the number of days in that month.
        //        - 1,3,5,7,8,10,12  => 31
        //        - 4,6,9,11         => 30
        //        **Special Case:**
        //        - February (2) → 28 or 29 days depending on leap year

        //     */

        //    Console.WriteLine("enter a namuber : ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    switch (num)
        //    {

        //        case 1:
        //        case 3:
        //        case 5:
        //        case 7:
        //        case 8:
        //        case 10:
        //        case 12:
        //            Console.WriteLine("31 days ");
        //            break;
        //        case 4:
        //        case 6:
        //        case 9:
        //        case 11:
        //            Console.WriteLine("30 days ");
        //            break;
        //        case 2:
        //            Console.WriteLine("28 or 29 days depending on leap year ");
        //            break;
        //        default:
        //            Console.WriteLine("invalid number");
        //            break;
        //    }



        //    //Console.WriteLine("Enter the number of month");
        //    //int month = Convert.ToInt32(Console.ReadLine());

        //    //switch (month)
        //    //{
        //    //    case 1:
        //    //        Console.WriteLine("31 days");
        //    //        break;
        //    //    case 2:
        //    //        Console.WriteLine("Either 28 or 29 days");
        //    //        break;
        //    //    case 3:
        //    //        Console.WriteLine("31 days");
        //    //        break;
        //    //    case 4:
        //    //        Console.WriteLine("30 days");
        //    //        break;
        //    //    case 5:
        //    //        Console.WriteLine("31 days");
        //    //        break;
        //    //    case 6:
        //    //        Console.WriteLine("30 days");
        //    //        break;
        //    //    case 7:
        //    //        Console.WriteLine("31 days");
        //    //        break;
        //    //    case 8:
        //    //        Console.WriteLine("31 days");
        //    //        break;
        //    //    case 9:
        //    //        Console.WriteLine("30 days");
        //    //        break;
        //    //    case 10:
        //    //        Console.WriteLine("31 days");
        //    //        break;
        //    //    case 11:
        //    //        Console.WriteLine("30 days");
        //    //        break;
        //    //    case 12:
        //    //        Console.WriteLine("31 days");
        //    //        break;
        //    //    default:
        //    //        Console.WriteLine("Invalid Input");
        //    //        break;
        //    //}

        //    //Console.WriteLine("enter num of month  ");
        //    //int num = Convert.ToInt32(Console.ReadLine());

        //    //switch (num)
        //    //{

        //    //    case 1:
        //    //    case 3:
        //    //    case 5:
        //    //    case 7:
        //    //    case 8:
        //    //    case 10:
        //    //    case 12:
        //    //        Console.WriteLine("31");
        //    //        break;

        //    //    case 4:
        //    //    case 6:
        //    //    case 9:
        //    //    case 11:
        //    //        Console.WriteLine("30");
        //    //        break;

        //    //    case 2:
        //    //        Console.WriteLine("28 or 29");
        //    //        break;

        //    //    default:
        //    //        Console.WriteLine("invalid num");
        //    //        break;

        //    //}

        //}
    }
}
