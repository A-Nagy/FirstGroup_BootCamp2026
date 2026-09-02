using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Explain_Abstract
{
     class Rectangle : Shape
    {
        public double Hight { get; set; }
        public double Width { get; set; }
        public Rectangle(double hight, double width)
        {
            Hight = hight;
            Width = width;
        }
        public override double GetArea() 
        {
            return Hight * Width;
        }

        
    }
}
