using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Explain_Abstract
{
    abstract class Shape
    {
        public void PrintText() 
        {
            Console.WriteLine("Shape CLass");
        }
        public abstract double GetArea();
    }
}
