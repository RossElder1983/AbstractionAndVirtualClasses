using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_and_vritual_methods.Abstract
{
    public abstract class Shape
    {
        public abstract double Area { get; }

        // A normal property with a protected setter
        public string Color { get; protected set; }

        // Constructor for shared logic
        protected Shape(string color)
        {
            Color = color;
        }

        // A common method
        public void PrintColor()
        {
            Console.WriteLine($"Shape color: {Color}");
        }
    }
}
