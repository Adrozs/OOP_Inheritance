using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AnimalClasses.AnimalTypes.Mammals.Dogs
{
    internal class Chihuahua : Dog
    {

        // Changes the default values to fit Chihuahuas
        public Chihuahua()
        {
            _size = "small";
            _favFood = "Exclusive gold sprinkled gourmet beef wellington";
            _noise = "Waff Waff Waff!";
        }

        public void Fetch()
        {
            Console.WriteLine("*The Chihuahua looks down on you in a pitifull manner, wondering as to why you'd think it'd run after a stupid stick.");
        }

    }
}
