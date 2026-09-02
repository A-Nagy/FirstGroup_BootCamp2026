using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.FirstStepInTask_16_DashBoardSystem
{
     class PatientClass
    {
        public void printPatient() 
        {
            Console.WriteLine("======================");
            Console.WriteLine("BMI Calculating system");
            Console.WriteLine("======================");

        }
        public object[] PatientInputs() 
        {
            Console.WriteLine("pls Enter Patient Name ");
           string PatientName = Console.ReadLine();
            Console.WriteLine("pls Enter Patient Height ");
           double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pls Enter Patient Weight ");
           double weight = Convert.ToDouble(Console.ReadLine());

            return new object[] {PatientName, height, weight};
        }

        double getBMI(double height, double weight) 
        {
            return weight / (height * height);
        }

        string getBodyStatus(double height, double weight) 
        {
            double BMI= getBMI(height, weight);

            if (BMI < 18.5)
            {
               return"under weight";
            }
            else if (BMI < 25)
            {
                return"normal weight";
            }
            else if (BMI < 30)
            {
              return"over weight";
            }
            else
            {
               return "obese ";
            }
        }

        public string[] GetPatientSummary(string name , double height , double weight) 
        {
            return new string[] { "Patient Information : \n" ,
                                  "Patient Name is " + name ,
                                  "Patient Height is " + height + " M" ,
                                 $"Patient Weight is   {weight} K.g" ,
                                  "Patient BMI is " + getBMI(height, weight) ,
                                  "Patient Body Status is " + getBodyStatus(height, weight) };
        }

        public void PrintSummary(string[] Summary)
        {
            foreach (string s in Summary)
            {
                Console.WriteLine(s);
            }
        }

    }
}
