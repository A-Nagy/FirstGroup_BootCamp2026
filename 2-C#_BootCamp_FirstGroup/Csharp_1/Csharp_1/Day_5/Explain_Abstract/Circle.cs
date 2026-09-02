using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Explain_Abstract
{
     class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double ridaus)
        {
            Radius = ridaus;
        }
        

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
