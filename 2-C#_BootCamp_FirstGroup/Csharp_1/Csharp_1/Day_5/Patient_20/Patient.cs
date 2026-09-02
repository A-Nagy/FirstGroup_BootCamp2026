using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Patient_20
{
     class Patient : Person , IPrintable
    {
        // **Patient**
        //- Properties: `Name`, `Height`, `Weight`
        //- Functions:
        //  - `GetBMI()` → calculates Body Mass Index
        //  - `GetBodyStatus()` → returns weight classification

 
         double _height;
         double _weight;
        public Patient(string nm, double wg, double hg)
            :base(nm)
        {
    
            Weight = wg;
            Height = hg;
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value < 0 ? 0 : value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value < 0 ? 0 : value; }
        }
        public double GetBMI()
        {
            return Weight / (Height * Height);
        }
        public string GetBodyStatus()
        {
            double bmi = GetBMI();
 
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }
        public override string GetInfo()
        {
            return $"Patient Name         : {Name} \n" +
                   $"Patient Height       : {Height}\n" +
                   $"Patient Weight       : {Weight} \n" +
                   $"Patient BMI          : {GetBMI()}\n" +
                   $"Patient Body Status  : {GetBodyStatus()}";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Patient Name         : {Name} \n" +
                   $"Patient Height       : {Height}\n" +
                   $"Patient Weight       : {Weight} \n" +
                   $"Patient BMI          : {GetBMI()}\n" +
                   $"Patient Body Status  : {GetBodyStatus()}");        }
    }
}
