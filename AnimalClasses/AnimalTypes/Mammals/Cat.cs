using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Interfaces;

namespace Inheritance.AnimalClasses.AnimalTypes.Mammals
{
    internal class Cat : Mammal, ITame
    {
        // Declaring it's unique parameter
        protected string _coat;

        // Overwrites some values from the default of the base class to things fitting Dogs upon creation of the object.
        public Cat()
        {
            _favFood = "Fish";
            _noise = "Meow";
            _age = 14;
            _legs = 4;
            _coat = "Solid Black";
        }

        // Calling on the base constructor in Animal via Mammal to set those values without re-writing the code
        // and adding the unique parameter to the constructor
        public Cat(string favFood, string noise, string gender, int legs, int age, string coat) : base(favFood, noise, gender, legs, age)
        {
            _coat = coat;
        }


        // The Cat class' unique method. When called it prints out the cuddle message shown below.
        public void Cuddle()
        {
            Console.WriteLine("*The cat sits in your lap, making biscuts for a while until it lays down and falls asleep*");
        }

        public void Tame()
        {
            Console.WriteLine("I am tame");
        }
    }
}
