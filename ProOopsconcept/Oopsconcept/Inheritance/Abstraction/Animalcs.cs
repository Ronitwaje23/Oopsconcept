using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept.Inheritance.Abstraction
{
    abstract class Animalcs
    {
        public abstract void AnimalSound();
        public void sleep()
        {
            Console.WriteLine("non abstract method");
        }

    }
}


    