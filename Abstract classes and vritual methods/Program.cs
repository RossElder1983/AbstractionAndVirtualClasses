// See https://aka.ms/new-console-template for more information
using Abstract_classes_and_vritual_methods;
using Abstract_classes_and_vritual_methods.Abstract;
using Abstract_classes_and_vritual_methods.Concrete.Animals;
using Abstract_classes_and_vritual_methods.Concrete.Animals.Dogs;
using Abstract_classes_and_vritual_methods.Concrete.Shapes;

Console.WriteLine("Abstract classes");

var circle = new Circle(10, "blue");
var square = new Square(15, "yellow");

var circleColour = ShapeHelper.getColour(circle);

Console.WriteLine($"The circle colour is {circleColour}");

ShapeHelper.printColour(square);

Console.WriteLine("\nVirtual methods");

var genericDog = new Dog();
var spaniel = new Spaniel();
var germanShep = new GermanShepard();

genericDog.PrintBreed();
spaniel.PrintBreed();
germanShep.PrintBreed();


