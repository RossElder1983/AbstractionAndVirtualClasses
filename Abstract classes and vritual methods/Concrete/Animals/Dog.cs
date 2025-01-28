using Abstract_classes_and_vritual_methods.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_and_vritual_methods.Concrete.Animals
{
    public class Dog : Animal
    {
        // Must override the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Woof and other dog noises");
        }

        public virtual void PrintBreed()
        {
            Console.WriteLine("Generic dog breed");
        }

        public sealed override void WhatAmI()
        {
            Console.WriteLine("Im a dog!");
        }
    }
}
