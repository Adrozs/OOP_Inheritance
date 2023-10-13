using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.AnimalClasses;

namespace Inheritance.AnimalClasses.AnimalTypes.Mammals
{
    // Delcaring the subclass Mammal
    internal class Mammal : Animal
    {
        // Calls on the base class's empty constructor to set default values if no values are sent in upon creation
        public Mammal() : base()
        {

        }

        // Calls on the base constructor in Anmial so sub classes can make use of the Animal constructor
        public Mammal(string favFood, string noise, string gender, int legs, int age) : base(favFood, noise, gender, legs, age)
        {
        }
    }
}
