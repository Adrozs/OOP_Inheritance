using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AnimalClasses.AnimalTypes.Mammals.Dogs
{
    internal class Husky : Dog
    {
        // Changes the default values to fit Huskys
        public Husky()
        {
            _size = "big";
            _favFood = "anything edible(optional)";
            _noise = "Ooowhoooooooo!";
        }

        public void Fetch()
        {
            Console.WriteLine("*The Husky excitedly runs after the stick and.. eats the stick when it catches it*");
        }
    }
}
