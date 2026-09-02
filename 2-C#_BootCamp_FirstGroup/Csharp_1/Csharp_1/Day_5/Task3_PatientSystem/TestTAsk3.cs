using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Task3_PatientSystem
{
    class TestTAsk3
    {
        //static void Main(string[] args)
        //{
        //    /*
        //     Patient System
        //                - Create an **abstract class** `PatientBase` with:
        //                        - Properties: `Name`, `Height`, `Weight`
        //                        - Abstract Method: `GetBMI()`
        //                - Create an **interface** `IBodyStatus` with:
        //                        - Method: `GetStatus(double bmi)`
        //       - Implement a class `Patient` that inherits from `PatientBase` and implements `IBodyStatus`.
        //     */
        //    Patient patient = new Patient("Fatimah", 1.65, 60);

        //    double bmi = patient.GetBMI();
        //    string status = patient.GetStatus(bmi);

        //    Console.WriteLine($"Patient Name: {patient.Name}");
        //    Console.WriteLine($"Height: {patient.Height}");
        //    Console.WriteLine($"Weight: {patient.Weight}");
        //    Console.WriteLine($"BMI: {bmi:F2}");
        //    Console.WriteLine($"Status: {status}");
        //}
    }

    public abstract class PatientBase
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        protected PatientBase(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        public abstract double GetBMI();
    }

    public interface IBodyStatus
    {
        string GetStatus(double bmi);
    }

    public class Patient : PatientBase, IBodyStatus
    {
        public Patient(string name, double height, double weight)
            : base(name, height, weight)
        {
        }

        public override double GetBMI()
        {
            return Weight / (Height * Height);
        }

        public string GetStatus(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 25)
                return "Normal";
            else if (bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }
    }

}
