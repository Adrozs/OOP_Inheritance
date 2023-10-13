using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Interfaces;

namespace Inheritance.AnimalClasses.AnimalTypes.Reptiles
{
    // Declaring the class "Snake" which inherits all the charestaristics from the parrent class "Reptile"
    internal class Snake : Reptile, IWild
    {
        // Declaring it's unique parameter
        protected string _length;


        // Overwrites some values from the default of the base class to things fitting Dogs upon creation of the object.
        public Snake()
        {
            _favFood = "Mice";
            _noise = "Hiiissss";
            _age = 8;
            _legs = 0;
            _length = "3 meters";
        }

        // Calling on the base constructor in Animal via Mammal to set those values without re-writing the code
        // and adding the unique parameter to the constructor
        public Snake(string favFood, string noise, string gender, int legs, int age, string length) : base(favFood, noise, gender, legs, age)
        {
            _length = length;
        }

        // The Snake class' unique method.
        public void ShedSkin()
        {
            Console.WriteLine("*The snake wriggles around, its time for it to shed its scaly skin and change into a new fresh one*");
        }

        public void Wild()
        {
            Console.WriteLine("I am wild");
        }
    }
}
