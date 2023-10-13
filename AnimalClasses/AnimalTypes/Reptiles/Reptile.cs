using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.AnimalClasses;

namespace Inheritance.AnimalClasses.AnimalTypes.Reptiles
{
    // Delcaring the subclass Reptile
    internal class Reptile : Animal
    {
        // Calls on the base class's empty constructor to set default values if no values are sent in upon creation
        public Reptile() : base()
        {

        }

        // Calls on the base constructor in Anmial so sub classes can make use of the Animal constructor
        public Reptile(string favFood, string noise, string gender, int legs, int age) : base(favFood, noise, gender, legs, age)
        {
        }
    }
}
