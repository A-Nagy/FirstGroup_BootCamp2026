using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_3
{
     class Loops_10
    {
        //        static void Main(string[] args)
        //        {
        //            //Console.WriteLine("1");
        //            //Console.WriteLine("2");
        //            //Console.WriteLine("3");
        //            //Console.WriteLine("4");
        //            //Console.WriteLine("5");
        //            //Console.WriteLine("6");
        //            //Console.WriteLine("7");
        //            //Console.WriteLine("8");
        //            //Console.WriteLine("9");
        //            //Console.WriteLine("10");
        //            ////////////////////////////////////

        //            //1. For Loop  

        //            //for(int counter = 1; counter <= 10 ; counter ++ ) 
        //            //{
        //            //    Console.WriteLine(counter);
        //            //}
        //            /*
        //             * 
        //            ### `for` loop – Counting from 1 to 5  
        //            Iterates using a counter,
        //            useful when the number of repetitions is known.
        //             */
        //            //for (int i = 1; i <= 5; i++)
        //            //{
        //            //    Console.WriteLine(i);
        //            //}
        //            //for (int counter = 1; counter <= 5; counter++)
        //            //{
        //            //    Console.WriteLine(counter);

        //            //}
        //            //////////////////////////////////////////

        //            //2.while Loop
        //            //bool startpoint = true;

        //            //while(startpoint==true) 
        //            //{
        //            //    Console.WriteLine(startpoint);

        //            //    Console.WriteLine("do you want stop y , n ");
        //            //    string answ= Console.ReadLine().ToLower();

        //            //    if (answ == "y")
        //            //    {
        //            //        startpoint = false;
        //            //    }

        //            //}
        //            /*
        //             * 
        //            ## ✅ Task 2: Sum of Even Numbers using `while` loop  
        //            Ask the user to enter a number `n`, 
        //            then calculate the sum of all even numbers from 1 to `n`.
        //             * 
        //             */
        //            //Console.WriteLine("Pls Enter Number");
        //            //int n  = Convert.ToInt32(Console.ReadLine());//10

        //            //int i   = 1; 
        //            //int sum = 0;

        //            //while (i <= n) 
        //            //{
        //            //    if (i % 2 == 0)
        //            //    {
        //            //        sum += i;
        //            //    }

        //            //    i ++ ;

        //            //}
        //            //Console.WriteLine("sum is : "+sum);

        //            /////////////////////////////////////////////////

        //            //3.Do...While Loop

        //            // int start_point = 1;

        //            //do
        //            // {
        //            //     Console.WriteLine(start_point);
        //            //     start_point ++ ;

        //            // } while (start_point >= 10) ;
        //            /*
        //             * 
        //                ## ✅ Task 3: Password Retry using `do-while` loop  
        //                Let the user enter a password and 
        //                keep prompting until they enter "admin123".
        //             */
        //            //string pass;

        //            //do
        //            //{
        //            //    Console.WriteLine("enter your password :");
        //            //    pass = Console.ReadLine().ToLower();



        //            //} while (pass != "admin123");

        //            //Console.WriteLine("Access Granted");

        //            /////////////////////////////////////////////////

        //            // 4.foreach

        //            //string[] colors = { "Red", "Green", "Blue" };

        //            // //counter = 0   condition <= index limit     step
        //            //for (int x = 0;    x <= colors.Length-1      ; x++ ) 
        //            //{
        //            //    Console.WriteLine(colors[x]);
        //            //}

        //            //foreach (string color in colors ) 
        //            //{
        //            //    Console.WriteLine(color);
        //            //}
        //            /*
        //             ## ✅ Task 4: List Items using `foreach` loop  
        //                    Create an array of student names, 
        //                    and print each name using a `foreach` loop.
        //             */

        //            //string[] names = { "fatmai", "ali", "hussain", "rami", "fadi" };

        //            //foreach (string name in names)
        //            //{
        //            //    Console.WriteLine(name);
        //            //}

        //            /*
        // ### `for` loop – Counting from 1 to 5  
        //Iterates using a counter, useful when the number of repetitions is known.

        /*
         * for(int i = 1 ; i <= 5 ; i++)
         * {
         *    Console.WriteLine("Number: "+ i ) ;
         * }
         */

        //### `while` loop – Login Simulation  
        //Repeats while a condition remains true. In this case,
        //            until the username is "admin".

        /*
         string username="";
        while (username !="admin")
        {
          Console.WriteLine("Enter UserName");
         username= Console.ReadLine();
        }
         Console.WriteLine("Welcome , Admin");
         
         */

        //### `do-while` loop – Age Validation  
        //Always runs once, 
        //then checks if the entered age is within
        //the accepted range (18–60).

        /*
         *  int age ; 
         *  do
         *  {
         *      Console.WriteLine ("Enter A Valid Age (between (18–60)");
         *      age= int.Parse(Console.ReadLine();
         *  } While (age < 18 || age > 60);
         * Console.WriteLine("Accepted Age : "+ age); 
         */


        //### `foreach` loop – Listing Cities  
        //Used to iterate through arrays or collections 
        //without needing an index.
        //             */
        /*
         *   string[] cities = { "Cairo", "Riyadh", "Amman", "Beirut" };
         *   foreach(strine city in cities)
         *   {
         *     Console.WriteLine(city); 
         *   }
         */

        //        }
    }
}
