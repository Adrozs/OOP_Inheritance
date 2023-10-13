using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AnimalClasses.AnimalTypes.Mammals
{
    internal class Human : Mammal
    {
        // Initializing it's unique default parameter.
        protected bool _thumbs;

        // Overwrites some values from the default of the Animal class to things fitting Humans upon creation of human object.
        public Human()
        {
            _favFood = "Pizza";
            _noise = "Tjeeenare mannen!";
            _gender = "Male";
            _age = 24;
            _legs = 2;
            _thumbs = true;
        }


        // Calling on the base constructor in Animal via Mammal to  set those values without re-writing the code
        // and adding the unique parameter to the constructor
        public Human(string favFood, string noise, string gender, int legs, int age, bool thumbs) : base(favFood, noise, gender, legs, age)
        {
            _thumbs = thumbs;
        }

        // The Human class' unique method. 
        public void DestroyWorld()
        {
            Console.WriteLine("*By mere existing, the human manges to annihilate the world*");
        }
    }
}
