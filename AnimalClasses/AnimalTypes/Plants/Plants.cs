using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.AnimalClasses;

namespace Inheritance.AnimalClasses.AnimalTypes.Plants
{
    // Declaring the Plant base class
    public class Plant : Animal
    {

        // Sets default values if none are passed in when creating object
        public Plant()
        {
            _favFood = "Sunlight";
            _noise = "*Silence*";
            _age = 87;
        }



        // Prints all the information about the Plant
        public void AboutPlant()
        {
            Console.WriteLine($"Favorite food: {_favFood}\nLegs:\nAge: {_age}");
        }
    }
}
