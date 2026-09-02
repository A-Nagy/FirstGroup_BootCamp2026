using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5.Room_19
{
     class Room
    {
        /*
         * *Room**
          - Properties: `Length`, `Width`, `Height`
          - Function: `GetVolume()` → calculates room volume
         */

        // Fields
        // Fields are variables
        // that are declared within a class and are
        // used to store data related to the class.
         double _length;
         double _width;
         double _height;
        // Properties
        // Properties are used to encapsulate the fields of a class
        // and provide controlled access to them.
        public double Length
        {
            get {return _length; }
            set { _length = value > 0 ? value : 0; }
        }
        public double Width
        {
            get { return _width; }
            set { _width = value > 0 ? value : 0; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value > 0 ? value : 0; }
        }
        //Constractor 
        // A constructor is a special method that is called when an object is created.
        // It is used to initialize the object's properties and perform any necessary setup.
        // The constructor has the same name as the class and does not have a return type.
        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;

        }


        public double GetVolume()
        {
            return (Length * Width );
        }
    }
}
