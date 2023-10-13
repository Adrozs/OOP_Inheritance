using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Interfaces;

namespace Inheritance.AnimalClasses.AnimalTypes.Mammals.Dogs
{
    // Declaring the class "Dog" which inherits all the charestaristics from "Mammals" and is tame
    internal class Dog : Mammal, ITame
    {
        // Declaring it's unique field 
        protected string _size;

        // Overwrites some values from the default of the base class to things fitting Dogs upon creation of the object.
        public Dog()
        {
            _favFood = "Bones";
            _noise = "Woof";
            _age = 3;
            _legs = 4;
            _size = "medium";
        }

        // Calling on the base constructor in Animal via Mammal to set those values without re-writing the code
        // and adding the unique parameter to the constructor
        public Dog(string favFood, string noise, string gender, int legs, int age, string size) : base(favFood, noise, gender, legs, age)
        {
            _size = size;
        }

        // The Dog class' unique method. When called it prints out the fetch message shown below.
        public void Fetch()
        {
            Console.WriteLine("*You throw a stick and the dog runs after it and comes back with it, happily wiggling its tail.*");
        }

        public void Tame()
        {
            Console.WriteLine("I am tame");
        }
    }
}
