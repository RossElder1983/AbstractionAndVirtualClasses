using Abstract_classes_and_vritual_methods.Abstract;

namespace Abstract_classes_and_vritual_methods.Concrete.Shapes
{
    public class Square : Shape
    {
        private double _sideLength;

        public Square(double sideLength, string color) : base(color)
        {
            _sideLength = sideLength;
        }

        // Must override the abstract property
        public override double Area
        {
            get { return _sideLength * _sideLength; }
        }
    }
}
