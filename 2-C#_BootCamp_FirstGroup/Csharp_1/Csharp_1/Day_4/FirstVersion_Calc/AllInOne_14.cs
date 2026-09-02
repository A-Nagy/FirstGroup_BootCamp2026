using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_4.FirstVersion_Calc
{
     class AllInOne_14
    {
        //static void Main(string[] args)
        //{
        //    double Num1, Num2;
        //    int ch = 0;
        //    do
        //    {
        //        Console.WriteLine("Choose Number Of Operation \n 1. + \n 2.- \n 3.X \n 4.÷ \n 5.Exit...");
        //        ch = int.Parse(Console.ReadLine());
             
        //        Console.WriteLine("Pls Enter Your First Number ");
        //        Num1 = Convert.ToDouble(Console.ReadLine());

        //        Console.WriteLine("Pls Enter Your Secand Number ");
        //        Num2 = Convert.ToDouble(Console.ReadLine());
        //        switch (ch)
        //        {
        //            case 1:
        //                Console.WriteLine(Add(Num1, Num2));
        //                break;
        //            case 2:
        //                Console.WriteLine(Sub(Num1, Num2));
        //                break;
        //            case 3:
        //                Console.WriteLine(Multi(Num1, Num2));
        //                break;
        //            case 4:
        //                Console.WriteLine(Divid(Num1, Num2));
        //                break;

        //                case 5:
        //                 Console.WriteLine("Exit...");
        //                break;

        //            default:
        //                Console.WriteLine("Invalid Number");
        //                break;
        //        }


        //    } while (ch != 5);
 

        //}

        static double  Add(double Num1 , double Num2 )
        { 
          return ( Num1 + Num2);
        }
        static double Sub(double Num1, double Num2)
        {
            return (Num1 - Num2);
        }
        static double Multi(double Num1, double Num2)
        {
            return (Num1 * Num2);
        }
        static double Divid(double Num1, double Num2)
        {
            return (Num1 / Num2);
        }


    }
}
