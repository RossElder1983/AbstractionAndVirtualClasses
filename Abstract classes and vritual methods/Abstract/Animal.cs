using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_and_vritual_methods.Abstract
{
    public abstract class Animal
    {
        // Abstract method (no implementation here)
        public abstract void MakeSound();
     
        // Regular method (has implementation)
        public void Breathe()
        {
            Console.WriteLine("Breathing...");
        }

        // Abstract method (no implementation here)
        public abstract void WhatAmI();
    }
}
