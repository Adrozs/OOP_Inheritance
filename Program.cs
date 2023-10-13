//Adrian Rozsahegyi NET23

using System.Threading.Channels;
using Inheritance.AnimalClasses.AnimalTypes.Mammals;
using Inheritance.AnimalClasses.AnimalTypes.Mammals.Dogs;
using Inheritance.AnimalClasses.AnimalTypes.Reptiles;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creates new animals
            Husky bob = new Husky();
            Cow bessy = new Cow();
            Cat zigge = new Cat();
            Dog buster = new Dog();
            Chihuahua sparkle = new Chihuahua();
            Snake ekans = new Snake();

            // Call the make sound function of each animal which prints out their unique sounds
            bob.MakeSound();
            bessy.MakeSound();
            zigge.MakeSound();
            buster.MakeSound();
            sparkle.MakeSound();
            ekans.MakeSound();


            Human rolf = new Human();
            rolf.DestroyWorld();
            rolf.AboutAnimal();

        }
    }

}