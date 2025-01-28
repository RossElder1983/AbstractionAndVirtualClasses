using Abstract_classes_and_vritual_methods.Abstract;

namespace Abstract_classes_and_vritual_methods
{
    public static class ShapeHelper
    {
        public static string getColour(Shape shape)
        {            
            return shape.Color;
        }

        public static void printColour(Shape shape)
        {
            shape.PrintColor();
        }
    }
}
