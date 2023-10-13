using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Interfaces;

namespace Inheritance.AnimalClasses.AnimalTypes.Mammals
{
    // Declaring the class "Cow" which inherits all the charestaristics from the parrent class.
    internal class Cow : Mammal, ITame
    {

        // Initializing it's unique parameter "milkCow" to true
        protected bool _milkCow;


        // Overwrites some values from the default of the base class to things fitting Dogs upon creation of the object.
        public Cow()
        {
            _favFood = "Grass";
            _noise = "Moo";
            _age = 8;
            _legs = 4;
            _milkCow = true;
        }

        // Calling on the base constructor in Animal via Mammal to set those values without re-writing the code
        // and adding the unique parameter to the constructor
        public Cow(string favFood, string noise, string gender, int legs, int age, bool milkCow) : base(favFood, noise, gender, legs, age)
        {
            _milkCow = milkCow;
        }

        // The Cow class' unique method. When called it prints out the cow release message shown below
        public void CowRelase()
        {
            Console.WriteLine("*The cows are released outside after the long winter and are joyfully running and jumping around in the nice spring grass*");
        }

        public void Tame()
        {
            Console.WriteLine("I am tame");
        }

    }
}
