using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AnimalClasses
{
    // Declaring the base class Animal and initializing it with its default values and methods.
    public class Animal
    {
        // Declared variables as protected to keep them private but accessible in subclasses
        protected string _favFood;
        protected string _noise;
        protected string _gender;
        protected int _legs;
        protected int _age;


        // Default values if no arguments are passed in when creating new object
        public Animal()
        {
            _favFood = "Food";
            _noise = "*Noises*";
            _gender = "Unknown";
            _legs = 0;
            _age = 0;
        }

        // Sets values to input if input is passed in upon creation of object
        public Animal(string favFood, string noise, string gender, int legs, int age)
        {
            _favFood = favFood;
            _noise = noise;
            _gender = gender;
            _legs = legs;
            _age = age;
        }

        // Prints all the information about the animal
        public void AboutAnimal()
        {
            Console.WriteLine($"Gender: {_gender}\nLegs: {_legs}\nAge: {_age}");
        }

        // Prints out the animals noise
        public void MakeSound()
        {
            Console.WriteLine(_noise);
        }

        // Prints out what the animals favorite food is
        public void FavoriteFood()
        {
            Console.WriteLine(_favFood);
        }

    }
}
