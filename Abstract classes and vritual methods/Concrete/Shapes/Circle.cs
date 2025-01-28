using Abstract_classes_and_vritual_methods.Abstract;

namespace Abstract_classes_and_vritual_methods.Concrete.Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius, string color) : base(color)
        {
            _radius = radius;
        }

        // Must override the abstract property
        public override double Area
        {
            get { return Math.PI * _radius * _radius; }
        }
    }
}
