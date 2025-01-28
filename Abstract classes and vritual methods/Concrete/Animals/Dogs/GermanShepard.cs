using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_and_vritual_methods.Concrete.Animals.Dogs
{
    public class GermanShepard : Dog
    {
        public GermanShepard() { }

        public override void PrintBreed()
        {
            Console.WriteLine("I am a German Shepard!");
            base.PrintBreed();
        }
    }
}
